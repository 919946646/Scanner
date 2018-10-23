using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ieeve.com
{

    public partial class Pic_show : Form
    {
        private string imageUrl;
        public Pic_show(string imageUrl)
        {
            this.imageUrl = imageUrl;
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pic_show_Load(object sender, EventArgs e)
        {
            imageBox1.Image = Image.FromFile(imageUrl);
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            //imageBox1.SelectionRegion = new Rectangle(5, 5, 32, 32);
        }


        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pictureName = saveFileDialog1.FileName;
                if (imageBox1.Image != null)
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        Bitmap bmp = new Bitmap(imageBox1.Image);
                        //保存到内存
                        //bmp.Save(mem, pictureBox1.Image.RawFormat );
                        //保存到磁盘文件
                        bmp.Save(@pictureName, imageBox1.Image.RawFormat);
                        bmp.Dispose();
                    }
                }
            }
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox1.ZoomIn();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            imageBox1.ZoomOut();
        }

        private Bitmap _previewImage;
        private void 剪裁图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox1.SelectionRegion.IsEmpty)
            {
                MessageBox.Show("请用鼠标圈选某个剪裁范围。");
                return;
            }
            _previewImage = null;

            if (imageBox1.LimitSelectionToImage && !imageBox1.SelectionRegion.IsEmpty)
            {
                Rectangle rect;

                if (_previewImage != null)
                    _previewImage.Dispose();

                rect = new Rectangle((int)imageBox1.SelectionRegion.X, (int)imageBox1.SelectionRegion.Y, (int)imageBox1.SelectionRegion.Width, (int)imageBox1.SelectionRegion.Height);

                _previewImage = new Bitmap(rect.Width, rect.Height);

                using (Graphics g = Graphics.FromImage(_previewImage))
                    g.DrawImage(imageBox1.Image, new Rectangle(Point.Empty, rect.Size), rect, GraphicsUnit.Pixel);
            }

            imageBox1.Image = _previewImage;
            imageBox1.SelectNone();
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.None;
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = Image.FromFile(imageUrl);
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
        }

        private void 存盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
            {
                MessageBox.Show("图片未作剪裁，无需保存！");
                return;
            }

            DialogResult result = MessageBox.Show("确认要替换原有文件吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string pictureName = imageUrl;
                if (imageBox1.Image != null)
                {
                    using (MemoryStream mem = new MemoryStream())
                    {

                        Bitmap bmp = new Bitmap(imageBox1.Image);
                        //保存到内存
                        //bmp.Save(mem, pictureBox1.Image.RawFormat );
                        //保存到磁盘文件
                        File.Delete(pictureName);
                        bmp.Save(@pictureName, imageBox1.Image.RawFormat);
                        bmp.Dispose();
                    }
                }
            }
        }

        private void Pic_show_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (_previewImage != null)
            //{
            //    DialogResult result = MessageBox.Show("剪裁后的图片未保存，确认要退出运行吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (result == DialogResult.OK)
            //    {
            //        _previewImage.Dispose();

            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }
    }
}
