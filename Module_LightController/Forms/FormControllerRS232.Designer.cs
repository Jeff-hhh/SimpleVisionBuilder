
namespace Module_LightController
{
    partial class FormControllerRS232
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.cmb_StopBits = new System.Windows.Forms.ComboBox();
            this.cmb_DataBits = new System.Windows.Forms.ComboBox();
            this.cmb_Parity = new System.Windows.Forms.ComboBox();
            this.cmb_BuadRate = new System.Windows.Forms.ComboBox();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nValue_CH4 = new System.Windows.Forms.NumericUpDown();
            this.nValue_CH3 = new System.Windows.Forms.NumericUpDown();
            this.nValue_CH2 = new System.Windows.Forms.NumericUpDown();
            this.nValue_CH1 = new System.Windows.Forms.NumericUpDown();
            this.tbar_CH1 = new System.Windows.Forms.TrackBar();
            this.tbar_CH2 = new System.Windows.Forms.TrackBar();
            this.tbar_CH3 = new System.Windows.Forms.TrackBar();
            this.tbar_CH4 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 35);
            this.panel6.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digital Control RS232";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 415);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Open);
            this.panel1.Controls.Add(this.cmb_StopBits);
            this.panel1.Controls.Add(this.cmb_DataBits);
            this.panel1.Controls.Add(this.cmb_Parity);
            this.panel1.Controls.Add(this.cmb_BuadRate);
            this.panel1.Controls.Add(this.cmb_PortName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 413);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.Location = new System.Drawing.Point(186, 293);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(120, 35);
            this.btn_Close.TabIndex = 124;
            this.btn_Close.Text = "Close";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Transparent;
            this.btn_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Open.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Open.Location = new System.Drawing.Point(49, 293);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(120, 35);
            this.btn_Open.TabIndex = 123;
            this.btn_Open.Text = "Open";
            this.btn_Open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // cmb_StopBits
            // 
            this.cmb_StopBits.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_StopBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_StopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StopBits.FormattingEnabled = true;
            this.cmb_StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmb_StopBits.Location = new System.Drawing.Point(171, 217);
            this.cmb_StopBits.Name = "cmb_StopBits";
            this.cmb_StopBits.Size = new System.Drawing.Size(135, 25);
            this.cmb_StopBits.TabIndex = 37;
            this.cmb_StopBits.SelectedIndexChanged += new System.EventHandler(this.cmb_StopBits_SelectedIndexChanged);
            // 
            // cmb_DataBits
            // 
            this.cmb_DataBits.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_DataBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_DataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DataBits.FormattingEnabled = true;
            this.cmb_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmb_DataBits.Location = new System.Drawing.Point(171, 170);
            this.cmb_DataBits.Name = "cmb_DataBits";
            this.cmb_DataBits.Size = new System.Drawing.Size(135, 25);
            this.cmb_DataBits.TabIndex = 36;
            this.cmb_DataBits.SelectedIndexChanged += new System.EventHandler(this.cmb_DataBits_SelectedIndexChanged);
            // 
            // cmb_Parity
            // 
            this.cmb_Parity.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_Parity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Parity.FormattingEnabled = true;
            this.cmb_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cmb_Parity.Location = new System.Drawing.Point(171, 123);
            this.cmb_Parity.Name = "cmb_Parity";
            this.cmb_Parity.Size = new System.Drawing.Size(135, 25);
            this.cmb_Parity.TabIndex = 35;
            this.cmb_Parity.SelectedIndexChanged += new System.EventHandler(this.cmb_Parity_SelectedIndexChanged);
            // 
            // cmb_BuadRate
            // 
            this.cmb_BuadRate.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_BuadRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_BuadRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BuadRate.FormattingEnabled = true;
            this.cmb_BuadRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cmb_BuadRate.Location = new System.Drawing.Point(171, 76);
            this.cmb_BuadRate.Name = "cmb_BuadRate";
            this.cmb_BuadRate.Size = new System.Drawing.Size(135, 25);
            this.cmb_BuadRate.TabIndex = 34;
            this.cmb_BuadRate.SelectedIndexChanged += new System.EventHandler(this.cmb_BuadRate_SelectedIndexChanged);
            // 
            // cmb_PortName
            // 
            this.cmb_PortName.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_PortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_PortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PortName.FormattingEnabled = true;
            this.cmb_PortName.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7",
            "Com8"});
            this.cmb_PortName.Location = new System.Drawing.Point(171, 27);
            this.cmb_PortName.Name = "cmb_PortName";
            this.cmb_PortName.Size = new System.Drawing.Size(135, 25);
            this.cmb_PortName.TabIndex = 33;
            this.cmb_PortName.SelectedIndexChanged += new System.EventHandler(this.cmb_PortNum_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(66, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "StopBits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(62, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "DataBits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(80, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(47, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "BuadRate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(45, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "PortName";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nValue_CH4);
            this.panel2.Controls.Add(this.nValue_CH3);
            this.panel2.Controls.Add(this.nValue_CH2);
            this.panel2.Controls.Add(this.nValue_CH1);
            this.panel2.Controls.Add(this.tbar_CH1);
            this.panel2.Controls.Add(this.tbar_CH2);
            this.panel2.Controls.Add(this.tbar_CH3);
            this.panel2.Controls.Add(this.tbar_CH4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(352, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 413);
            this.panel2.TabIndex = 1;
            // 
            // nValue_CH4
            // 
            this.nValue_CH4.BackColor = System.Drawing.Color.LightCyan;
            this.nValue_CH4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nValue_CH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nValue_CH4.Location = new System.Drawing.Point(298, 256);
            this.nValue_CH4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nValue_CH4.Name = "nValue_CH4";
            this.nValue_CH4.Size = new System.Drawing.Size(49, 22);
            this.nValue_CH4.TabIndex = 27;
            this.nValue_CH4.ValueChanged += new System.EventHandler(this.nValue_CH4_ValueChanged);
            // 
            // nValue_CH3
            // 
            this.nValue_CH3.BackColor = System.Drawing.Color.LightCyan;
            this.nValue_CH3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nValue_CH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nValue_CH3.Location = new System.Drawing.Point(298, 173);
            this.nValue_CH3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nValue_CH3.Name = "nValue_CH3";
            this.nValue_CH3.Size = new System.Drawing.Size(49, 22);
            this.nValue_CH3.TabIndex = 26;
            this.nValue_CH3.ValueChanged += new System.EventHandler(this.nValue_CH3_ValueChanged);
            // 
            // nValue_CH2
            // 
            this.nValue_CH2.BackColor = System.Drawing.Color.LightCyan;
            this.nValue_CH2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nValue_CH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nValue_CH2.Location = new System.Drawing.Point(298, 102);
            this.nValue_CH2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nValue_CH2.Name = "nValue_CH2";
            this.nValue_CH2.Size = new System.Drawing.Size(49, 22);
            this.nValue_CH2.TabIndex = 25;
            this.nValue_CH2.ValueChanged += new System.EventHandler(this.nValue_CH2_ValueChanged);
            // 
            // nValue_CH1
            // 
            this.nValue_CH1.BackColor = System.Drawing.Color.LightCyan;
            this.nValue_CH1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nValue_CH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nValue_CH1.Location = new System.Drawing.Point(298, 31);
            this.nValue_CH1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nValue_CH1.Name = "nValue_CH1";
            this.nValue_CH1.Size = new System.Drawing.Size(49, 22);
            this.nValue_CH1.TabIndex = 24;
            this.nValue_CH1.ValueChanged += new System.EventHandler(this.nValue_CH1_ValueChanged);
            // 
            // tbar_CH1
            // 
            this.tbar_CH1.Location = new System.Drawing.Point(42, 31);
            this.tbar_CH1.Maximum = 255;
            this.tbar_CH1.Name = "tbar_CH1";
            this.tbar_CH1.Size = new System.Drawing.Size(255, 45);
            this.tbar_CH1.TabIndex = 16;
            this.tbar_CH1.Scroll += new System.EventHandler(this.tbar_CH1_Scroll);
            // 
            // tbar_CH2
            // 
            this.tbar_CH2.Location = new System.Drawing.Point(42, 102);
            this.tbar_CH2.Maximum = 255;
            this.tbar_CH2.Name = "tbar_CH2";
            this.tbar_CH2.Size = new System.Drawing.Size(255, 45);
            this.tbar_CH2.TabIndex = 17;
            this.tbar_CH2.Scroll += new System.EventHandler(this.tbar_CH2_Scroll);
            // 
            // tbar_CH3
            // 
            this.tbar_CH3.Location = new System.Drawing.Point(42, 173);
            this.tbar_CH3.Maximum = 255;
            this.tbar_CH3.Name = "tbar_CH3";
            this.tbar_CH3.Size = new System.Drawing.Size(255, 45);
            this.tbar_CH3.TabIndex = 18;
            this.tbar_CH3.Scroll += new System.EventHandler(this.tbar_CH3_Scroll);
            // 
            // tbar_CH4
            // 
            this.tbar_CH4.Location = new System.Drawing.Point(42, 256);
            this.tbar_CH4.Maximum = 255;
            this.tbar_CH4.Name = "tbar_CH4";
            this.tbar_CH4.Size = new System.Drawing.Size(255, 45);
            this.tbar_CH4.TabIndex = 19;
            this.tbar_CH4.Scroll += new System.EventHandler(this.tbar_CH4_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CH1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "CH2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(3, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "CH4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "CH3";
            // 
            // FormControllerRS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControllerRS232";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormControllerUI_Load);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_CH4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbar_CH1;
        private System.Windows.Forms.TrackBar tbar_CH2;
        private System.Windows.Forms.TrackBar tbar_CH3;
        private System.Windows.Forms.TrackBar tbar_CH4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_DataBits;
        private System.Windows.Forms.ComboBox cmb_Parity;
        private System.Windows.Forms.ComboBox cmb_BuadRate;
        private System.Windows.Forms.ComboBox cmb_PortName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Open;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown nValue_CH4;
        private System.Windows.Forms.NumericUpDown nValue_CH3;
        private System.Windows.Forms.NumericUpDown nValue_CH2;
        private System.Windows.Forms.NumericUpDown nValue_CH1;
        private System.Windows.Forms.ComboBox cmb_StopBits;
        private System.Windows.Forms.Button btn_Close;
    }
}

