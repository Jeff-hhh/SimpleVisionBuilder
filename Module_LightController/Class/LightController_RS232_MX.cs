using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Module_LightController
{
    /// <summary>
    /// 牧希控制器
    /// </summary>
    class LightController_RS232_MX : LightControllerBase
    {
        public LightController_RS232_MX()
        {
            KSerialPort = new SerialPort();
        }

        public override bool OpenController()
        {
            try
            {
                if (!IsOpen)
                {
                    KSerialPort.Open();
                    if (KSerialPort.IsOpen)
                    {
                        LightCommStatus.SetStatus(true);
                        IsOpen = true;
                        return true;
                    }
                    else
                    {
                        LightCommStatus.SetStatus(false);
                        IsOpen = false;
                        return false;
                    }
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public override void SetChannelValue(int channelIndex, int lightValue)
        {
            try
            {
                string ChannelID = "";
                switch (channelIndex)
                {
                    case 1:
                        ChannelID = "A";
                        break;
                    case 2:
                        ChannelID = "B";
                        break;
                    case 3:
                        ChannelID = "C";
                        break;
                    case 4:
                        ChannelID = "D";
                        break;
                }
                string LCMD = $"S{ChannelID}{lightValue:D4}#";
                if (KSerialPort.IsOpen)
                    KSerialPort.Write(LCMD);
                Thread.Sleep(30);
            }
            catch (Exception)
            {
            }
        }

        public override void CloseController()
        {
            try
            {
                if (IsOpen)
                {
                    KSerialPort.Close();
                    if (!KSerialPort.IsOpen)
                    {
                        IsOpen = false;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public override void SetAllChannels(int lightValue)
        {
            try
            {
                if (KSerialPort.IsOpen)
                {
                    KSerialPort.Write($"SA0000#");
                    Thread.Sleep(30);
                    KSerialPort.Write($"SB0000#");
                    Thread.Sleep(30);
                    KSerialPort.Write($"SC0000#");
                    Thread.Sleep(30);
                    KSerialPort.Write($"SD0000#");

                }
            }
            catch (Exception)
            {
            }
        }

        public override void GetChannelLightValue(int channelIndex)
        {
            string ChannelID = "";
            switch (channelIndex)
            {
                case 1:
                    ChannelID = "A";
                    break;
                case 2:
                    ChannelID = "B";
                    break;
                case 3:
                    ChannelID = "C";
                    break;
                case 4:
                    ChannelID = "D";
                    break;
            }
            if (KSerialPort.IsOpen)
                KSerialPort.Write($"S{ChannelID}#");
        }


        public override bool SetParamValue(string propName, string paramValue)
        {
            try
            {
                switch (propName)
                {
                    case "ControllerName":
                        LightControllerName = paramValue;
                        break;
                    case "PortName":
                        KSerialPort.PortName = paramValue;
                        break;
                    case "BuadRate":
                        KSerialPort.BaudRate = int.Parse(paramValue);
                        break;
                    case "DataBits":
                        KSerialPort.DataBits = int.Parse(paramValue);
                        break;
                    case "StopBits":
                        switch (paramValue)
                        {
                            case "One":
                                KSerialPort.StopBits = StopBits.One;
                                break;
                            case "OnePointFive":
                                KSerialPort.StopBits = StopBits.OnePointFive;
                                break;
                            case "Two":
                                KSerialPort.StopBits = StopBits.Two;
                                break;
                        }
                        break;
                    case "Parity":
                        switch (paramValue)
                        {
                            case "None":
                                KSerialPort.Parity = Parity.None;
                                break;
                            case "Odd":
                                KSerialPort.Parity = Parity.Odd;
                                break;
                            case "Even":
                                KSerialPort.Parity = Parity.Even;
                                break;
                            case "Mark":
                                KSerialPort.Parity = Parity.Mark;
                                break;
                            case "Space":
                                KSerialPort.Parity = Parity.Space;
                                break;
                        }
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
