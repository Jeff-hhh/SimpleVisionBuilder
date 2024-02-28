using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Module_LightController
{
    public partial class FormControllerRS232 : Form
    {
        public FormControllerRS232(LightControllerBase lightControllerBase)
        {
            InitializeComponent();
            _LightControllerBase = lightControllerBase;
            _SerialPort = _LightControllerBase.KSerialPort;
            _SerialPort.DataReceived += SerialPort_DataReceived;
        }

        LightControllerBase _LightControllerBase;
        SerialPort _SerialPort = new SerialPort();
        private void FormControllerUI_Load(object sender, EventArgs e)
        {
            try
            {
                if (_SerialPort == null)
                    return;

                cmb_PortName.SelectedItem = _SerialPort.PortName;
                cmb_BuadRate.SelectedItem = _SerialPort.BaudRate.ToString();

                switch (_SerialPort.Parity)
                {
                    case Parity.None:
                        cmb_Parity.SelectedItem = "None";
                        break;
                    case Parity.Odd:
                        cmb_Parity.SelectedItem = "Odd";
                        break;
                    case Parity.Even:
                        cmb_Parity.SelectedItem = "Even";
                        break;
                    case Parity.Mark:
                        cmb_Parity.SelectedItem = "Mark";
                        break;
                    case Parity.Space:
                        cmb_Parity.SelectedItem = "Space";
                        break;
                }

                cmb_DataBits.SelectedItem = _SerialPort.DataBits.ToString();

                switch (_SerialPort.StopBits)
                {
                    case StopBits.One:
                        cmb_StopBits.SelectedItem = "1";
                        break;
                    case StopBits.OnePointFive:
                        cmb_StopBits.SelectedItem = "1.5";
                        break;
                    case StopBits.Two:
                        cmb_StopBits.SelectedItem = "2";
                        break;
                }

                if (_SerialPort.IsOpen)
                {
                    _LightControllerBase.GetChannelLightValue(1);
                    Thread.Sleep(100);
                    _LightControllerBase.GetChannelLightValue(2);
                    Thread.Sleep(100);
                    _LightControllerBase.GetChannelLightValue(3);
                    Thread.Sleep(100);
                    _LightControllerBase.GetChannelLightValue(4);
                }
            }
            catch (Exception)
            {

            }
        }

        string _PortName;
        private void cmb_PortNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PortName = cmb_PortName.SelectedItem.ToString();
        }

        int _BaudRate;
        private void cmb_BuadRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            _BaudRate = int.Parse(cmb_BuadRate.SelectedItem.ToString());
        }

        Parity _Parity;
        private void cmb_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Parity.SelectedItem.ToString())
            {
                case "None":
                    _Parity = Parity.None;
                    break;
                case "Odd":
                    _Parity = Parity.Odd;
                    break;
                case "Even":
                    _Parity = Parity.Even;
                    break;
                case "Mark":
                    _Parity = Parity.Mark;
                    break;
                case "Space":
                    _Parity = Parity.Space;
                    break;
            }
        }

        int _DataBits;
        private void cmb_DataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DataBits = int.Parse(cmb_DataBits.SelectedItem.ToString());
        }

        StopBits _StopBits;
        private void cmb_StopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_StopBits.SelectedItem.ToString())
            {
                case "1":
                    _StopBits = StopBits.One;
                    break;
                case "1.5":
                    _StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    _StopBits = StopBits.Two;
                    break;
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {

                if (!_SerialPort.IsOpen)
                {

                    _SerialPort.PortName = _PortName;
                    _SerialPort.BaudRate = _BaudRate;
                    _SerialPort.Parity = _Parity;
                    _SerialPort.DataBits = _DataBits;
                    _SerialPort.StopBits = _StopBits;

                    _SerialPort.Open();
                }

                if (_SerialPort.IsOpen)
                {
                    _LightControllerBase.LightCommStatus.SetStatus(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Light Control Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                _SerialPort.Close();
                if (!_SerialPort.IsOpen)
                {
                    _LightControllerBase.LightCommStatus.SetStatus(false);
                }
                return;
            }
            catch (Exception)
            {

            }
        }

        private void tbar_CH1_Scroll(object sender, EventArgs e)
        {
            nValue_CH1.Value = tbar_CH1.Value;
            _LightControllerBase.SetChannelValue(1, tbar_CH1.Value);
            Thread.Sleep(100);
        }

        private void tbar_CH2_Scroll(object sender, EventArgs e)
        {
            nValue_CH2.Value = tbar_CH2.Value;
            _LightControllerBase.SetChannelValue(2, tbar_CH2.Value);
            Thread.Sleep(100);
        }

        private void tbar_CH3_Scroll(object sender, EventArgs e)
        {
            nValue_CH3.Value = tbar_CH3.Value;
            _LightControllerBase.SetChannelValue(3, tbar_CH3.Value);
            Thread.Sleep(100);
        }

        private void tbar_CH4_Scroll(object sender, EventArgs e)
        {
            nValue_CH4.Value = tbar_CH4.Value;
            _LightControllerBase.SetChannelValue(4, tbar_CH4.Value);
            Thread.Sleep(100);
        }

        private void nValue_CH1_ValueChanged(object sender, EventArgs e)
        {
            tbar_CH1.Value = (int)nValue_CH1.Value;
            _LightControllerBase.SetChannelValue(1, tbar_CH1.Value);
            Thread.Sleep(100);
        }

        private void nValue_CH2_ValueChanged(object sender, EventArgs e)
        {
            tbar_CH2.Value = (int)nValue_CH2.Value;
            _LightControllerBase.SetChannelValue(2, tbar_CH2.Value);
            Thread.Sleep(100);
        }

        private void nValue_CH3_ValueChanged(object sender, EventArgs e)
        {
            tbar_CH3.Value = (int)nValue_CH3.Value;
            _LightControllerBase.SetChannelValue(3, tbar_CH3.Value);
            Thread.Sleep(100);
        }

        private void nValue_CH4_ValueChanged(object sender, EventArgs e)
        {
            tbar_CH4.Value = (int)nValue_CH4.Value;
            _LightControllerBase.SetChannelValue(4, tbar_CH4.Value);
            Thread.Sleep(100);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100); //延时100ms，等待接收完数据

            try
            {
                if (this.InvokeRequired)
                {
                    Invoke((EventHandler)(delegate    //this.Invoke是跨线程访问ui
                    {
                        if (_SerialPort.BytesToRead == 0)
                            return;

                        //接收字节序列直接处理
                        byte[] bytes = new byte[_SerialPort.BytesToRead];
                        _SerialPort.Read(bytes, 0, bytes.Length);

                        string recMsg = System.Text.Encoding.Default.GetString(bytes);

                        if (recMsg.Contains("a"))
                        {
                            nValue_CH1.Value = int.Parse(recMsg.Substring(1, 3));
                        }

                        if (recMsg.Contains("b"))
                        {
                            nValue_CH2.Value = int.Parse(recMsg.Substring(1, 3));
                        }

                        if (recMsg.Contains("c"))
                        {
                            nValue_CH3.Value = int.Parse(recMsg.Substring(1, 3));
                        }

                        if (recMsg.Contains("d"))
                        {
                            nValue_CH4.Value = int.Parse(recMsg.Substring(1, 3));
                        }

                        _SerialPort.DiscardInBuffer();    //清除串口接收缓冲区数据
                    }));
                }
                else
                {
                    if (_SerialPort.BytesToRead == 0)
                        return;

                    //接收字节序列直接处理
                    byte[] bytes = new byte[_SerialPort.BytesToRead];
                    _SerialPort.Read(bytes, 0, bytes.Length);

                    string recMsg = System.Text.Encoding.Default.GetString(bytes);

                    if (recMsg.Contains("a"))
                    {
                        nValue_CH1.Value = int.Parse(recMsg.Substring(1, 3));
                    }

                    if (recMsg.Contains("b"))
                    {
                        nValue_CH2.Value = int.Parse(recMsg.Substring(1, 3));
                    }

                    if (recMsg.Contains("c"))
                    {
                        nValue_CH3.Value = int.Parse(recMsg.Substring(1, 3));
                    }

                    if (recMsg.Contains("d"))
                    {
                        nValue_CH4.Value = int.Parse(recMsg.Substring(1, 3));
                    }

                    _SerialPort.DiscardInBuffer();    //清除串口接收缓冲区数据
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据接受失败");
            }
        }
    }
}
