using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ieeve.com.Models;

namespace ieeve.com
{
    public partial class setClassB : Form
    {
        public setClassB()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void setClassA_Shown(object sender, EventArgs e)
        {
            BindData();

            var classAlist = new BLL.ClassAModelBLL().GetAll();
            cbEditClassA.DataSource = classAlist;
            classAlist.Insert(0, new ClassAModel()); //插入空白行

            cbEditClassA.DisplayMember = "ClassName";
            cbEditClassA.ValueMember = "ClassName";

            cbAddClassA.DataSource = classAlist;
            cbAddClassA.DisplayMember = "ClassName";
            cbAddClassA.ValueMember = "ClassName";

        }

        private void BindData()
        {
            dataGridView1.DataSource = new BLL.ClassBModelBLL().GetAll();
            //设置列名
            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "主类";
            dataGridView1.Columns[2].HeaderText = "子类名称";
            dataGridView1.Columns[3].HeaderText = "类别说明";
            dataGridView1.Columns[4].HeaderText = "建立时间";
            //设置时间格式
            var dataGridViewColumn = dataGridView1.Columns["CreateTime"];
            if (dataGridViewColumn != null)
            {
                dataGridViewColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dataGridViewColumn.FillWeight = 200;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (cbAddClassA.SelectedValue == null)
            {
                errMsg += "请选择一个主分类！\r\n";
            }

            if (tbClassNameAdd.Text == "")
            {
                errMsg += "子类名称不能为空！\r\n";
            }

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            var canInsert = new BLL.ClassBModelBLL().GetByClassName(cbAddClassA.SelectedValue.ToString(),tbClassNameAdd.Text);
            if (canInsert != null)
            {
                MessageBox.Show("不能添加重复的类别名称！");
                return;
            }

            var info = new Models.ClassBModel
            {
                ClassA = cbAddClassA.SelectedValue.ToString(),
                ClassB = tbClassNameAdd.Text,
                ClassNote = tbClassNoteAdd.Text,
                CreateTime = DateTime.Now
            };
            int result = new BLL.ClassBModelBLL().Add(info);
            if (result > 0)
            {
                MessageBox.Show("添加成功");
                BindData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (cbEditClassA.SelectedValue == null)
            {
                errMsg += "请选择一个主分类！\r\n";
            }

            if (tbClassNameEdit.Text == "")
            {
                errMsg += "子类名称不能为空！\r\n";
            }

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            var info = new Models.ClassBModel
            {
                Id = Convert.ToInt32(lbID.Text),
                ClassA = cbEditClassA.SelectedValue.ToString(),
                ClassB = tbClassNameEdit.Text,
                ClassNote = tbClassNoteEdit.Text,
                CreateTime = DateTime.Now
            };
            int result = new BLL.ClassBModelBLL().Update(info);
            if (result > 0)
            {
                MessageBox.Show("更新成功！");
                BindData();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridView dv = sender as DataGridView;
            if (dv != null && dv.CurrentRow != null)
            {
                tbClassNameEdit.Text = dv.CurrentRow.Cells["classB"].Value.ToString();
              if(dv.CurrentRow.Cells["classNote"].Value!=null) tbClassNoteEdit.Text = dv.CurrentRow.Cells["classNote"].Value.ToString();
                lbDelSelect.Text = "当前选中的类别名称是：" + tbClassNameEdit.Text;
                cbEditClassA.SelectedValue = dv.CurrentRow.Cells["classA"].Value.ToString();
                lbID.Text= dv.CurrentRow.Cells["id"].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要删除所选内容吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var r = new BLL.ClassBModelBLL().DeleteById(Convert.ToInt16(lbID.Text));
                if (r > 0)
                {
                    MessageBox.Show("删除成功！");
                    BindData();
                }
            }
        }

        private void setClassB_FormClosing(object sender, FormClosingEventArgs e)
        {
            //无论添加，删除，修改都更新
            this.DialogResult = DialogResult.OK;
        }
    }
}
