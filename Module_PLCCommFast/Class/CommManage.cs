using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_PLCCommFast
{
    /// <summary>
    /// 通讯管理类
    /// </summary>
    public class CommManage
    {
        public CommManage(CommType commType, Dictionary<string, string> props)
        {
            SwitchCommType(commType, props);
        }

        public CommManage(CommType commType)
        {
            SwitchCommType(commType);
        }

        public System.Windows.Forms.Form FormCommSet;

        /// <summary>
        /// 通讯实例
        /// </summary>
        public CommBase _CommBase;

        /// <summary>
        /// 获取通讯类型
        /// </summary>
        /// <param name="commType">通讯类型</param>
        /// <returns>返回类型</returns>
        public CommBase SwitchCommType(CommType commType, Dictionary<string, string> props)
        {
            switch (commType)
            {
                case CommType.FreeTcpServer:
                    _CommBase = new FreeTcpServer();
                    foreach (KeyValuePair<string, string> item in props)
                    {
                        ((FreeTcpServer)_CommBase).SetParamValue(item.Key, item.Value);
                    }
                    FormCommSet = new FormFreeTcpServer((FreeTcpServer)_CommBase);
                    break;
                case CommType.FreeTcpClient:
                    _CommBase = new FreeTcpClient();
                    foreach (KeyValuePair<string, string> item in props)
                    {
                        ((FreeTcpClient)_CommBase).SetParamValue(item.Key, item.Value);
                    }
                    FormCommSet = new FormFreeTcpClient((FreeTcpClient)_CommBase);
                    break;
                case CommType.ModbusTCP:
                    _CommBase = new ModbusTcp();
                    foreach (KeyValuePair<string, string> item in props)
                    {
                        ((ModbusTcp)_CommBase).SetParamValue(item.Key, item.Value);
                    }
                    FormCommSet = new FormModbusTcp((ModbusTcp)_CommBase);
                    break;
            }
            return _CommBase;
        }

        /// <summary>
        /// 获取通讯类型
        /// </summary>
        /// <param name="commType">通讯类型</param>
        /// <returns>返回类型</returns>
        public CommBase SwitchCommType(CommType commType)
        {
            switch (commType)
            {
                case CommType.FreeTcpServer:
                    _CommBase = new FreeTcpServer();
                    FormCommSet = new FormFreeTcpServer((FreeTcpServer)_CommBase);
                    break;
                case CommType.FreeTcpClient:
                    _CommBase = new FreeTcpClient();
                    FormCommSet = new FormFreeTcpClient((FreeTcpClient)_CommBase);
                    break;
                case CommType.ModbusTCP:
                    _CommBase = new ModbusTcp();
                    FormCommSet = new FormModbusTcp((ModbusTcp)_CommBase);
                    break;
            }
            return _CommBase;
        }
    }
}
