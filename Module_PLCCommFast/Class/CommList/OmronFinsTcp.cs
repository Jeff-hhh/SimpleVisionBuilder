using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet.Omron;

namespace Module_PLCCommFast
{
    public class OmronFinsTcp : CommBase
    {
        public OmronFinsNet omronFinsNet;

        /// <summary>
        /// PLCIP地址
        /// </summary>
        private string IP;
        /// <summary>
        /// PLC端口号
        /// </summary>
        public int Port;
        /// <summary>
        /// PLC网络号
        /// </summary>
        public byte SA1;
        /// <summary>
        /// 本机网络号
        /// </summary>
        public byte DA1;
        /// <summary>
        /// PLC单元号
        /// </summary>
        public byte DA2;
        /// <summary>
        /// 数据格式
        /// </summary>
        public HslCommunication.Core.DataFormat DataFormat;

        public string PushData;
        public delegate void PushEventHandler(string msg);
        public event PushEventHandler PushMsg; //消息推送

        /// <summary>
        /// 消息推送事件
        /// </summary>
        protected void PushEvent()
        {
            if (PushMsg != null)
            {
                PushMsg(PushData);
            }
        }

        /// <summary>
        /// Omron FinsTcp通讯连接
        /// </summary>
        /// <returns>连接结果</returns>
        public bool Connect()
        {
            try
            {
                omronFinsNet = new OmronFinsNet();
                omronFinsNet.ConnectTimeOut = 2000;
                omronFinsNet.IpAddress = IP;
                omronFinsNet.Port = Port;
                omronFinsNet.SA1 = SA1;
                omronFinsNet.DA1 = DA1;
                omronFinsNet.DA2 = DA2;
                omronFinsNet.ByteTransform.DataFormat = DataFormat;
                OperateResult connect = omronFinsNet.ConnectServer();
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

        /// <summary>
        /// Omron FinsTcp通讯断开
        /// </summary>
        /// <returns>断开结果</returns>
        public bool DisConnect()
        {
            try
            {
                OperateResult connect = omronFinsNet.ConnectClose();
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
            if (omronFinsNet.ReadBool(address).IsSuccess)
            {
                result = omronFinsNet.ReadBool(address).Content;
            }
            else
            {
                result = false;
                PushData = omronFinsNet.ReadBool(address).Message;
                PushEvent();
            }
            return result;
        }

        public float ReadFloat(string address)
        {
            float result;
            if (omronFinsNet.ReadFloat(address).IsSuccess)
            {
                result = omronFinsNet.ReadFloat(address).Content;
            }
            else
            {
                result = float.MaxValue;
                PushData = omronFinsNet.ReadFloat(address).Message;
                PushEvent();
            }
            return result;
        }

        public int ReadInt32(string address)
        {
            int result;
            if (omronFinsNet.ReadInt32(address).IsSuccess)
            {
                result = omronFinsNet.ReadInt32(address).Content;
            }
            else
            {
                result = int.MaxValue;
                PushData = omronFinsNet.ReadInt32(address).Message;
                PushEvent();
            }
            return result;
        }

        public long ReadLong(string address)
        {
            long result;
            if (omronFinsNet.ReadInt64(address).IsSuccess)
            {
                result = omronFinsNet.ReadInt64(address).Content;
            }
            else
            {
                result = long.MaxValue;
                PushData = omronFinsNet.ReadInt64(address).Message;
                PushEvent();
            }
            return result;
        }

        public short ReadShort(string address)
        {
            short result;
            if (omronFinsNet.ReadInt16(address).IsSuccess)
            {
                result = omronFinsNet.ReadInt16(address).Content;
            }
            else
            {
                result = short.MaxValue;
                PushData = omronFinsNet.ReadInt16(address).Message;
                PushEvent();
            }
            return result;
        }

        public string ReadString(string address, string length)
        {
            string result;
            if (omronFinsNet.ReadString(address, ushort.Parse(length)).IsSuccess)
            {
                result = omronFinsNet.ReadString(address, ushort.Parse(length)).Content;
            }
            else
            {
                result = "Null";
                PushData = omronFinsNet.ReadString(address, ushort.Parse(length)).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteBool(string address, bool value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteFloat(string address, float value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteInt(string address, int value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteLong(string address, long value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteShort(string address, short value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteString(string address, string value)
        {
            bool result;
            if (omronFinsNet.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsNet.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }
    }
}
