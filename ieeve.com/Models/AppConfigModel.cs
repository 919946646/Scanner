using System;
using System.Collections.Generic;
using System.Text;

namespace ieeve.com.Models
{
   public class AppConfigModel
    {
        public int SetId   //设备编号
        {
            get;
            set;
        }
        public string SetName   //设备名称
        {
            get;
            set;
        }
        public int Protocol   //传输协议
        {
            get;
            set;
        }
        public bool IsAutoRun   //是否自动开启服务
        {
            get;
            set;
        }
        public bool UseChannelB   //是否启用通道B ,通道A必须启用
        {
            get;
            set;
        }
        public bool UseChannelC   //是否启用通道C
        {
            get;
            set;
        }
        public bool UseChannelD   //是否启用通道D
        {
            get;
            set;
        }
        public int Addr   //设备地址
        {
            get;
            set;
        }

        public int BaseDis
        {
            get;
            set;
        }
        public int EndDis   //最大可测量距离
        {
            get;
            set;
        }

        public int StartDis //最近测量距离
        {
            get;
            set;
        }
        public int MaxSafeDis   //最大安全距离
        {
            get;
            set;
        }

        public int MinSafeDis //最小安全距离
        {
            get;
            set;
        }
    }
}
