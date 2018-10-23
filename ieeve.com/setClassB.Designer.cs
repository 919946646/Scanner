namespace ieeve.com
{
    partial class setClassB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbAddClassA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.tbClassNameAdd = new System.Windows.Forms.TextBox();
            this.lbnotes = new System.Windows.Forms.Label();
            this.tbClassNoteAdd = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClassNameEdit = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbEditClassA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClassNoteEdit = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDelSelect = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(532, 306);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "说明：";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbAddClassA);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lbtitle);
            this.tabPage1.Controls.Add(this.tbClassNameAdd);
            this.tabPage1.Controls.Add(this.lbnotes);
            this.tabPage1.Controls.Add(this.tbClassNoteAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbAddClassA
            // 
            this.cbAddClassA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddClassA.FormattingEnabled = true;
            this.cbAddClassA.Location = new System.Drawing.Point(68, 22);
            this.cbAddClassA.Name = "cbAddClassA";
            this.cbAddClassA.Size = new System.Drawing.Size(147, 20);
            this.cbAddClassA.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "主类名：";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(68, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "确 定";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Location = new System.Drawing.Point(9, 55);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(53, 12);
            this.lbtitle.TabIndex = 8;
            this.lbtitle.Text = "子类名：";
            // 
            // tbClassNameAdd
            // 
            this.tbClassNameAdd.Location = new System.Drawing.Point(68, 51);
            this.tbClassNameAdd.Name = "tbClassNameAdd";
            this.tbClassNameAdd.Size = new System.Drawing.Size(147, 21);
            this.tbClassNameAdd.TabIndex = 9;
            // 
            // lbnotes
            // 
            this.lbnotes.AutoSize = true;
            this.lbnotes.Location = new System.Drawing.Point(228, 25);
            this.lbnotes.Name = "lbnotes";
            this.lbnotes.Size = new System.Drawing.Size(41, 12);
            this.lbnotes.TabIndex = 10;
            this.lbnotes.Text = "说明：";
            // 
            // tbClassNoteAdd
            // 
            this.tbClassNoteAdd.Location = new System.Drawing.Point(275, 19);
            this.tbClassNoteAdd.Multiline = true;
            this.tbClassNoteAdd.Name = "tbClassNoteAdd";
            this.tbClassNoteAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClassNoteAdd.Size = new System.Drawing.Size(198, 54);
            this.tbClassNoteAdd.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(62, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "确 定";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "子类名：";
            // 
            // tbClassNameEdit
            // 
            this.tbClassNameEdit.Enabled = false;
            this.tbClassNameEdit.Location = new System.Drawing.Point(67, 51);
            this.tbClassNameEdit.Name = "tbClassNameEdit";
            this.tbClassNameEdit.Size = new System.Drawing.Size(147, 21);
            this.tbClassNameEdit.TabIndex = 44;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(66, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 306);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 144);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbEditClassA);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbClassNameEdit);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbClassNoteEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbEditClassA
            // 
            this.cbEditClassA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditClassA.FormattingEnabled = true;
            this.cbEditClassA.Location = new System.Drawing.Point(67, 21);
            this.cbEditClassA.Name = "cbEditClassA";
            this.cbEditClassA.Size = new System.Drawing.Size(147, 20);
            this.cbEditClassA.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "主类名：";
            // 
            // tbClassNoteEdit
            // 
            this.tbClassNoteEdit.Location = new System.Drawing.Point(286, 21);
            this.tbClassNoteEdit.Multiline = true;
            this.tbClassNoteEdit.Name = "tbClassNoteEdit";
            this.tbClassNoteEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClassNoteEdit.Size = new System.Drawing.Size(207, 68);
            this.tbClassNoteEdit.TabIndex = 46;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbID);
            this.tabPage3.Controls.Add(this.lbDelSelect);
            this.tabPage3.Controls.Add(this.btnDel);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(524, 114);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "删除";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(180, 77);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 12);
            this.lbID.TabIndex = 55;
            this.lbID.Text = "lbID";
            this.lbID.Visible = false;
            // 
            // lbDelSelect
            // 
            this.lbDelSelect.AutoSize = true;
            this.lbDelSelect.Location = new System.Drawing.Point(97, 32);
            this.lbDelSelect.Name = "lbDelSelect";
            this.lbDelSelect.Size = new System.Drawing.Size(137, 12);
            this.lbDelSelect.TabIndex = 54;
            this.lbDelSelect.Text = "请先选择要删除的记录。";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(99, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 31);
            this.btnDel.TabIndex = 52;
            this.btnDel.Text = "确 定";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // setClassB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "setClassB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改类别";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setClassB_FormClosing);
            this.Shown += new System.EventHandler(this.setClassA_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbAddClassA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.TextBox tbClassNameAdd;
        private System.Windows.Forms.Label lbnotes;
        private System.Windows.Forms.TextBox tbClassNoteAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClassNameEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbClassNoteEdit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbDelSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cbEditClassA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbID;
    }
}