using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro;
using System.Windows.Forms;

namespace Module_Camera
{
    public class CogCamera
    {
        public CogAcqFifoTool _Acq;//康耐视相机实例    
        public Action<CogImage8Grey> ImageCallback;//取像回调
        private double _Exposure;//曝光
        private double _Gain;//增益
        private double _Contrast;//对比度
        private int _NumAcqs;//取像次数
        private bool _CamConnectStatus;//相机连接状态

        public static List<string> _CamIPList = new List<string>();//获取所有相机的IP

        /// <summary>
        /// 根据SN码构造相机实例
        /// </summary>
        /// <param name="ipAddress"></param>
        public CogCamera(string ipAddress)
        {
            CogFrameGrabbers frameGrabber = new CogFrameGrabbers();
            try
            {
                if (frameGrabber.Count < 1)
                    return;
                foreach (ICogFrameGrabber frame in frameGrabber)
                {
                    if (frame.OwnedGigEAccess.CurrentIPAddress == ipAddress)
                    {
                        _Acq = new CogAcqFifoTool();
                        _Acq.Operator = frame.CreateAcqFifo(frame.AvailableVideoFormats[0], CogAcqFifoPixelFormatConstants.Format8Grey, 0, true);
                        _Acq.Operator.Flush();
                        _CamConnectStatus = true;
                    }
                    else
                    {
                        _CamConnectStatus = false;
                    }
                }
            }
            catch (Exception)
            {
                _CamConnectStatus = false;
            }
        }

        /// <summary>
        /// 获取所有相机IP
        /// </summary>
        public static void GetCamIPList()
        {
            CogFrameGrabbers frameGrabber = new CogFrameGrabbers();
            if (frameGrabber.Count < 1)
                return;
            else
            {
                _CamIPList.Clear();
                foreach (ICogFrameGrabber frame in frameGrabber)
                {
                    _CamIPList.Add(frame.OwnedGigEAccess.CurrentIPAddress);
                }
            }
        }

        /// <summary>
        /// 软触发取图
        /// </summary>
        /// <returns></returns>
        public CogImage8Grey AcquireImage()
        {
            if (_Acq.Operator == null)
                return null;
            int trignum;
            CogImage8Grey cogImage = _Acq.Operator.Acquire(out trignum) as CogImage8Grey;
            _NumAcqs++;
            if (_NumAcqs > 4)
            {
                GC.Collect();
                _NumAcqs = 0;
            }
            return cogImage;
        }

        /// <summary>
        /// 取图事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operator_Complete(object sender, CogCompleteEventArgs e)
        {
            bool busyState;
            int numPending, numReady;
            CogAcqInfo info = new CogAcqInfo();
            _Acq.Operator.GetFifoState(out numPending, out numReady, out busyState);
            CogImage8Grey image = new CogImage8Grey();
            if (numReady > 0)
            {
                image = _Acq.Operator.CompleteAcquireEx(info) as CogImage8Grey;
            }
            _NumAcqs++;
            if (_NumAcqs > 4)
            {
                GC.Collect();
                _NumAcqs = 0;
            }
            ImageCallback?.Invoke(image);
        }

        /// <summary>
        /// 相机IP集合
        /// </summary>
        public static List<string> CamIPList
        {
            get { return _CamIPList; }
        }

        /// <summary>
        /// 工位相机工具
        /// </summary>
        public CogAcqFifoTool Acq
        {
            get
            {
                return _Acq;
            }
            set
            {
                _Acq = value;
            }
        }

        /// <summary>
        /// 初始化状态
        /// </summary>
        public bool ConnectState
        {
            get { return _CamConnectStatus; }
        }

        /// <summary>
        /// 曝光属性
        /// </summary>
        public double Exposure
        {
            get { return _Exposure; }
            set
            {
                if (value > 0 && value < 200000)
                    _Exposure = value;
            }
        }

        /// <summary>
        /// 增益属性
        /// </summary>
        public double Gain
        {
            get { return _Gain; }
            set
            {
                if (value >= 0 && value < 1)
                    _Gain = value;
            }
        }

        /// <summary>
        /// 对比度属性
        /// </summary>
        public double Contrast
        {
            get { return _Contrast; }
            set
            {
                if (value >= 0 && value < 1)
                    _Contrast = value;
            }
        }

        /// <summary>
        /// 设置曝光
        /// </summary>
        public void SetExposure()
        {
            if (_Acq.Operator == null)
                return;
            _Acq.Operator.OwnedExposureParams.Exposure = _Exposure;
        }

        /// <summary>
        /// 设置增益
        /// </summary>
        public void SetGain()
        {
            if (_Acq.Operator == null)
                return;
            _Acq.Operator.OwnedBrightnessParams.Brightness = _Gain;
        }

        /// <summary>
        /// 设置对比度
        /// </summary>
        public void SetContrast()
        {
            if (_Acq.Operator == null)
                return;
            _Acq.Operator.OwnedContrastParams.Contrast = _Contrast;
        }

        /// <summary>
        /// 设置硬件触发
        /// </summary>
        public void SetTriggerAuto()
        {
            if (_Acq.Operator == null)
                return;
            _Acq.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
            _Acq.Operator.Complete += new CogCompleteEventHandler(Operator_Complete);
            _Acq.Operator.OwnedTriggerParams.TriggerEnabled = true;
        }

        /// <summary>
        /// 设置软触发
        /// </summary>
        public void SetTriggerManual()
        {
            if (_Acq.Operator == null)
                return;
            _Acq.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Manual;
            _Acq.Operator.Complete -= new CogCompleteEventHandler(Operator_Complete);
            _Acq.Operator.OwnedTriggerParams.TriggerEnabled = false;
        }

        /// <summary>
        /// 释放所有相机
        /// </summary>
        public static void DisconnectAllCams()
        {
            try
            {
                CogFrameGrabbers frameGrabber = new CogFrameGrabbers();
                foreach (ICogFrameGrabber fg in frameGrabber)
                {
                    fg.Disconnect(false);
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
