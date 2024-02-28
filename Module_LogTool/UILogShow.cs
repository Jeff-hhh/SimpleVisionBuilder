using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Module_LogTool
{
    public partial class UILogShow : UserControl
    {
        public UILogShow()
        {
            InitializeComponent();

            _UILogShow = this;
        }

        static UILogShow _UILogShow;

        public static object _lock = new object();

        /// <summary>
        /// 日志显示
        /// </summary>
        /// <param name="strMsgType">消息类型</param>
        /// <param name="imageIndex">图标</param>
        /// <param name="info">日志内容</param>
        public static void PrintLog(string strMsgType, int imageIndex, string info)
        {
            lock (_lock)
            {
                if (_UILogShow.lsv_Log.InvokeRequired)
                {
                    _UILogShow.lsv_Log.Invoke(new Action(() =>
                    {
                        //只显示最新的100行数据
                        if (_UILogShow.lsv_Log.Items.Count > 100)
                        {
                            _UILogShow.lsv_Log.Items.RemoveAt(100);
                        }

                        ListViewItem lstItem = new ListViewItem("" + strMsgType, imageIndex);
                        lstItem.SubItems.Add(DateTime.Now.ToLongTimeString().ToString());
                        lstItem.SubItems.Add(info);
                        if (imageIndex == 3)
                        {
                            lstItem.BackColor = Color.FromArgb(255, 192, 192);
                        }
                        _UILogShow.lsv_Log.Items.Insert(0, lstItem);

                        _UILogShow.lsv_Log.TopItem = _UILogShow.lsv_Log.Items[0];//滚动条置顶
                    }));
                }
                else
                {
                    if (_UILogShow.lsv_Log.Items.Count > 100)
                    {
                        _UILogShow.lsv_Log.Items.RemoveAt(100);

                        _UILogShow.lsv_Log.TopItem = _UILogShow.lsv_Log.Items[0];//滚动条置顶
                    }

                    ListViewItem lstItem = new ListViewItem("" + strMsgType, imageIndex);
                    lstItem.SubItems.Add(DateTime.Now.ToLongTimeString().ToString());
                    lstItem.SubItems.Add(info);
                    if (imageIndex == 3)
                    {
                        lstItem.BackColor = Color.FromArgb(255, 192, 192);
                    }
                    _UILogShow.lsv_Log.Items.Insert(0, lstItem);
                }
            }
        }

        private void btn_LogClear_Click(object sender, EventArgs e)
        {
            lsv_Log.Items.Clear();
        }

        private void UILogShow_SizeChanged(object sender, EventArgs e)
        {
            lsv_Log.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_CopyData_Click(object sender, EventArgs e)
        {
            if (lsv_Log.SelectedItems == null || lsv_Log.SelectedItems.Count <= 0)
            {
                Clipboard.SetDataObject("");
                return;
            }

            var col = lsv_Log.Columns.Count;
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem selectedItem in lsv_Log.SelectedItems)
            {
                if (selectedItem.Text != "")
                {
                    for (int i = 0; i < col; i++)
                    {
                        sb.Append(selectedItem.SubItems[i].Text);
                        if (i == col - 1)
                        {
                            sb.Append("\r\n");
                        }
                    }
                }
            }

            Clipboard.SetDataObject(sb.ToString());
        }

        private void btn_ShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsv_Log.SelectedItems == null || lsv_Log.SelectedItems.Count <= 0)
                {
                    Clipboard.SetDataObject("");
                    return;
                }

                var col = lsv_Log.Columns.Count;
                StringBuilder sb = new StringBuilder();

                foreach (ListViewItem selectedItem in lsv_Log.SelectedItems)
                {
                    if (selectedItem.Text != "")
                    {
                        for (int i = 0; i < col; i++)
                        {
                            sb.Append(selectedItem.SubItems[i].Text);
                            if (i == col - 1)
                            {
                                sb.Append("\r\n");
                            }
                        }
                    }
                }

                FormDetails formDetails = new FormDetails(sb.ToString());
                formDetails.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void lsv_Log_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

            if (e.Item.Selected)
            {
                //SolidBrush brush = new SolidBrush(Color.FromArgb(204, 213, 240));
                SolidBrush brush = new SolidBrush(SystemColors.Highlight);
                e.Graphics.FillRectangle(brush, e.Bounds);    //选择后的颜色

            }
            else
            {
                if (e.ItemIndex % 2 == 0)
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);     //间隔色
                else
                    e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
            }

            e.DrawText();
        }

        private void lsv_Log_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.SubItem.BackColor = e.SubItem.BackColor;
        }
    }
}
