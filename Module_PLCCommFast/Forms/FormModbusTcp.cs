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
    [Serializable]
    public partial class FormModbusTcp : Form
    {
        public FormModbusTcp(ModbusTcp modbusTcp)
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 1;
            _modbusTcp = modbusTcp;

            txt_IP.Text = _modbusTcp.IP;
            txt_Port.Text = _modbusTcp.Port.ToString();
            cmb_DataFormat.SelectedItem = _modbusTcp.DataFormat.ToString();
            lb_Title.Text = _modbusTcp.CommName;

            _modbusTcp.PushMsg += ReceiveMsg;
        }

        ModbusTcp _modbusTcp = new ModbusTcp();

        #region [通讯打开与关闭]

        private void btn_Open_Click(object sender, EventArgs e)
        {
            _modbusTcp.Connect();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            _modbusTcp.DisConnect();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _modbusTcp.IP = txt_IP.Text;
            _modbusTcp.Port = int.Parse(txt_Port.Text);
            _modbusTcp.DataFormat = (HslCommunication.Core.DataFormat)Enum.Parse(typeof(HslCommunication.Core.DataFormat), cmb_DataFormat.SelectedItem.ToString());
            
        }

        #endregion


        #region [读操作]

        private void btn_ReadShort_Click(object sender, EventArgs e)
        {
            short result;
            result = _modbusTcp.ReadShort(txt_ReadAddress.Text);
            if (result != -1)
                txt_ReadResult.Text = result.ToString();
        }

        private void btn_ReadInt_Click(object sender, EventArgs e)
        {
            int result;
            result = _modbusTcp.ReadInt32(txt_ReadAddress.Text);
            if (result != -1)
                txt_ReadResult.Text = result.ToString();
        }

        private void btn_ReadBool_Click(object sender, EventArgs e)
        {
            bool result;
            result = _modbusTcp.ReadBool(txt_ReadAddress.Text);
            txt_ReadResult.Text = result.ToString();
        }

        private void btn_ReadFloat_Click(object sender, EventArgs e)
        {
            float result;
            result = _modbusTcp.ReadFloat(txt_ReadAddress.Text);
            if (result != -1)
                txt_ReadResult.Text = result.ToString();
        }

        private void btn_ReadString_Click(object sender, EventArgs e)
        {
            string result;
            string length;
            length = txt_ReadStringLength.Text;
            result = _modbusTcp.ReadString(txt_ReadAddress.Text, length);
            txt_ReadResult.Text = result.ToString();
        }

        #endregion


        #region [写操作]

        private void btn_WriteShort_Click(object sender, EventArgs e)
        {
            short value;
            if (!short.TryParse(this.txt_WriteValue.Text, out value))
            {
                MessageBox.Show("写入的数据格式不正确！");
                return;
            }
            _modbusTcp.WriteShort(txt_WriteAddress.Text, value);
        }

        private void btn_WriteInt_Click(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(this.txt_WriteValue.Text, out value))
            {
                MessageBox.Show("写入的数据格式不正确！");
                return;
            }
            _modbusTcp.WriteInt(txt_WriteAddress.Text, value);
        }

        private void btn_WriteBool_Click(object sender, EventArgs e)
        {
            bool value;
            if (!bool.TryParse(this.txt_WriteValue.Text, out value))
            {
                MessageBox.Show("写入的数据格式不正确！");
                return;
            }
            _modbusTcp.WriteBool(txt_WriteAddress.Text, value);
        }

        private void btn_WriteFloat_Click(object sender, EventArgs e)
        {
            float value;
            if (!float.TryParse(this.txt_WriteValue.Text, out value))
            {
                MessageBox.Show("写入的数据格式不正确！");
                return;
            }
            _modbusTcp.WriteFloat(txt_WriteAddress.Text, value);
        }

        private void btn_WriteString_Click(object sender, EventArgs e)
        {
            string value;
            value = txt_WriteValue.Text;
            _modbusTcp.WriteString(txt_WriteAddress.Text, value);
        }

        #endregion


        #region [接收消息]

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
                                txt_ReadResult.Text = msg;
                            }));
                        }
                        else
                        {
                            txt_ReadResult.Text = msg;
                        }
                }
                catch (Exception)
                {

                }
            }
        }

        #endregion


    }
}
