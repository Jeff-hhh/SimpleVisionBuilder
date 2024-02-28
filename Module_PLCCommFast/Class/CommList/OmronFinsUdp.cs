using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet.Omron;

namespace Module_PLCCommFast
{
    public class OmronFinsUdp : CommBase
    {
        public HslCommunication.Profinet.Omron.OmronFinsUdp omronFinsUdp = null;

        /// <summary>
        /// PLC网络号
        /// </summary>
        public static byte SA1;
        /// <summary>
        /// 数据格式
        /// </summary>
        public HslCommunication.Core.DataFormat DataFormat;
        /// <summary>
        /// IP地址
        /// </summary>
        public string IP;
        /// <summary>
        /// 端口号
        /// </summary>
        public int Port;

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
        /// 创建Fins UDP实例
        /// </summary>
        /// <returns></returns>
        public bool CreateUdpObject()
        {
            try
            {
                omronFinsUdp = new HslCommunication.Profinet.Omron.OmronFinsUdp(IP, Port);
                omronFinsUdp.SA1 = SA1;
                omronFinsUdp.ByteTransform.DataFormat = DataFormat;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ReadBool(string address)
        {
            bool result;
            if (omronFinsUdp.ReadBool(address).IsSuccess)
            {
                result = omronFinsUdp.ReadBool(address).Content;
            }
            else
            {
                result = false;
                PushData = omronFinsUdp.ReadBool(address).Message;
                PushEvent();
            }
            return result;
        }

        public float ReadFloat(string address)
        {
            float result;
            if (omronFinsUdp.ReadFloat(address).IsSuccess)
            {
                result = omronFinsUdp.ReadFloat(address).Content;
            }
            else
            {
                result = float.MaxValue;
                PushData = omronFinsUdp.ReadFloat(address).Message;
                PushEvent();
            }
            return result;
        }

        public int ReadInt32(string address)
        {
            int result;
            if (omronFinsUdp.ReadInt32(address).IsSuccess)
            {
                result = omronFinsUdp.ReadInt32(address).Content;
            }
            else
            {
                result = int.MaxValue;
                PushData = omronFinsUdp.ReadInt32(address).Message;
                PushEvent();
            }
            return result;
        }

        public long ReadLong(string address)
        {
            long result;
            if (omronFinsUdp.ReadInt64(address).IsSuccess)
            {
                result = omronFinsUdp.ReadInt64(address).Content;
            }
            else
            {
                result = long.MaxValue;
                PushData = omronFinsUdp.ReadInt64(address).Message;
                PushEvent();
            }
            return result;
        }

        public short ReadShort(string address)
        {
            short result;
            if (omronFinsUdp.ReadInt16(address).IsSuccess)
            {
                result = omronFinsUdp.ReadInt16(address).Content;
            }
            else
            {
                result = short.MaxValue;
                PushData = omronFinsUdp.ReadInt16(address).Message;
                PushEvent();
            }
            return result;
        }

        public string ReadString(string address, string length)
        {
            string result;
            if (omronFinsUdp.ReadString(address, ushort.Parse(length)).IsSuccess)
            {
                result = omronFinsUdp.ReadString(address, ushort.Parse(length)).Content;
            }
            else
            {
                result = "Null";
                PushData = omronFinsUdp.ReadString(address, ushort.Parse(length)).Message;
                PushEvent();
            }
            return result;
        }

        public bool WriteBool(string address, bool value)
        {

            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteFloat(string address, float value)
        {
            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteInt(string address, int value)
        {
            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteLong(string address, long value)
        {
            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteShort(string address, short value)
        {
            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }

        public bool WriteString(string address, string value)
        {
            bool result;
            if (omronFinsUdp.Write(address, value).IsSuccess)
            {
                result = true;
            }
            else
            {
                result = false;
                PushData = (omronFinsUdp.Write(address, value).Message);
                PushEvent();
            }
            return result;
        }
    }
}
