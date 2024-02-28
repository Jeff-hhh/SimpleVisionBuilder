using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// 个人工具封装
/// </summary>
namespace Module_MKTools
{
    /// <summary>
    /// CSV文件类
    /// </summary>
    public static class CSVHelper
    {
        private static object _lock = new object();
        public static void WriteCSV(string datafilepath, string title, string text)
        {
            foreach (Process process in System.Diagnostics.Process.GetProcesses())
            {
                if (process.ProcessName.ToUpper().Equals("xlsx"))
                    process.Kill();
            }

            System.IO.StreamWriter sw = null;
            datafilepath += "\\" + DateTime.Now.ToString("yyyy-MM");
            if (!Directory.Exists(datafilepath))
            {
                Directory.CreateDirectory(datafilepath);
            }
            string fileFullFileName = datafilepath + "\\" + DateTime.Now.ToString("dd") + ".csv";

            if (!File.Exists(fileFullFileName))
            {
                using (sw = System.IO.File.AppendText(fileFullFileName))
                {
                    //标题自定义
                    string str = title;
                    sw.WriteLine(str);
                }
            }

            lock (_lock)
            {
                try
                {
                    using (sw = System.IO.File.AppendText(fileFullFileName))
                    {
                        sw.WriteLine(DateTime.Now.ToString("HH:mm:ss,") + text);
                    }
                }
                catch
                {
                    FileHelper.CloseUsedFile(fileFullFileName);
                }
            }
        }


        public static void ReadCSVToDataGridView(System.Windows.Forms.DataGridView dataGridView, string csvPath)
        {
            try
            {
                string strCon = "provider=microsoft.jet.oledb.4.0;data source=" + csvPath + ";extended properties=excel 8.0";
                OleDbConnection Con = new OleDbConnection(strCon);//建立连接
                string strSql = "select * from [Sheet1$]";//表名的写法也应注意不同，对应的excel表为sheet1，在这里要在其后加美元符号$，并用中括号
                OleDbCommand Cmd = new OleDbCommand(strSql, Con);//建立要执行的命令
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);//建立数据适配器
                DataSet ds = new DataSet();//新建数据集
                da.Fill(ds, "shyman");//把数据适配器中的数据读到数据集中的一个表中（此处表名为shyman，可以任取表名）
                                      //指定datagridview1的数据源为数据集ds的第一张表（也就是shyman表），也可以写ds.Table["shyman"]

                dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}