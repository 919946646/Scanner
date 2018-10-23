namespace ieeve.com
{
    partial class fileManage
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
            this.components = new System.ComponentModel.Container();
            this.button_login = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panelRoomList = new System.Windows.Forms.Panel();
            this.panelSave = new System.Windows.Forms.Panel();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbMemoSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel52 = new System.Windows.Forms.Panel();
            this.tbClassNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.allenPage1 = new ieeve.com.Controls.AllenPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripMain.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panelRoomList.SuspendLayout();
            this.panelSave.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(411, 3);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(98, 28);
            this.button_login.TabIndex = 36;
            this.button_login.Text = "搜 索";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(57, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "* 双击图片放大";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(118, 59);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 28);
            this.btnDel.TabIndex = 62;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStripMain;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存为ToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(113, 26);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.panelRoomList);
            this.panel51.Controls.Add(this.panel3);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel51.Location = new System.Drawing.Point(685, 0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(220, 588);
            this.panel51.TabIndex = 7;
            // 
            // panelRoomList
            // 
            this.panelRoomList.AutoScroll = true;
            this.panelRoomList.AutoSize = true;
            this.panelRoomList.Controls.Add(this.panelSave);
            this.panelRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoomList.Location = new System.Drawing.Point(0, 179);
            this.panelRoomList.Name = "panelRoomList";
            this.panelRoomList.Size = new System.Drawing.Size(220, 409);
            this.panelRoomList.TabIndex = 65;
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.btnDel);
            this.panelSave.Controls.Add(this.tbMemo);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Controls.Add(this.label8);
            this.panelSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSave.Location = new System.Drawing.Point(0, 0);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(220, 93);
            this.panelSave.TabIndex = 44;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(47, 10);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMemo.Size = new System.Drawing.Size(132, 39);
            this.tbMemo.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "修改";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "备注：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 179);
            this.panel3.TabIndex = 64;
            // 
            // tbMemoSearch
            // 
            this.tbMemoSearch.Location = new System.Drawing.Point(259, 7);
            this.tbMemoSearch.Name = "tbMemoSearch";
            this.tbMemoSearch.Size = new System.Drawing.Size(128, 21);
            this.tbMemoSearch.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "说明：";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.allenPage1);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel52.Location = new System.Drawing.Point(0, 547);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(685, 41);
            this.panel52.TabIndex = 8;
            // 
            // tbClassNameSearch
            // 
            this.tbClassNameSearch.Location = new System.Drawing.Point(59, 7);
            this.tbClassNameSearch.Name = "tbClassNameSearch";
            this.tbClassNameSearch.Size = new System.Drawing.Size(128, 21);
            this.tbClassNameSearch.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "类别：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.button_login);
            this.panel2.Controls.Add(this.tbClassNameSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbMemoSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 38);
            this.panel2.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(540, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 66;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "清除搜索";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 509);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(685, 509);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(627, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 12);
            this.lbID.TabIndex = 68;
            this.lbID.Text = "lbID";
            this.lbID.Visible = false;
            // 
            // allenPage1
            // 
            this.allenPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allenPage1.BtnTextNext = "下页";
            this.allenPage1.BtnTextPrevious = "上页";
            this.allenPage1.Dock = System.Windows.Forms.DockStyle.Top;
            this.allenPage1.Location = new System.Drawing.Point(0, 0);
            this.allenPage1.Name = "allenPage1";
            this.allenPage1.PageSize = 100;
            this.allenPage1.RecordCount = 0;
            this.allenPage1.Size = new System.Drawing.Size(685, 39);
            this.allenPage1.TabIndex = 13;
            // 
            // fileManage
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel52);
            this.Controls.Add(this.panel51);
            this.Name = "fileManage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理";
            this.Load += new System.EventHandler(this.fileManage_Load);
            this.Shown += new System.EventHandler(this.fileManage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripMain.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel51.PerformLayout();
            this.panelRoomList.ResumeLayout(false);
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel52.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.TextBox tbMemoSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClassNameSearch;
        private System.Windows.Forms.Label label1;
        private Controls.AllenPage allenPage1;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelRoomList;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbID;
    }
}