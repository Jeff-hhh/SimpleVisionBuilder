using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupportTools;

namespace Module_PLCCommFast
{
    [Serializable]
    public partial class FormFreeTcpClient : Form
    {
        public FormFreeTcpClient(FreeTcpClient freeTcpClient)
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 1;
            _freeTcpClient = freeTcpClient;

            txt_IP.Text = _freeTcpClient.IP;
            txt_Port.Text = _freeTcpClient.Port.ToString();
            lb_Title.Text = _freeTcpClient.CommName;

            freeTcpClient.PushMsg += new CommBase.PushEventHandler(this.ReceiveMsg);
        }

        FreeTcpClient _freeTcpClient = new FreeTcpClient();
        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (txt_IP.Text != null && txt_IP.Text != "")
            {
                _freeTcpClient.IP = txt_IP.Text;
            }
            else
            {
                MessageBox.Show("IP地址格式不得为空！", "通讯设置");
                return;
            }

            if (txt_Port.Text != null && txt_Port.Text != "")
            {
                _freeTcpClient.Port = int.Parse(txt_Port.Text);
            }
            else
            {
                MessageBox.Show("端口号格式不得为空！", "通讯设置");
                return;
            }

            _freeTcpClient.Connect();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _freeTcpClient.DisConnect();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _freeTcpClient.IP = txt_IP.Text;
            _freeTcpClient.Port = int.Parse(txt_Port.Text);
        }

        private void btn_ClearSendData_Click(object sender, EventArgs e)
        {
            txt_SendData.Clear();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _freeTcpClient.mTcpClient.SendData(txt_SendData.Text);
        }

        private void btn_ClearReceiveData_Click(object sender, EventArgs e)
        {
            txt_ReceiveData.Clear();
        }

        private object LockReceived = new object();

        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="sks"></param>
        private void ReceiveMsg(string msg)
        {
            lock (LockReceived)
            {
                try
                {
                    if (msg != null)
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new Action(() =>
                            {
                                if (txt_ReceiveData.TextLength > 200)
                                    txt_ReceiveData.Clear();
                                txt_ReceiveData.AppendText(msg + "\r\n");
                            }));
                        }
                        else
                        {
                            if (txt_ReceiveData.TextLength > 200)
                                txt_ReceiveData.Clear();
                            txt_ReceiveData.AppendText(msg + "\r\n");
                        }
                }
                catch
                (Exception)
                {
                }
            }
        }

    }
}
