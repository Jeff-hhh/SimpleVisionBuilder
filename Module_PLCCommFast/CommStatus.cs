using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_PLCCommFast.Properties;

namespace Module_PLCCommFast
{
    public partial class UCommStatus : UserControl
    {
        public UCommStatus()
        {
            InitializeComponent();
            Dock = DockStyle.Left;
        }

        public void SetStatus(EnumCommStatus enumCommStatus)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    switch (enumCommStatus)
                    {
                        case EnumCommStatus.Opened:
                            pictureBox1.Image = Resources.OK;
                            break;
                        case EnumCommStatus.Closed:
                            pictureBox1.Image = Resources.NG;
                            break;
                        case EnumCommStatus.Waiting:
                            pictureBox1.Image = Resources.Wait;
                            break;
                        default:
                            pictureBox1.Image = Resources.Disabled;
                            break;
                    }                
                }));
            }
            else
            {
                switch (enumCommStatus)
                {
                    case EnumCommStatus.Opened:
                        pictureBox1.Image = Resources.OK;
                        break;
                    case EnumCommStatus.Closed:
                        pictureBox1.Image = Resources.NG;
                        break;
                    case EnumCommStatus.Waiting:
                        pictureBox1.Image = Resources.Wait;
                        break;
                    default:
                        pictureBox1.Image = Resources.Disabled;
                        break;
                }
            }
        }

        public void SetToopTip(string tooltips)
        {
            toolTip1.SetToolTip(pictureBox1, tooltips);
        }

        int _Index;
        int _Row;
        int _Col;

        /// <summary>
        /// 显示框序列索引号
        /// </summary>
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        /// <summary>
        /// 显示框所在TableLayoutPanel的列号
        /// </summary>
        public int Col
        {
            get { return _Col; }
            set { _Col = value; }
        }

        /// <summary>
        ///  显示框所在TableLayoutPanel的行号
        /// </summary>
        public int Row
        {
            get { return _Row; }
            set { _Row = value; }
        }
    }

    public enum EnumCommStatus
    {
        /// <summary>
        /// 通讯已连接
        /// </summary>
        Opened,
        /// <summary>
        /// 通讯已断开
        /// </summary>
        Closed,
        /// <summary>
        /// 通讯等待--用于服务器
        /// </summary>
        Waiting

    }
}
