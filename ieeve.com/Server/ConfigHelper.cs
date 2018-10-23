using System;
using System.Collections.Generic;
using System.Text;

namespace ieeve.com.Server
{
    public class ConfigHelper
    {
        //系统配置文件JSON格式
        private const string ConfFilePath = @"Config/App.conf";
        //系统默认数据库文件
        public static readonly string DefaultDataFile = Environment.CurrentDirectory + @"\Data\ieeve.com.db";
        //系统Temp文件存放位置
        public static readonly string TempPath = Environment.CurrentDirectory + @"\temp\";
        //系统上传文件存放位置
        public static readonly string UpLoadPath = Environment.CurrentDirectory + @"\upLoad\";
        //空的原始数据库文件
        public static readonly string NullDataFile = Environment.CurrentDirectory + @"\Default\DataNull";
    }
}
