using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet.Melsec;

namespace Module_PLCCommFast
{
    public class MelsecBinary : CommBase
    {
        public MelsecMcNet melsecBinaryNet;//三菱MC协议【二进制】
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP;
        /// <summary>
        /// 端口号
        /// </summary>
        public int Port;

        public string PushData;//推送消息

        public delegate void PushEventHandler(string msg);//推送委托
        public event PushEventHandler PushMsg; //推送事件

        protected void PushEvent()
        {
            PushMsg?.Invoke(PushData);
        }

        public bool Connect()
        {
            try
            {
                melsecBinaryNet = new MelsecMcNet();
                melsecBinaryNet.IpAddress = IP;
                melsecBinaryNet.Port = Port;
                melsecBinaryNet.ConnectTimeOut = 60000;

                OperateResult connect = melsecBinaryNet.ConnectServer();
                if (connect.IsSuccess)
                {
                    PushData = "三菱MC通信连接成功！";
                    return true;
                }
                else
                {
                    PushData = "三菱MC通信连接失败：" + connect.Message;
                    return false;
                }
            }
            catch (Exception ex)
            {
                PushData = "三菱MC通信连接失败：" + ex.ToString();
                return false;
            }
            finally
            {
                PushEvent();
            }
        }

        public bool DisConnect()
        {
            try
            {
                OperateResult connect = melsecBinaryNet.ConnectClose();
                if (connect.IsSuccess)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ReadBool(string address)
        {
            bool result;
            if (melsecBinaryNet.ReadBool(address).IsSuccess)
            {
                result = melsecBinaryNet.ReadBool(address).Content;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.ReadBool(address).Message;
                PushEvent();
            }
            return result;
        }

        public float ReadFloat(string address)
        {
            float result;
            if (melsecBinaryNet.ReadFloat(address).IsSuccess)
            {
                result = melsecBinaryNet.ReadFloat(address).Content;
            }
            else
            {
                result = float.MaxValue;
                PushData = melsecBinaryNet.ReadFloat(address).Message;
                PushEvent();
            }
            return result;
        }

        public int ReadInt32(string address)
        {
            int result;
            if (melsecBinaryNet.ReadInt32(address).IsSuccess)
            {
                result = melsecBinaryNet.ReadInt32(address).Content;
            }
            else
            {
                result = int.MaxValue;
                PushData = melsecBinaryNet.ReadInt32(address).Message;
                PushEvent();
            }
            return result;
        }

        public long ReadLong(string address)
        {
            long result;
            if (melsecBinaryNet.ReadInt64(address).IsSuccess)
            {
                result = melsecBinaryNet.ReadInt64(address).Content;
            }
            else
            {
                result = long.MaxValue;
                PushData = melsecBinaryNet.ReadInt64(address).Message;
                PushEvent();
            }
            return result;
        }

        public short ReadShort(string address)
        {
            short result;
            if (melsecBinaryNet.ReadInt16(address).IsSuccess)
            {
                result = melsecBinaryNet.ReadInt16(address).Content;
            }
            else
            {
                result = short.MaxValue;
                PushData = melsecBinaryNet.ReadInt16(address).Message;
                PushEvent();
            }
            return result;
        }

        public string ReadString(string address, string length)
        {
            string result;
            try
            {
                if (melsecBinaryNet.ReadString(address, ushort.Parse(length)).IsSuccess)
                {
                    result = melsecBinaryNet.ReadString(address, ushort.Parse(length)).Content;
                }
                else
                {
                    result = "Null";
                    PushData = melsecBinaryNet.ReadInt16(address).Message;
                    PushEvent();
                }
            }
            catch (Exception ex)
            {
                result = "Error:" + ex.ToString();
            }
            return result;
        }

        public bool WriteBool(string address, bool value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (melsecBinaryNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteFloat(string address, float value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteInt(string address, int value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteLong(string address, long value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteShort(string address, short value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteString(string address, string value)
        {
            bool result;
            if (melsecBinaryNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = melsecBinaryNet.Write(address, value).Message;
                PushEvent();
            }
            return result;
        }

    }
}
