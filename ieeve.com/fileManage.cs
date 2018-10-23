using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ieeve.com.Models;
using Newtonsoft.Json;

namespace ieeve.com
{
    public partial class fileManage : Form
    {
        private static string _sqlWhere;
        public fileManage()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allenPage1.PageIndexChanged += allenPage1_PageIndexChanged;
        }

        private void fileManage_Load(object sender, EventArgs e)
        {
            BindDataWithPage(1, _sqlWhere);
            InitSelectClass();
        }

        private void fileManage_Shown(object sender, EventArgs e)
        {

        }
        private void InitSelectClass()
        {
            var classAlist = new BLL.ClassAModelBLL().GetAll();
            List<Models.ClassBModel> classBlist = new BLL.ClassBModelBLL().GetAll();

            //控件列表
            List<Controls.MainClassPanel> classCtrlList = new List<Controls.MainClassPanel>();

            foreach (var classA in classAlist) //循环主类
            {
                List<Models.ClassBModel> ClassBList = classBlist.FindAll(s => s.ClassA == classA.ClassName); //选择某一子类

                List<RadioButton> roomControl = new List<RadioButton>();

                var floorPanel = new Controls.MainClassPanel { ClassAname = classA.ClassName, Dock = DockStyle.Top, AutoSize = true };
                floorPanel.comboBox1.DataSource = ClassBList;
                floorPanel.comboBox1.DisplayMember = "classB";
                floorPanel.comboBox1.ValueMember = "classB";
                classCtrlList.Add(floorPanel);
            }

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate { panelRoomList.Controls.AddRange(classCtrlList.ToArray()); }));
            }
            else
            {
                panelRoomList.Controls.AddRange(classCtrlList.ToArray());
            }
        }

        private void BindDataWithPage(int index, string sqlWhere)
        {
            allenPage1.PageIndex = index;
            DataTable dt = new BLL.FileInfoModelBLL().GetPagedDataTable(allenPage1.PageSize, index, sqlWhere);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var m = JsonConvert.DeserializeObject<List<Models.comboClassModel>>(dt.Rows[i]["classJson"].ToString());
                string result = "";
                foreach (var item in m)
                {
                    result += item.ClassA + "-" + item.ClassB + ";";

                }
                dt.Rows[i]["classJson"] = result;
            }



            dataGridView1.DataSource = dt;

            //设置列名
            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns["classJson"].HeaderText = "类别";
            dataGridView1.Columns["classJson"].Width = 200;
            dataGridView1.Columns[2].HeaderText = "文件名";
            dataGridView1.Columns[3].HeaderText = "建立时间";
            dataGridView1.Columns[4].HeaderText = "备注";
            dataGridView1.Columns[5].HeaderText = "状态";
            //设置时间格式
            var dataGridViewColumn = dataGridView1.Columns["CreateTime"];
            if (dataGridViewColumn != null)
            {
                dataGridViewColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dataGridViewColumn.FillWeight = 200;
            }
            //获取并设置总记录数
            allenPage1.RecordCount = new BLL.FileInfoModelBLL().GetTotalCount();
        }

        private void allenPage1_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataWithPage(allenPage1.PageIndex, _sqlWhere);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dv = sender as DataGridView;
            if (dv != null && dv.CurrentRow != null)
            {
                string imgFile = Server.ConfigHelper.UpLoadPath + dv.CurrentRow.Cells["fileUrl"].Value.ToString();
                if (File.Exists(imgFile))
                {
                    Pic_show fd = new Pic_show(imgFile);
                    fd.ShowDialog();
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dv = this.dataGridView1;
            if (dv != null && dv.CurrentRow != null)
            {
                string imgFile = Server.ConfigHelper.UpLoadPath + dv.CurrentRow.Cells["fileUrl"].Value.ToString();
                if (File.Exists(imgFile))
                {
                    Pic_show fd = new Pic_show(imgFile);
                    fd.ShowDialog();
                }
            }
        }
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pictureName = saveFileDialog1.FileName;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        Bitmap bmp = new Bitmap(pictureBox1.Image);
                        //保存到内存
                        //bmp.Save(mem, pictureBox1.Image.RawFormat );
                        //保存到磁盘文件
                        bmp.Save(@pictureName, pictureBox1.Image.RawFormat);
                        bmp.Dispose();
                    }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridView dv = sender as DataGridView;

            if (dv != null && dv.CurrentRow != null)
            {
                string picBoxfile = Server.ConfigHelper.UpLoadPath + dv.CurrentRow.Cells["fileUrl"].Value.ToString();
                if (File.Exists(picBoxfile)) pictureBox1.Image = Image.FromFile(picBoxfile);
                if (dv.CurrentRow.Cells["memo"].Value != null) tbMemo.Text = dv.CurrentRow.Cells["memo"].Value.ToString();
                lbID.Text = dv.CurrentRow.Cells["id"].Value.ToString();
                //   var relayModels = JsonConvert.DeserializeObject<List<Models.comboClassModel>>(dv.CurrentRow.Cells["classJson"].Value.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DataGridView dv = this.dataGridView1;
            if (dv != null && dv.CurrentRow != null)
            {
                string fileUrl = Server.ConfigHelper.UpLoadPath + dv.CurrentRow.Cells["fileUrl"].Value.ToString(); //todo,是否要删除原始图片？
                int.TryParse(dv.CurrentRow.Cells["id"].Value.ToString(), out var id);
                DialogResult result = MessageBox.Show("确认要删除所选内容吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    var r = new BLL.FileInfoModelBLL().DeleteById(id);
                    if (r > 0)
                    {
                        MessageBox.Show("删除成功！");
                        BindDataWithPage(allenPage1.PageIndex, _sqlWhere);
                    }
                }
            }
            else
            {
                MessageBox.Show("请先点击需要删除的记录！");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMsg = string.Empty;
            // if (pictureBox1.Image == null) errMsg += "请选择图片！\r\n";
            if (lbID.Text == "lbID") errMsg += "请点击您要修改的记录！\r\n";

            string errSubClass = "";//判断子分类
            List<Models.ClassJson> classJson = new List<ClassJson>();
            foreach (Panel item in panelRoomList.Controls)
            {
                if (item.Name != "panelSave")
                {
                    Controls.MainClassPanel panel = item as Controls.MainClassPanel;
                    errSubClass += panel.comboBox1.Text.Trim();

                    //计算分类
                    classJson.Add(new ClassJson() { ClassA = panel.ClassAname, ClassB = panel.comboBox1.Text.Trim() });
                    //存盘子类
                    saveClassB(panel.ClassAname, panel.comboBox1.Text.Trim());
                }
            }
            if (errSubClass == "") errMsg += "请至少选择一个子分类！\r\n";

            //准备存盘
            if (string.IsNullOrEmpty(errMsg))
            {
                //2.保存信息到数据库


                int id = Convert.ToInt32(lbID.Text);
                Models.FileInfoModel info = new BLL.FileInfoModelBLL().GetById(id);

                info.ClassJson = JsonConvert.SerializeObject(classJson);
                info.Memo = tbMemo.Text;
                new BLL.FileInfoModelBLL().Update(info);
                MessageBox.Show("修改成功！");

                //3.刷新gridview
                BindDataWithPage(1, _sqlWhere);
            }
            else
            {
                MessageBox.Show(errMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void saveClassB(string classA, string classB)
        {
            var canInsert = new BLL.ClassBModelBLL().GetByClassName(classA, classB);
            if (canInsert == null)
            {
                Models.ClassBModel info = new ClassBModel()
                {
                    ClassA = classA,
                    ClassB = classB,
                    CreateTime = DateTime.Now
                };
                new BLL.ClassBModelBLL().Add(info);
            }
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            _sqlWhere = "where 1=1";
            if (tbClassNameSearch.Text != "") _sqlWhere += " and classJson like '%" + tbClassNameSearch.Text + "%'";
            if (tbMemoSearch.Text != "") _sqlWhere += " and memo like '%" + tbMemoSearch.Text + "%'";
            BindDataWithPage(1, _sqlWhere);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _sqlWhere = "";
            tbClassNameSearch.Text = "";
            tbMemoSearch.Text = "";
            BindDataWithPage(1, _sqlWhere);
        }
    }
}
