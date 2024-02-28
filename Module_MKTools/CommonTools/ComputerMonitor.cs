using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// 个人工具封装
/// </summary>
namespace Module_MKTools
{
    /// <summary>
    /// 主机状态监控类
    /// </summary>
    public static class ComputerMonitor
    {

        #region [CPU使用率] 

        [DllImport("IpHlpApi.dll")]
        extern static public uint GetIfTable(byte[] pIfTable, ref uint pdwSize, bool bOrder);

        [DllImport("User32")]
        private extern static int GetWindow(int hWnd, int wCmd);

        [DllImport("User32")]
        private extern static int GetWindowLongA(int hWnd, int wIndx);

        [DllImport("user32.dll")]
        private static extern bool GetWindowText(int hWnd, StringBuilder title, int maxBufSize);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static int GetWindowTextLength(IntPtr hWnd);

        /// <summary>
        /// 获取CPU使用率--不准确
        /// </summary>
        /// <returns></returns>
        public static float? GetCpuUsedRate()
        {
            try
            {
                PerformanceCounter pcCpuLoad;
                pcCpuLoad = new PerformanceCounter("Processor", "% Processor Time", "_Total")
                {
                    MachineName = "."
                };
                pcCpuLoad.NextValue();
                Thread.Sleep(1500);
                float CpuLoad = pcCpuLoad.NextValue();

                return CpuLoad;
            }
            catch
            {
            }
            return 0;
        }

        #endregion


        #region [获取内存使用率]


        /// <summary>
        /// 获取可用内存
        /// </summary>
        internal static long? GetMemoryAvailable()
        {

            long availablebytes = 0;
            var managementClassOs = new ManagementClass("Win32_OperatingSystem");
            foreach (var managementBaseObject in managementClassOs.GetInstances())
                if (managementBaseObject["FreePhysicalMemory"] != null)
                    availablebytes = 1024 * long.Parse(managementBaseObject["FreePhysicalMemory"].ToString());
            return availablebytes / MbDiv;
        }


        internal static double? GetMemoryUsed()
        {
            float? PhysicalMemory = GetPhysicalMemory();
            float? MemoryAvailable = GetMemoryAvailable();
            double? MemoryUsed = (double?)(PhysicalMemory - MemoryAvailable);
            double currentMemoryUsed = (double)MemoryUsed;
            return currentMemoryUsed;
        }

        private static long? GetPhysicalMemory()
        {
            //获得物理内存
            var managementClass = new ManagementClass("Win32_ComputerSystem");
            var managementObjectCollection = managementClass.GetInstances();
            long PhysicalMemory;
            foreach (var managementBaseObject in managementObjectCollection)
                if (managementBaseObject["TotalPhysicalMemory"] != null)
                {
                    return long.Parse(managementBaseObject["TotalPhysicalMemory"].ToString()) / MbDiv;
                }
            return null;
        }

        public static double? GetMemoryUsedRate()
        {
            float? PhysicalMemory = GetPhysicalMemory();
            float? MemoryAvailable = GetMemoryAvailable();
            double? MemoryUsedRate = (double?)(PhysicalMemory - MemoryAvailable) / PhysicalMemory;
            return MemoryUsedRate.HasValue ? Convert.ToDouble(MemoryUsedRate * 100) : 0;
        }

        private const int KbDiv = 1024;
        private const int MbDiv = 1024 * 1024;
        private const int GbDiv = 1024 * 1024 * 1024;

        #endregion


        #region [获取磁盘占用率]


        internal static double GetUsedDiskPercent()
        {
            float? usedSize = GetUsedDiskSize();
            float? totalSize = GetTotalSize();
            double? percent = (double?)usedSize / totalSize;
            return percent.HasValue ? Convert.ToDouble(percent * 100) : 0;
        }

        internal static float? GetUsedDiskSize()
        {
            var currentDrive = GetCurrentDrive();
            float UsedDiskSize = (long)currentDrive?.TotalSize - (long)currentDrive?.TotalFreeSpace;
            return UsedDiskSize / MbDiv;
        }

        internal static float? GetTotalSize()
        {
            var currentDrive = GetCurrentDrive();

            float TotalSize = (long)currentDrive?.TotalSize / MbDiv;
            return TotalSize;
        }

        /// <summary>
        /// 获取当前执行的盘符信息
        /// </summary>
        /// <returns></returns>
        private static DriveInfo GetCurrentDrive()
        {
            string path = Application.StartupPath.ToString().Substring(0, 3);
            return DriveInfo.GetDrives().FirstOrDefault<DriveInfo>(p => p.Name.Equals(path));
        }

        #endregion


        #region  [获取当前活动网络MAC地址]

        /// <summary>  
        /// 获取本机MAC地址  
        /// </summary>  
        /// <returns>本机MAC地址</returns>  
        public static string GetMacAddress()
        {
            try
            {
                string strMac = string.Empty;
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        strMac = mo["MacAddress"].ToString();
                    }
                }
                moc = null;
                mc = null;
                return strMac;
            }
            catch
            {
                return "unknown";
            }
        }

        #endregion


        #region [获取磁盘信息]

        /// <summary>
        /// 获取硬盘大小
        /// </summary>
        /// <param name="str_HardDiskName">盘符名称</param>
        /// <returns>硬盘总容量</returns>
        public static long GetHardDiskSpace(string str_HardDiskName)
        {
            long totalSize = new long();
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    totalSize = drive.TotalSize / (1024 * 1024 * 1024);
                }
            }
            return totalSize;
        }

        /// <summary>
        /// 获取硬盘剩余空间
        /// </summary>
        /// <param name="str_HardDiskName">盘符名称</param>
        /// <returns>硬盘剩余空间</returns>
        public static long GetHardDiskFreeSpace(string str_HardDiskName)
        {
            long freeSpace = new long();
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    freeSpace = drive.TotalFreeSpace / (1024 * 1024 * 1024);
                }
            }
            return freeSpace;

        }
        #endregion


        #region [获取电脑已运行时间]

        static readonly PerformanceCounter uptime = new PerformanceCounter("System", "System Up Time");
        /// <summary>
        /// 获取电脑系统已运行时间
        /// </summary>
        /// <returns></returns>
        public static TimeSpan GetSystemUpTime()
        {
            uptime.NextValue();
            TimeSpan ts = TimeSpan.FromHours(uptime.NextValue());
            return ts;
        }

        #endregion
    }
}
