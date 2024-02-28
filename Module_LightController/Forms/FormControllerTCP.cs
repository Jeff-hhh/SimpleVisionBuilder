using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Module_LightController
{
    public partial class FormControllerTCP : Form
    {
        public FormControllerTCP()
        {
            InitializeComponent();
        }

        private void tbar_CH1_Scroll(object sender, EventArgs e)
        {
            nValue_CH1.Value = tbar_CH1.Value;
        }

        private void tbar_CH2_Scroll(object sender, EventArgs e)
        {
            nValue_CH2.Value = tbar_CH2.Value;
        }

        private void tbar_CH3_Scroll(object sender, EventArgs e)
        {
            nValue_CH3.Value = tbar_CH3.Value;
        }

        private void tbar_CH4_Scroll(object sender, EventArgs e)
        {
            nValue_CH4.Value = tbar_CH4.Value;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {

        }
    }
}
