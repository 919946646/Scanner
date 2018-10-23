using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ieeve.com.Controls
{
    public partial class MainClassPanel : Panel
    {
        [Description("主类名")]
        private string classAname;
        public string ClassAname
        {
            get
            {
                return classAname;
            }
            set
            {
                classAname = value;
                groupBox1.Text = value;
            }
        }

        [Description("BorderColor")]
        public Color BorderColor { set; get; } = Color.LightSalmon;

        [Description("BorderWidth")]
        public int BorderWidth { set; get; } = 0;

        public ButtonBorderStyle BorderLineStyle = ButtonBorderStyle.Solid;
        public MainClassPanel()
        {
            InitializeComponent();
           
            //双缓冲
            SetStyle
           (
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.SupportsTransparentBackColor |
               ControlStyles.CacheText,
               true
           );
            UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (BorderColor != null)
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                    BorderColor, BorderWidth, BorderLineStyle,
                    BorderColor, BorderWidth, BorderLineStyle,
                    BorderColor, BorderWidth, BorderLineStyle,
                    BorderColor, BorderWidth, BorderLineStyle);
        }
    }
}
