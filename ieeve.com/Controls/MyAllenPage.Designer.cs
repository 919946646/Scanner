namespace ieeve.com.Controls
{
    partial class AllenPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllenPage));
            this.btnToPageIndex = new System.Windows.Forms.Button();
            this.lbEnd = new System.Windows.Forms.Label();
            this.txtToPageIndex = new System.Windows.Forms.TextBox();
            this.lbPre = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblPager = new System.Windows.Forms.Label();
            this.imglstPager = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnToPageIndex
            // 
            this.btnToPageIndex.Location = new System.Drawing.Point(622, 8);
            this.btnToPageIndex.Name = "btnToPageIndex";
            this.btnToPageIndex.Size = new System.Drawing.Size(44, 25);
            this.btnToPageIndex.TabIndex = 17;
            this.btnToPageIndex.Text = "跳转";
            this.btnToPageIndex.UseVisualStyleBackColor = true;
            this.btnToPageIndex.Click += new System.EventHandler(this.btnToPageIndex_Click);
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(599, 14);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(19, 13);
            this.lbEnd.TabIndex = 16;
            this.lbEnd.Text = "页";
            // 
            // txtToPageIndex
            // 
            this.txtToPageIndex.Location = new System.Drawing.Point(538, 9);
            this.txtToPageIndex.Name = "txtToPageIndex";
            this.txtToPageIndex.Size = new System.Drawing.Size(58, 20);
            this.txtToPageIndex.TabIndex = 15;
            this.txtToPageIndex.Text = "1";
            this.txtToPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToPageIndex_KeyPress);
            // 
            // lbPre
            // 
            this.lbPre.AutoSize = true;
            this.lbPre.Location = new System.Drawing.Point(515, 14);
            this.lbPre.Name = "lbPre";
            this.lbPre.Size = new System.Drawing.Size(19, 13);
            this.lbPre.TabIndex = 14;
            this.lbPre.Text = "第";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(455, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(53, 25);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "末页";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(397, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 25);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(339, 6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 25);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "上一页";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(281, 6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(53, 25);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPager
            // 
            this.lblPager.AutoSize = true;
            this.lblPager.Location = new System.Drawing.Point(3, 13);
            this.lblPager.Name = "lblPager";
            this.lblPager.Size = new System.Drawing.Size(264, 13);
            this.lblPager.TabIndex = 9;
            this.lblPager.Text = "总共{0}条记录,当前第{1}页,共{2}页,每页{3}条记录";
            // 
            // imglstPager
            // 
            this.imglstPager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstPager.ImageStream")));
            this.imglstPager.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstPager.Images.SetKeyName(0, "first.gif");
            this.imglstPager.Images.SetKeyName(1, "prev.gif");
            this.imglstPager.Images.SetKeyName(2, "next.gif");
            this.imglstPager.Images.SetKeyName(3, "last.gif");
            // 
            // AllenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToPageIndex);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.txtToPageIndex);
            this.Controls.Add(this.lbPre);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblPager);
            this.Name = "AllenPage";
            this.Size = new System.Drawing.Size(671, 41);
            this.Load += new System.EventHandler(this.AllenPage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AllenPage_Paint);
            this.MouseHover += new System.EventHandler(this.AllenPage_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToPageIndex;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.TextBox txtToPageIndex;
        private System.Windows.Forms.Label lbPre;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPager;
        private System.Windows.Forms.ImageList imglstPager;
    }
}
