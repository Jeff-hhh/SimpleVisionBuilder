﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Module_LogTool
{
    public partial class FormDetails : Form
    {
        public FormDetails(string msg)
        {
            InitializeComponent();
            txt_DetailsMsg.Text = msg;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetails_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(this);
        }


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// 重绘窗体移动缩放
        /// </summary>
        /// <param name="cons">窗体实例</param>
        public static void MoveForm(Control cons)
        {
            ReleaseCapture();
            SendMessage(cons.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            this.txt_DetailsMsg.TabStop = false;
        }
    }
}