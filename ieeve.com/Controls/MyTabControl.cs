using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace ieeve.com.Controls
{
    public partial class MyTabControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // 隐藏TAB
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
}
