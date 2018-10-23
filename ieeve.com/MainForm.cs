using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIA;
using System.IO;
using ieeve.com.Models;
using System.Threading;
using ieeve.com.Server;
using Newtonsoft.Json;

namespace ieeve.com
{
    public partial class MainForm : Form
    {
      //  public static AppConfigModel AppConfig;
        private static string _picBoxTempfile;
        private Bitmap _previewImage;//剪裁后的图片
        public MainForm()
        {
            InitializeComponent();
        }

        private void TabTopBtn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int clickId = Convert.ToInt16(b.Tag);
            MainTabControl.SelectedIndex = clickId;
            ChangeFlowLayoutPanelItem(clickId, flowLayoutPanel1);
        }
        private void ChangeFlowLayoutPanelItem(int ClickId, Panel panel)
        {
            foreach (Button item in panel.Controls)
            {
                if (ClickId == Convert.ToInt16(item.Tag))
                {
                    item.BackColor = Color.White;
                    item.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                }
                else
                {
                    item.BackColor = Color.Transparent;
                    item.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //初始化图片盒
            this.imageBox1.AllowDrop = true;
            imageBox1.DragEnter += PictureBox1_DragEnter;
            imageBox1.DragDrop += PictureBox1_DragDrop;
            // imageBox1.Image = Image.FromFile(imageUrl);
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;

            //初始化扫描仪
            ListScanners();
            //清理临时文件
            FileHelper.ClearDirAllFile(ConfigHelper.TempPath, 1); //删除大于一天前的文件

            //listView
            //显示摄图列表
            listViewCamera.LargeImageList = imageListCamera;
            imageListCamera.ImageSize = new System.Drawing.Size(128, 96);
            imageListCamera.ColorDepth = ColorDepth.Depth32Bit;
            bindListView(listViewCamera, imageListCamera, ConfigHelper.TempPath);
            listViewCamera.DoubleClick += listDouble;
            //初始化数据库
            InitData();
            //初始化comboBox
            // InitComboBox();
            InitSelectClass();
        }
        private void InitSelectClass()
        {
            var classAlist = new BLL.ClassAModelBLL().GetAll();
            List<Models.ClassBModel> classBlist = new BLL.ClassBModelBLL().GetAll();

            List<Controls.MainClassPanel> FloorList = new List<Controls.MainClassPanel>();

            foreach (var classA in classAlist) //循环主类
            {
                List<Models.ClassBModel> ClassBList = classBlist.FindAll(s => s.ClassA == classA.ClassName); //选择某一子类
                List<RadioButton> roomControl = new List<RadioButton>();

                var floorPanel = new Controls.MainClassPanel { ClassAname = classA.ClassName, Dock = DockStyle.Top, AutoSize = true };
                floorPanel.comboBox1.DataSource = ClassBList;
                floorPanel.comboBox1.DisplayMember = "classB";
                floorPanel.comboBox1.ValueMember = "classB";
                FloorList.Add(floorPanel);
            }

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate { panelRoomList.Controls.AddRange(FloorList.ToArray()); }));
            }
            else
            {
                panelRoomList.Controls.AddRange(FloorList.ToArray());
            }
        }

        private void InitData()
        {
            // 判断数据库文件是否存在
            if (!System.IO.File.Exists(ConfigHelper.DefaultDataFile))
            {
                System.IO.File.Copy(ConfigHelper.NullDataFile, ConfigHelper.DefaultDataFile, true);//允许覆盖目的地的同名文件
            }
            //初始化与数据库相关的UI
            this.BeginInvoke(new MethodInvoker(delegate ()
            {

            }));
        }

        private void bindListView(ListView listview, ImageList images, string DirPath)
        {
            listview.Items.Clear();
            images.Images.Clear();
            List<string> imageLists = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(DirPath);

            string ext = "";

            foreach (FileInfo d in dir.GetFiles())
            {
                ext = System.IO.Path.GetExtension(DirPath + d.Name);
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
                {
                    imageLists.Add(DirPath + d.Name);
                }
            }

            //todo，待优化效率
            for (int i = 0; i < imageLists.Count; i++)
            {
                images.Images.Add(System.Drawing.Image.FromFile(imageLists[i].ToString()));
                listview.Items.Add(System.IO.Path.GetFileName(imageLists[i].ToString()), i);
                listview.Items[i].ImageIndex = i;
                listview.Items[i].Name = imageLists[i].ToString();
            }

        }
        private void listDouble(object sender, EventArgs e)
        {
            string imgFile = "";
            ListView lv = sender as ListView;
            int selectCount = lv.SelectedItems.Count;
            if (selectCount > 0)//若selectCount大于0，说明用户有选中某列。
            {
                imgFile = lv.SelectedItems[0].SubItems[0].Name;
            }

            Pic_show fd = new Pic_show(imgFile);
            fd.ShowDialog();
        }

        #region picBox接收拖入图片
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            _picBoxTempfile = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            //imageBox1.Image = Image.FromFile(_picBoxTempfile);
            //临时文件,便于查看最近列表用
            string uploadFile = ConfigHelper.TempPath + Path.GetFileName(_picBoxTempfile);
            if (!File.Exists(uploadFile))
                File.Copy(_picBoxTempfile, uploadFile);
            imageBox1.Image = Image.FromFile(uploadFile);
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
        #endregion
        private void ListScanners()
        {
            listBox1.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // 仅仅加入扫描仪
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            //todo 升级版再提供线程支持
             StartScanning();
            //Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan()); //.net4.0
            //Thread TabPageThread = new Thread(new ThreadStart(StartScanning));
            //TabPageThread.Start();
        }

        public void StartScanning()
        {

            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("您没有可使用的扫描设备",
                                "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("请先选择需要使用的扫描仪", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            image = device.ScanJPEG();
            string imageExtension = ".jpeg";
            // save file
            _picBoxTempfile = Server.ConfigHelper.TempPath + DateTime.Now.ToString("yyyyMMddHHmmss") + imageExtension;
            image.SaveFile(_picBoxTempfile);
            imageBox1.Image = new Bitmap(_picBoxTempfile);
            imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMsg = string.Empty;
            if (imageBox1.Image == null) errMsg += "请扫描或上传图片！\r\n";


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

            if (string.IsNullOrEmpty(_picBoxTempfile)) errMsg += "请扫描或上传一个图片文件！\r\n";
            //准备存盘
            if (string.IsNullOrEmpty(errMsg) && !string.IsNullOrEmpty(_picBoxTempfile))
            {
                string uploadFile = DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";

                //1. 复制图片
                if (_previewImage == null)
                {
                    File.Copy(_picBoxTempfile, ConfigHelper.UpLoadPath + uploadFile);
                }
                else
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        Bitmap bmp = new Bitmap(imageBox1.Image);
                        bmp.Save(ConfigHelper.UpLoadPath + uploadFile, imageBox1.Image.RawFormat);
                        bmp.Dispose();
                    }
                }
                //2.保存信息到数据库
                SaveData(uploadFile, JsonConvert.SerializeObject(classJson));

                //3.清空picbox
                imageBox1.Image = global::ieeve.com.Properties.Resources.bg;
                bindListView(listViewCamera, imageListCamera, ConfigHelper.TempPath);
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

        private void SaveData(string uploadFile, string classJson)
        {
            Models.FileInfoModel info = new FileInfoModel();
            info.ClassJson = classJson;
            info.CreateTime = DateTime.Now;
            info.FileUrl = uploadFile;
            info.Memo = tbMemo.Text;
            new BLL.FileInfoModelBLL().Add(info);
            MessageBox.Show("文件上传成功");
        }

        #region 系统菜单
        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSetting fd = new AppSetting();
            fd.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _previewImage.Dispose();

        }

        private void 主类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setClassA fd = new setClassA();
            if (fd.ShowDialog() == DialogResult.OK)
            {

                panelRoomList.Controls.Clear();
                panelRoomList.Controls.Add(panelSave);
                InitSelectClass();
            }
        }

        private void 子类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setClassB fd = new setClassB();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                panelRoomList.Controls.Clear();
                panelRoomList.Controls.Add(panelSave);
                InitSelectClass();

            }
        }

        private void 文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManage fd = new fileManage();
            fd.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox fd = new AboutBox();
            fd.ShowDialog();
        }
        #endregion

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _picBoxTempfile = openFileDialog1.FileName;

                //临时文件,便于查看最近列表用
                string uploadFile = ConfigHelper.TempPath + Path.GetFileName(_picBoxTempfile);
                if (!File.Exists(uploadFile))
                    File.Copy(_picBoxTempfile, uploadFile);
                imageBox1.Image = Image.FromFile(uploadFile);
                imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            }
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
            if (_picBoxTempfile != null)
            {
                imageBox1.Image = Image.FromFile(_picBoxTempfile);
                imageBox1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            }
        }
    }
}
