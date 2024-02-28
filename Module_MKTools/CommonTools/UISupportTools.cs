using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

/// <summary>
/// 个人工具封装
/// </summary>
namespace Module_MKTools
{ 
    /// <summary>
    /// Winform的UI界面优化方法
    /// </summary>
    public class UISupportTools
    {

        #region [重绘窗体移动缩放]

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

        #endregion


        #region [MDI设计]

        public static void ShowMaxDisplay(Form fm)
        {
            Form _ParentForm = new Form();
            _ParentForm.FormBorderStyle = FormBorderStyle.None;
            _ParentForm.IsMdiContainer = true;
            fm.MdiParent = _ParentForm;
            _ParentForm.ShowInTaskbar = false;
            _ParentForm.WindowState = FormWindowState.Maximized;
            _ParentForm.Show();
        }

        public static void ShowDisplay(Panel pl, Form fm)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (Control item in pl.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Close();
                }
            }
            fm.TopLevel = false;
            fm.Parent = pl;
            fm.Dock = DockStyle.Fill;
            fm.Padding = new Padding(0);
            fm.Show();
            fm.Activate();
            Cursor.Current = Cursors.Arrow;
        }

        /// <summary>
        /// 隐藏其它面板，显示切换面板
        /// </summary>
        /// <param name="pl">父容器</param>
        /// <param name="fm">要显示的窗体面板</param>
        /// <param name="isHide">默认为Hide()</param>
        public static void ShowDisplay(Panel pl, Form fm, bool isHide = true)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (Control item in pl.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Hide();
                }
            }
            fm.TopLevel = false;
            fm.Parent = pl;
            fm.Dock = DockStyle.Fill;
            fm.Padding = new Padding(0);
            fm.Show();
            fm.Activate();
            Cursor.Current = Cursors.Arrow;
        }

        /// <summary>
        /// MDI设计模式
        /// </summary>
        /// <param name="pl">显示子窗体的Panel容器</param>
        /// <param name="fm">子窗体实例</param>
        /// <param name="mainformName"></param>
        public static void ShowDisplay(Panel pl, Form fm, string staticform)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DisposeOtherForms(pl);
                fm.TopLevel = false;
                fm.Parent = pl;
                fm.Show();
                fm.Padding = new Padding(0);
                fm.Dock = DockStyle.Fill;

                fm.Activate();
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 隐藏多余子窗体
        /// </summary>
        public static void DisposeOtherForms(Panel pl)
        {
            foreach (Control item in pl.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Hide();
                }
            }
        }

        public static void DisposeOtherForms(Panel pl, string staticform)
        {
            foreach (Control item in pl.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Hide();
                    if (objForm.Name == staticform)
                    {
                        objForm.Hide();
                    }
                    else
                    {
                        objForm.Close();
                    }
                }
            }
        }

        #endregion


        #region [TableControl重绘]

        /// <summary>
        /// TableControl重绘V1
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void TabFocus(TabControl tb, object sender, DrawItemEventArgs e)
        {
            string text = ((TabControl)sender).TabPages[e.Index].Text;

            //标签背景填充颜色
            SolidBrush BackBrush = new SolidBrush(Color.FromArgb(234, 234, 235));
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            //设置文字对齐方式
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            if (e.Index == tb.SelectedIndex)//当前Tab页的样式
            {
                BackBrush = new SolidBrush(Color.FromArgb(45, 140, 230));
                brush = new SolidBrush(Color.White);
            }

            //绘制标签头背景颜色
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            //绘制标签头文字
            e.Graphics.DrawString(text, new Font("微软雅黑", 14), brush, e.Bounds, sf);
        }

        /// <summary>
        /// TableControl重绘V2
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DesignTab(TabControl tb, object sender, DrawItemEventArgs e)
        {

            Graphics g = e.Graphics;

            TabPage changedpage = tb.TabPages[e.Index];//当前处理标签
            Rectangle backrect = tb.GetTabRect(e.Index);//标签背景区域
            Brush backbrush;//标签背景色
            Brush fontbrush;//标签字体颜色
            Font tabFont;//标签字体
            Pen borderpen;//边框颜色

            //TabControl绘制
            Brush backtabcontrol = new SolidBrush(Color.FromArgb(45, 140, 230));
            g.FillRectangle(backtabcontrol, tb.ClientRectangle.X + 70, tb.ClientRectangle.Y, tb.ClientRectangle.Size.Width, tb.ItemSize.Height);
            backtabcontrol.Dispose();

            if (e.State == DrawItemState.Selected)
            {
                backbrush = new SolidBrush(Color.Black);
                fontbrush = new SolidBrush(Color.Yellow);
                tabFont = new Font("微软雅黑", 12, FontStyle.Bold, GraphicsUnit.Pixel);
                borderpen = new Pen(Color.LightBlue);
            }
            else
            {
                backbrush = new SolidBrush(Color.White);
                fontbrush = new SolidBrush(Color.Red);
                tabFont = new Font("微软雅黑", 12, FontStyle.Bold, GraphicsUnit.Pixel);
                borderpen = new Pen(Color.DarkGreen);
            }
            //绘制标签背景
            g.FillRectangle(backbrush, backrect);

            //绘制标签字体
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(changedpage.Text, tabFont, fontbrush, backrect, new StringFormat(_StringFlags));
            //绘制非标签原始名称【可依据e.State修改】 g.DrawString("呵呵", tabFont, fontbrush, backrect, new StringFormat(_StringFlags));

            //绘制标签边框
            //backrect.Offset(1, 1);
            //backrect.Inflate(2, 2);
            g.DrawRectangle(borderpen, backrect);

            backbrush.Dispose();
            tabFont.Dispose();
            fontbrush.Dispose();
            borderpen.Dispose();
        }

        #endregion


        #region [保持控件字体颜色--DIY菜单]

        /// <summary>
        /// 保持控件颜色--DIY菜单
        /// </summary>
        /// <param name="btn">菜单按钮</param>
        /// <param name="control">按钮所在容器控件</param>
        /// <param name="normalcolor">未选中控件颜色</param>
        /// <param name="selectedcolor">选中后控件颜色</param>
        public static void KeepButtonColor(Button btn, Control control, Color normalcolor, Color selectedcolor)
        {
            foreach (Control item in control.Controls)
            {
                if (item.Name == btn.Name)
                    item.BackColor = selectedcolor;
                else
                    item.BackColor = normalcolor;
            }
        }

        /// <summary>
        /// 保持选中控件的字体颜色
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="control"></param>
        public static void KeepButtonFondSize(Button btn, Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item.Name == btn.Name)
                {
                    if (!item.Font.Bold)
                    {
                        item.Font = new Font(item.Font.Name, item.Font.Size, FontStyle.Bold);
                        ((Button)item).BackColor = Color.Azure;// Color.FromArgb(80, 80, 80);
                        ((Button)item).Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
                    }
                }
                else
                {
                    if (item is Button)
                    {
                        item.Font = new Font(item.Font.Name, item.Font.Size, FontStyle.Regular);
                        ((Button)item).BackColor = Color.Azure;// Color.FromArgb(80, 80, 80);
                        ((Button)item).Margin = new System.Windows.Forms.Padding(0);
                    }
                }
            }
        }

        #endregion


        #region [双击放大显示] 

        /// <summary>
        /// 双击放大显示,基于TableLayoutPanel控件
        /// </summary>
        /// <param name="MainControl">父窗体</param>
        /// <param name="SubControl">TableLayoutPanel网格显示次级控件</param>
        /// <param name="DisplayControl"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public static void ShowMax<T>(Control MainControl, TableLayoutPanel SubControl, T DisplayControl, int row, int col) where T : System.Windows.Forms.Control
        {
            try
            {
                if (DisplayControl.Parent == SubControl)
                {
                    SubControl.Hide();
                    DisplayControl.Parent = MainControl;
                    DisplayControl.Dock = DockStyle.Fill;
                }
                else
                {
                    DisplayControl.Parent = SubControl;
                    SubControl.SetRow(DisplayControl, row);
                    SubControl.SetColumn(DisplayControl, col);
                    SubControl.Show();
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion


        #region [splitContainer显示切换]

        /// <summary>
        /// splitContainer显示切换
        /// </summary>
        /// <param name="splitContainer">splitContainer容器</param>
        /// <param name="showItem">显示选项(0:全部显示; 1：显示Panel1; 2:显示Panel2)</param>
        public static void HidePanel(SplitContainer splitContainer, int showItem)
        {
            switch (showItem)
            {
                case 0:
                    splitContainer.Panel1Collapsed = false;
                    splitContainer.Panel2Collapsed = false;
                    break;
                case 1:
                    splitContainer.Panel1Collapsed = true;
                    splitContainer.Panel2Collapsed = false;
                    break;
                case 2:
                    splitContainer.Panel2Collapsed = true;
                    splitContainer.Panel1Collapsed = false;
                    break;
                default:
                    break;
            }
        }

        #endregion


        #region [控件圆倒角]

        /// <summary>
        /// 设置控件圆倒角
        /// </summary>
        /// <param name="sender">控件实例</param>
        /// <param name="p_1">35为佳</param>
        /// <param name="p_2">默认0.1</param>
        public static void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(new Point[] { new Point(0, sender.Height / p_1), new Point(sender.Width / p_1, 0), new Point(sender.Width - sender.Width / p_1, 0), new Point(sender.Width, sender.Height / p_1), new Point(sender.Width, sender.Height - sender.Height / p_1), new Point(sender.Width - sender.Width / p_1, sender.Height), new Point(sender.Width / p_1, sender.Height), new Point(0, sender.Height - sender.Height / p_1) }, (float)p_2);
            sender.Region = new Region(oPath);
        }

        #endregion


        #region [Listview复制数据到剪切板]

        public static void CopyData(ListView listView)
        {
            var strList = new List<string>();

            if (listView.SelectedItems == null || listView.SelectedItems.Count <= 0)
            {

                Clipboard.SetDataObject(strList);
            }

            var selectedItems = listView.SelectedItems;

            foreach (var selectedItem in selectedItems)
            {
                var item = (ListViewItem)selectedItem;
                strList.Add(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," +
                item.SubItems[2].Text);
            }

            Clipboard.SetDataObject(strList);
        }

        #endregion


    }
}
