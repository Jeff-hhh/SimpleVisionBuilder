using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Module_LightController
{
    /// <summary>
    /// 光源控制器基类
    /// </summary>
    public abstract class LightControllerBase
    {
        /// <summary>
        /// 光源控制串口实例
        /// </summary>
        public SerialPort KSerialPort = new SerialPort();

        /// <summary>
        /// 光源控制器通讯状态
        /// </summary>
        public LightCommStatus LightCommStatus = new LightCommStatus();

        /// <summary>
        ///控制器是否打开
        /// </summary>
        public bool IsOpen = false;

        /// <summary>
        /// 光源控制器备注名称
        /// </summary>
        public string LightControllerName;

        /// <summary>
        /// 打开光源控制器
        /// </summary>
        public abstract bool OpenController();

        /// <summary>
        ///  设置单通道亮度
        /// </summary>
        /// <param name="channleIndex">通道号</param>
        /// <param name="lightValue">亮度值</param>
        public abstract void SetChannelValue(int channelIndex, int lightValue);

        /// <summary>
        /// 设置所有通道亮度
        /// </summary>
        /// <param name="lightValue">亮度值</param>
        public abstract void SetAllChannels(int lightValue);

        /// <summary>
        /// 关闭光源控制器
        /// </summary>
        public abstract void CloseController();

        /// <summary>
        /// 获取通道亮度值
        /// </summary>
        public abstract void GetChannelLightValue(int channelIndex);

        /// <summary>
        /// 设置通讯参数
        /// </summary>
        /// <param name="propName">属性名称</param>
        /// <param name="paramValue">属性值</param>
        /// <returns></returns>
        public abstract bool SetParamValue(string propName, string paramValue);
    }

    /// <summary>
    /// 通讯类型
    /// </summary>
    public enum LCommTypes
    {
        /// <summary>
        /// 232串口
        /// </summary>
        RS232,
        /// <summary>
        /// 网口
        /// </summary>
        Socket
    }
}
