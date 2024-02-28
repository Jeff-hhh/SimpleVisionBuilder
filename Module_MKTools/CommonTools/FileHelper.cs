using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

/// <summary>
/// 个人工具封装
/// </summary>
namespace Module_MKTools
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    public class FileHelper
    {
        #region [文件夹复制]

        /// <summary>
        /// 复制整个文件夹
        /// </summary>
        /// <param name="sourceDir">源文件名称</param>
        /// <param name="toDir">复制后的新文件名称</param>
        public static void CopyDirectInfo(string sourceDir, string toDir)
        {
            if (!Directory.Exists(sourceDir))
            {
                throw new ApplicationException("Source directory does not exist");
            }
            if (!Directory.Exists(toDir))
            {
                Directory.CreateDirectory(toDir);
            }
            DirectoryInfo directInfo = new DirectoryInfo(sourceDir);

            //复制路径
            FileInfo[] filesInfos = directInfo.GetFiles();
            foreach (FileInfo fileinfo in filesInfos)
            {
                string fileName = fileinfo.Name;
                File.Copy(fileinfo.FullName, toDir + @"/" + fileName, true);
            }

            //复制文件
            foreach (DirectoryInfo directoryPath in directInfo.GetDirectories())
            {
                string toDirPath = toDir + @"/" + directoryPath.Name;
                CopyDirectInfo(directoryPath.FullName, toDirPath);
            }
        }

        #endregion


        #region [文件夹重命名]

        /// <summary>
        /// 文件夹重命名
        /// </summary>
        /// <param name="sourceDir"></param>
        /// <param name="newDir"></param>
        public static void RenameDirectInfo(string sourceDir, string newDir)
        {
            try
            {
                Directory.Move(sourceDir, newDir);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        #endregion


        #region [过期文件删除]

        /// <summary>
        /// 删除过期文件
        /// </summary>
        /// <param name="path">文件所在路径</param>
        /// <param name="overdueTime">保存时间</param>
        public static void DeletaOverdueFile(object o)
        {
            try
            {
                object[] imageInfo = (object[])o;
                string path = (string)imageInfo[0];
                int overdueTime = (int)imageInfo[1];

                if (System.IO.Directory.Exists(path))
                {
                    DirectoryInfo pathinfo = new DirectoryInfo(path);

                    foreach (DirectoryInfo paths in pathinfo.GetDirectories())
                    {
                        DateTime nowtime = DateTime.Now;
                        TimeSpan t = nowtime - paths.CreationTime;  //当前时间减文件创建时间
                        int day = t.Days;
                        if (day >= overdueTime)   //保存的时间单位天
                        {
                            paths.Delete(true);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion


        #region [根据文件后缀关闭文件]

        /// <summary>
        /// 根据文件后缀关闭该文件
        /// </summary>
        /// <param name="fileSuffix">带文件后缀的路径（文件名或完整路径）</param>
        public static void CloseUsedFile(string fileSuffix)
        {
            try
            {
                string type = string.Empty; //文档后缀
                string ProcessName = string.Empty; //进程名
                int index1 = fileSuffix.LastIndexOf(".");
                type = fileSuffix.Substring(index1 + 1, fileSuffix.Length - index1 - 1);
                switch (type.ToUpper())
                {
                    case "CSV":
                    case "XLS":
                        ProcessName = "wps";
                        break;
                    case "TXT":
                        ProcessName = "notepad";
                        break;
                    default:
                        break;
                }
                foreach (Process process in System.Diagnostics.Process.GetProcesses())
                {
                    if (process.ProcessName.Equals(ProcessName))
                    {
                        process.Kill();
                    }
                }
                GC.Collect();
            }
            catch (Exception)
            {
            }
        }

        #endregion
    }
}
