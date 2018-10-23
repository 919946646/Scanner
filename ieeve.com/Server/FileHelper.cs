using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ieeve.com.Server
{
   public class FileHelper
    {
        public static void ClearDirAllFile(string path,int days)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                    foreach (FileSystemInfo i in fileinfo)
                    {
                        if (i is DirectoryInfo)            //判断是否文件夹
                        {
                            DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                            subdir.Delete(true);          //删除子目录和文件
                        }
                        else
                        {
                            if(i.CreationTime<DateTime.Now.AddDays(-days))
                            File.Delete(i.FullName);      //删除指定文件
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
