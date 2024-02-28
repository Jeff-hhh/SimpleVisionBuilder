
namespace Module_LogTool
{
    partial class UILogShow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILogShow));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_LogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CopyData = new System.Windows.Forms.ToolStripMenuItem();
            this.imglst_Log = new System.Windows.Forms.ImageList(this.components);
            this.lsv_Log = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_LogClear,
            this.btn_CopyData,
            this.btn_ShowDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // btn_LogClear
            // 
            this.btn_LogClear.Name = "btn_LogClear";
            this.btn_LogClear.Size = new System.Drawing.Size(180, 22);
            this.btn_LogClear.Text = "清空";
            this.btn_LogClear.Click += new System.EventHandler(this.btn_LogClear_Click);
            // 
            // btn_CopyData
            // 
            this.btn_CopyData.Name = "btn_CopyData";
            this.btn_CopyData.Size = new System.Drawing.Size(180, 22);
            this.btn_CopyData.Text = "复制";
            this.btn_CopyData.Click += new System.EventHandler(this.btn_CopyData_Click);
            // 
            // imglst_Log
            // 
            this.imglst_Log.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_Log.ImageStream")));
            this.imglst_Log.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_Log.Images.SetKeyName(0, "Info.png");
            this.imglst_Log.Images.SetKeyName(1, "Warning.png");
            this.imglst_Log.Images.SetKeyName(2, "Tip.png");
            this.imglst_Log.Images.SetKeyName(3, "Error.png");
            // 
            // lsv_Log
            // 
            this.lsv_Log.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_Log.BackColor = System.Drawing.Color.White;
            this.lsv_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsv_Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsv_Log.ContextMenuStrip = this.contextMenuStrip1;
            this.lsv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_Log.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsv_Log.FullRowSelect = true;
            this.lsv_Log.GridLines = true;
            this.lsv_Log.HideSelection = false;
            this.lsv_Log.Location = new System.Drawing.Point(0, 0);
            this.lsv_Log.Margin = new System.Windows.Forms.Padding(0);
            this.lsv_Log.Name = "lsv_Log";
            this.lsv_Log.Size = new System.Drawing.Size(700, 450);
            this.lsv_Log.SmallImageList = this.imglst_Log;
            this.lsv_Log.TabIndex = 66;
            this.lsv_Log.UseCompatibleStateImageBehavior = false;
            this.lsv_Log.View = System.Windows.Forms.View.Details;
            this.lsv_Log.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsv_Log_DrawItem);
            this.lsv_Log.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lsv_Log_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时间";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "运行信息";
            this.columnHeader3.Width = 1000;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btn_ShowDetails
            // 
            this.btn_ShowDetails.Name = "btn_ShowDetails";
            this.btn_ShowDetails.Size = new System.Drawing.Size(180, 22);
            this.btn_ShowDetails.Text = "详细";
            this.btn_ShowDetails.Click += new System.EventHandler(this.btn_ShowDetails_Click);
            // 
            // UILogShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lsv_Log);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UILogShow";
            this.Size = new System.Drawing.Size(700, 450);
            this.SizeChanged += new System.EventHandler(this.UILogShow_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_LogClear;
        public System.Windows.Forms.ImageList imglst_Log;
        public System.Windows.Forms.ListView lsv_Log;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem btn_CopyData;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem btn_ShowDetails;
    }
}
