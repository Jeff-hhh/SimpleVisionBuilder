using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Module_PLCCommFast
{
    public class FreeTcpServer : CommBase
    {
        /// <summary>
        /// Tcp服务器
        /// </summary>
       public SocketHelper.TcpServer mTcpServer = new SocketHelper.TcpServer();

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
                        UCommStatus.SetStatus(EnumCommStatus.Waiting);
                        //客户端非主动断开连接下线.  非正常下线  
                        string str = string.Format("客户端:{0}下线!", sks.Ip);
                        PushData = str;
                        PushEvent();
                    }
                    //MessageBox.Show(sks.ex.Message);
                    //服务端  server.ClientList 已移除,需要用户再次移除
                }
                else
                {
                    if (sks.NewClientFlag)
                    {
                        UCommStatus.SetStatus(EnumCommStatus.Opened);
                        string str = string.Format("新客户端:{0}连接成功!", sks.Ip);
                        mUsedIP = sks.Ip;    //最新绑定的客户端    
                        PushData = str;
                    }
                    else if (sks.Offset == 0)
                    {
                        UCommStatus.SetStatus(EnumCommStatus.Waiting);
                        //正常是不会发送0包的,只有客户端主动断开连接时发送空包.
                        string str = string.Format("客户端:{0}下线!", sks.Ip);
                        PushData = str;
                        PushEvent();

                        //mTcpServer.pushSockets -= ReceiveTcpMsg;
                    }
                    else
                    {
                        mUsedIP = sks.Ip;    //最新绑定的客户端                      
                        byte[] buffer = new byte[sks.Offset];
                        Array.Copy(sks.RecBuffer, buffer, sks.Offset);
                        string ReceiveMsg = Encoding.UTF8.GetString(buffer);
                        PushData = ReceiveMsg;

                        PushEvent();
                    }
                }
            }
        }

        /// <summary>
        /// 打开Tcp服务器
        /// </summary>
        public override bool Connect()
        {
            try
            {
                mTcpServer = new SocketHelper.TcpServer();
                mTcpServer.InitSocket(IPAddress.Parse(IP), Port);
                mTcpServer.Start();
                mTcpServer.pushSockets = ReceiveTcpMsg;
                PushData = $"服务器{IP}:{Port}启动成功，等待客户端连接...";
                PushEvent();
                UCommStatus.SetStatus(EnumCommStatus.Waiting);
                return true;
            }
            catch (Exception ex)
            {
                PushEvent();
                return false;
            }
        }

        /// <summary>
        /// 关闭Tcp服务器
        /// </summary>
        public override bool DisConnect()
        {
            try
            {
                if (mTcpServer != null)
                {
                    mTcpServer.Stop();
                    PushData = $"服务器{IP}:{Port}监听已断开...";
                    PushEvent();
                    UCommStatus.SetStatus(EnumCommStatus.Closed);
                    return true;
                }
                else
                {
                    return true;
                }
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
                mTcpServer.SendToAll(msg);
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
