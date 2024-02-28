using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet.Siemens;

namespace Module_PLCCommFast
{
    public class SiemensS7Series : CommBase
    {
        public SiemensS7Net siemensS7TcpNet;//西门子S7协议
        public string IP;
        public int Port;
        public SiemensPLCS siemensPLCS = 0;
        public bool IsSiemensS7Connect;

        public string PushData;
        public delegate void PushEventHandler(string msg);
        public event PushEventHandler PushMsg;

        protected void PushEvent()
        {
            PushMsg?.Invoke(PushData);
        }

        public bool DisConnect()
        {
            try
            {
                if (IsSiemensS7Connect)
                {
                    siemensS7TcpNet.ConnectClose();
                    IsSiemensS7Connect = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                PushData = "关闭失败：" + ex.Message;
                PushEvent();
                return false;
            }
        }

        public bool ReadBool(string address)
        {
            bool result;
            if (siemensS7TcpNet.ReadBool(address).IsSuccess)
            {
                result = siemensS7TcpNet.ReadBool(address).Content;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.ReadBool(address).Message;
                PushEvent();
            }
            return result;
        }

        public float ReadFloat(string address)
        {
            float result;
            if (siemensS7TcpNet.ReadFloat(address).IsSuccess)
            {
                result = siemensS7TcpNet.ReadFloat(address).Content;
            }
            else
            {
                result = float.MaxValue;
                PushData = siemensS7TcpNet.ReadFloat(address).Message;
                PushEvent();
            }
            return result;
        }

        public int ReadInt32(string address)
        {
            int result;
            if (siemensS7TcpNet.ReadInt32(address).IsSuccess)
            {
                result = siemensS7TcpNet.ReadInt32(address).Content;
            }
            else
            {
                result = int.MaxValue;
                PushData = siemensS7TcpNet.ReadInt32(address).Message;
                PushEvent();
            }
            return result;
        }

        public long ReadLong(string address)
        {
            long result;
            if (siemensS7TcpNet.ReadInt64(address).IsSuccess)
            {
                result = siemensS7TcpNet.ReadInt64(address).Content;
            }
            else
            {
                result = long.MaxValue;
                PushData = siemensS7TcpNet.ReadInt64(address).Message;
                PushEvent();
            }
            return result;
        }

        public short ReadShort(string address)
        {
            short result;
            if (siemensS7TcpNet.ReadInt16(address).IsSuccess)
            {
                result = siemensS7TcpNet.ReadInt16(address).Content;
            }
            else
            {
                result = short.MaxValue;
                PushData = siemensS7TcpNet.ReadInt16(address).Message;
                PushEvent();
            }
            return result;
        }

        public string ReadString(string address, string length)
        {
            string result;
            try
            {
                if (siemensS7TcpNet.ReadString(address, ushort.Parse(length)).IsSuccess)
                {
                    result = siemensS7TcpNet.ReadString(address, ushort.Parse(length)).Content;
                }
                else
                {
                    result = "Null";
                    PushData = siemensS7TcpNet.ReadInt16(address).Message;
                    PushEvent();
                }

            }
            catch (Exception ex)
            {
                result = "Error:" + ex.ToString();
                throw;
            }
            return result;
        }

        public bool WriteBool(string address, bool value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (siemensS7TcpNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteFloat(string address, float value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteInt(string address, int value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteLong(string address, long value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteShort(string address, short value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteString(string address, string value)
        {
            bool result;
            if (siemensS7TcpNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = siemensS7TcpNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

    }
}
