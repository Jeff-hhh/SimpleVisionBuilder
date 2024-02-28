using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_LightController.Properties;

namespace Module_LightController
{
    public partial class LightCommStatus : UserControl
    {
        public LightCommStatus()
        {
            InitializeComponent();
            Dock = DockStyle.Left;
        }

        public void SetStatus(bool isConnected)
        {
            if (this.pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new Action(() =>
                {
                    if (isConnected)
                        pictureBox1.Image = Resources.OK;
                    else
                        pictureBox1.Image = Resources.NG;
                }));
            }
            else
            {
                if (isConnected)
                    pictureBox1.Image = Resources.OK;
                else
                    pictureBox1.Image = Resources.NG;
            }
        }

        public void SetToopTip(string tooltips)
        {
            toolTip1.SetToolTip(pictureBox1, tooltips);
        }
    }
}
