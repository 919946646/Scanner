namespace ieeve.com
{
    partial class Pic_show
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
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪裁图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageBox1 = new Cyotek.Windows.Forms.ImageBox();
            this.contextMenuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存为ToolStripMenuItem,
            this.剪裁图片ToolStripMenuItem,
            this.撤销ToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(113, 70);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 剪裁图片ToolStripMenuItem
            // 
            this.剪裁图片ToolStripMenuItem.Name = "剪裁图片ToolStripMenuItem";
            this.剪裁图片ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.剪裁图片ToolStripMenuItem.Text = "剪裁";
            this.剪裁图片ToolStripMenuItem.Click += new System.EventHandler(this.剪裁图片ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 32);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "* 滚轮放大缩小图片；鼠标左键圈选范围；";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(78, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "剪裁";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.剪裁图片ToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(147, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "撤销";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "另存为";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zoomInToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zoomOutToolStripButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            // 
            // imageBox1
            // 
            this.imageBox1.AutoSize = false;
            this.imageBox1.ContextMenuStrip = this.contextMenuStripMain;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 32);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1067, 640);
            this.imageBox1.TabIndex = 36;
            // 
            // Pic_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 672);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Pic_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pic_show";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pic_show_FormClosing);
            this.Load += new System.EventHandler(this.Pic_show_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Cyotek.Windows.Forms.ImageBox imageBox1;
        private System.Windows.Forms.ToolStripMenuItem 剪裁图片ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}