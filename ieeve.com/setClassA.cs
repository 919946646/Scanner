using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ieeve.com
{
    public partial class setClassA : Form
    {
        public setClassA()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void setClassA_Shown(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            dataGridView1.DataSource = new BLL.ClassAModelBLL().GetAll();
            //设置列名
            dataGridView1.Columns[0].HeaderText = "主类名称";
            dataGridView1.Columns[1].HeaderText = "类别说明";
            dataGridView1.Columns[2].HeaderText = "建立时间";
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
            if (tbClassNameAdd.Text == "")
            {
                errMsg += "类别名不能为空！\r\n";
            }

            if (errMsg != "")
            {
                MessageBox.Show(errMsg);
                return;
            }

            var canInsert = new BLL.ClassAModelBLL().GetByClassName(tbClassNameAdd.Text);
            if (canInsert != null)
            {
                MessageBox.Show("不能添加重复的类别名称！");
                return;
            }

            var info = new Models.ClassAModel
            {
                ClassName = tbClassNameAdd.Text,
                ClassNote = tbClassNoteAdd.Text,
                CreateTime = DateTime.Now
            };
            int result = new BLL.ClassAModelBLL().Add(info);
            if (result > 0)
            {
                MessageBox.Show("添加成功");
                BindData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var info = new Models.ClassAModel
            {
                ClassName = tbClassNameEdit.Text,
                ClassNote = tbClassNoteEdit.Text,
                CreateTime = DateTime.Now
            };
            int result = new BLL.ClassAModelBLL().Update(info);
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
                tbClassNameEdit.Text = dv.CurrentRow.Cells[0].Value.ToString();
                tbClassNoteEdit.Text = dv.CurrentRow.Cells[1].Value.ToString();
                lbDelSelect.Text = "当前选中的类别名称是：" + tbClassNameEdit.Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("确认要删除所选内容吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var r = new BLL.ClassAModelBLL().DeleteByClassName(tbClassNameEdit.Text);
                if (r > 0)
                {
                    MessageBox.Show("删除成功！");
                    BindData();
                }
            }
        }

        private void setClassA_FormClosing(object sender, FormClosingEventArgs e)
        {
            //无论添加，删除，修改都更新
            this.DialogResult = DialogResult.OK;
        }
    }
}
