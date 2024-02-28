using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Module_PLCCommFast
{
    [Serializable]
    public class FreeTcpClient : CommBase
    {

        /// <summary>
        /// /Tcp客户端
        /// </summary>
        public SocketHelper.TcpClients mTcpClient = new SocketHelper.TcpClients();

        /// <summary>
        /// 已绑定的正在使用的客户端ip及本地端口信息
        /// </summary>
        public IPEndPoint mUsedIP;

        /// <summary>
        /// 根据属性名初始化参数
        /// </summary>
        /// <param name="propName">属性名</param>
        /// <param name="paramValue">属性值（String）</param>
        /// <returns>初始化状态</returns>
        public bool SetParamValue(string propName, string paramValue)
        {
            try
            {
                switch (propName)
                {
                    case "IP":
                        IP = paramValue;
                        break;
                    case "Port":
                        Port = int.Parse(paramValue);
                        break;
                    case "CommName":
                        CommName = paramValue;
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region [Tcp/IP]

        private object LockReceived = new object();

        /// <summary>
        /// 接收来自Tcp端消息
        /// </summary>
        /// <param name="sks"></param>
        public void ReceiveTcpMsg(SocketHelper.Sockets sks)
        {
            lock (LockReceived)
            {
                if (sks.ex != null)
                {
                    //在此处理异常信息
                    if (sks.ClientDispose)
                    {
                        //客户端非主动断开连接下线.  非正常下线  
                        string str = string.Format("客户端:{0}下线!", sks.Ip);
                        PushData = str;
                        PushEvent();
                        UCommStatus.SetStatus(EnumCommStatus.Closed);
                    }
                }
                else
                {
                    //UCommStatus.SetStatus(EnumCommStatus.Opened);
                    mUsedIP = sks.Ip;    //最新绑定的客户端                      
                    byte[] buffer = new byte[sks.Offset];
                    Array.Copy(sks.RecBuffer, buffer, sks.Offset);
                    string ReceiveMsg = Encoding.UTF8.GetString(buffer);
                    PushData = ReceiveMsg;
                    PushEvent();
                }
            }
        }

        /// <summary>
        /// 打开Tcp客户端
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        public override bool Connect()
        {
            try
            {
                mTcpClient = new SocketHelper.TcpClients();
                mTcpClient.InitSocket(IPAddress.Parse(IP), Port);
                mTcpClient.Start();
                mTcpClient.pushSockets = ReceiveTcpMsg;
                PushData = "服务器连接成功...";
                UCommStatus.SetStatus(EnumCommStatus.Opened);
                return true;
            }
            catch (Exception ex)
            {
                PushData = "服务器连接失败..." + ex.Message;
                return false;
            }
            finally
            {
                PushEvent();
            }
        }

        /// <summary>
        /// 关闭Tcp客户端
        /// </summary>
        public override bool DisConnect()
        {

            try
            {
                if (mTcpClient != null)
                {
                    mTcpClient.Stop();
                    UCommStatus.SetStatus(EnumCommStatus.Closed);
                    return true;
                }
                else
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public override bool Write(string msg)
        {
            try
            {
                mTcpClient.SendData(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
