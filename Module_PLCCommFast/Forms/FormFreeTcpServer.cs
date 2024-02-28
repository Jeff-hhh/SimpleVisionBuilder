using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_PLCCommFast
{
    public partial class FormFreeTcpServer : Form
    {
        public FormFreeTcpServer(FreeTcpServer freeTcpServer)
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 1;
            _freeTcpServer = freeTcpServer;

            txt_IP.Text = _freeTcpServer.IP;
            txt_Port.Text = _freeTcpServer.Port.ToString();
            lb_Title.Text = _freeTcpServer.CommName;

            freeTcpServer.PushMsg += new CommBase.PushEventHandler(this.ReceiveMsg);
        }

        FreeTcpServer _freeTcpServer = new FreeTcpServer();

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (txt_IP.Text != null && txt_IP.Text != "")
            {
                _freeTcpServer.IP = txt_IP.Text;
            }
            else
            {
                MessageBox.Show("IP地址格式不得为空！", "通讯设置");
                return;
            }

            if (txt_Port.Text != null && txt_Port.Text != "")
            {
                _freeTcpServer.Port = int.Parse(txt_Port.Text);
            }
            else
            {
                MessageBox.Show("端口号格式不得为空！", "通讯设置");
                return;
            }

            _freeTcpServer.Connect();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _freeTcpServer.DisConnect();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _freeTcpServer.IP = txt_IP.Text;
            _freeTcpServer.Port = int.Parse(txt_Port.Text);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            _freeTcpServer.mTcpServer.SendToAll(txt_SendData.Text);
        }

        private void btn_ClearSendData_Click(object sender, EventArgs e)
        {
            txt_SendData.Clear();
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
                catch (Exception)
                {
                }

            }
        }
    }
}