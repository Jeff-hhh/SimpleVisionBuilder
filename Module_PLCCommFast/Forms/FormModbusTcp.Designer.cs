
namespace Module_PLCCommFast
{
    partial class FormModbusTcp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_DataFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_WriteString = new System.Windows.Forms.Button();
            this.txt_WriteStringLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_WriteFloat = new System.Windows.Forms.Button();
            this.btn_WriteBool = new System.Windows.Forms.Button();
            this.btn_WriteInt = new System.Windows.Forms.Button();
            this.btn_WriteShort = new System.Windows.Forms.Button();
            this.txt_WriteValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_WriteAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ReadString = new System.Windows.Forms.Button();
            this.txt_ReadStringLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ReadFloat = new System.Windows.Forms.Button();
            this.btn_ReadBool = new System.Windows.Forms.Button();
            this.btn_ReadInt = new System.Windows.Forms.Button();
            this.btn_ReadShort = new System.Windows.Forms.Button();
            this.txt_ReadResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ReadAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 565);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 565);
            this.panel3.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Save);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_DataFormat);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Close);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Open);
            this.splitContainer1.Panel1.Controls.Add(this.txt_IP);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Port);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(700, 565);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.Location = new System.Drawing.Point(519, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 25);
            this.btn_Save.TabIndex = 120;
            this.btn_Save.Text = "设定";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_DataFormat
            // 
            this.cmb_DataFormat.BackColor = System.Drawing.Color.LightCyan;
            this.cmb_DataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DataFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_DataFormat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DataFormat.FormattingEnabled = true;
            this.cmb_DataFormat.Items.AddRange(new object[] {
            "ABCD",
            "BADC",
            "CDAB",
            "DCBA"});
            this.cmb_DataFormat.Location = new System.Drawing.Point(335, 25);
            this.cmb_DataFormat.Name = "cmb_DataFormat";
            this.cmb_DataFormat.Size = new System.Drawing.Size(170, 29);
            this.cmb_DataFormat.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(255, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 118;
            this.label4.Text = "解析格式";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.Location = new System.Drawing.Point(519, 74);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(80, 25);
            this.btn_Close.TabIndex = 117;
            this.btn_Close.Text = "断开";
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
            this.btn_Open.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Open.Location = new System.Drawing.Point(519, 43);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(80, 25);
            this.btn_Open.TabIndex = 116;
            this.btn_Open.Text = "连接";
            this.btn_Open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.Color.LightCyan;
            this.txt_IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.Location = new System.Drawing.Point(68, 25);
            this.txt_IP.Multiline = true;
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(160, 28);
            this.txt_IP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txt_Port
            // 
            this.txt_Port.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Port.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port.Location = new System.Drawing.Point(68, 59);
            this.txt_Port.Multiline = true;
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(160, 28);
            this.txt_Port.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 448F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_WriteString);
            this.panel5.Controls.Add(this.txt_WriteStringLength);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btn_WriteFloat);
            this.panel5.Controls.Add(this.btn_WriteBool);
            this.panel5.Controls.Add(this.btn_WriteInt);
            this.panel5.Controls.Add(this.btn_WriteShort);
            this.panel5.Controls.Add(this.txt_WriteValue);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txt_WriteAddress);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(349, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 447);
            this.panel5.TabIndex = 1;
            // 
            // btn_WriteString
            // 
            this.btn_WriteString.BackColor = System.Drawing.Color.White;
            this.btn_WriteString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteString.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_WriteString.Location = new System.Drawing.Point(251, 337);
            this.btn_WriteString.Name = "btn_WriteString";
            this.btn_WriteString.Size = new System.Drawing.Size(80, 25);
            this.btn_WriteString.TabIndex = 38;
            this.btn_WriteString.Text = "字符串写入";
            this.btn_WriteString.UseVisualStyleBackColor = false;
            this.btn_WriteString.Click += new System.EventHandler(this.btn_WriteString_Click);
            // 
            // txt_WriteStringLength
            // 
            this.txt_WriteStringLength.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WriteStringLength.Location = new System.Drawing.Point(163, 336);
            this.txt_WriteStringLength.Name = "txt_WriteStringLength";
            this.txt_WriteStringLength.Size = new System.Drawing.Size(60, 25);
            this.txt_WriteStringLength.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(115, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "长度";
            // 
            // btn_WriteFloat
            // 
            this.btn_WriteFloat.BackColor = System.Drawing.Color.White;
            this.btn_WriteFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteFloat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteFloat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_WriteFloat.Location = new System.Drawing.Point(251, 232);
            this.btn_WriteFloat.Name = "btn_WriteFloat";
            this.btn_WriteFloat.Size = new System.Drawing.Size(80, 25);
            this.btn_WriteFloat.TabIndex = 35;
            this.btn_WriteFloat.Text = "Float写入";
            this.btn_WriteFloat.UseVisualStyleBackColor = false;
            this.btn_WriteFloat.Click += new System.EventHandler(this.btn_WriteFloat_Click);
            // 
            // btn_WriteBool
            // 
            this.btn_WriteBool.BackColor = System.Drawing.Color.White;
            this.btn_WriteBool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteBool.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteBool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_WriteBool.Location = new System.Drawing.Point(251, 182);
            this.btn_WriteBool.Name = "btn_WriteBool";
            this.btn_WriteBool.Size = new System.Drawing.Size(80, 25);
            this.btn_WriteBool.TabIndex = 34;
            this.btn_WriteBool.Text = "Bool写入";
            this.btn_WriteBool.UseVisualStyleBackColor = false;
            this.btn_WriteBool.Click += new System.EventHandler(this.btn_WriteBool_Click);
            // 
            // btn_WriteInt
            // 
            this.btn_WriteInt.BackColor = System.Drawing.Color.White;
            this.btn_WriteInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteInt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_WriteInt.Location = new System.Drawing.Point(251, 132);
            this.btn_WriteInt.Name = "btn_WriteInt";
            this.btn_WriteInt.Size = new System.Drawing.Size(80, 25);
            this.btn_WriteInt.TabIndex = 33;
            this.btn_WriteInt.Text = "Int写入";
            this.btn_WriteInt.UseVisualStyleBackColor = false;
            this.btn_WriteInt.Click += new System.EventHandler(this.btn_WriteInt_Click);
            // 
            // btn_WriteShort
            // 
            this.btn_WriteShort.BackColor = System.Drawing.Color.White;
            this.btn_WriteShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WriteShort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteShort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_WriteShort.Location = new System.Drawing.Point(251, 82);
            this.btn_WriteShort.Name = "btn_WriteShort";
            this.btn_WriteShort.Size = new System.Drawing.Size(80, 25);
            this.btn_WriteShort.TabIndex = 32;
            this.btn_WriteShort.Text = "Short写入";
            this.btn_WriteShort.UseVisualStyleBackColor = false;
            this.btn_WriteShort.Click += new System.EventHandler(this.btn_WriteShort_Click);
            // 
            // txt_WriteValue
            // 
            this.txt_WriteValue.BackColor = System.Drawing.Color.White;
            this.txt_WriteValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_WriteValue.Location = new System.Drawing.Point(53, 132);
            this.txt_WriteValue.Multiline = true;
            this.txt_WriteValue.Name = "txt_WriteValue";
            this.txt_WriteValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_WriteValue.Size = new System.Drawing.Size(170, 193);
            this.txt_WriteValue.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(4, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "值";
            // 
            // txt_WriteAddress
            // 
            this.txt_WriteAddress.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WriteAddress.Location = new System.Drawing.Point(53, 82);
            this.txt_WriteAddress.Name = "txt_WriteAddress";
            this.txt_WriteAddress.Size = new System.Drawing.Size(170, 25);
            this.txt_WriteAddress.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(4, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "地址";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 35);
            this.label9.TabIndex = 27;
            this.label9.Text = "写入测试";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btn_ReadString);
            this.panel4.Controls.Add(this.txt_ReadStringLength);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_ReadFloat);
            this.panel4.Controls.Add(this.btn_ReadBool);
            this.panel4.Controls.Add(this.btn_ReadInt);
            this.panel4.Controls.Add(this.btn_ReadShort);
            this.panel4.Controls.Add(this.txt_ReadResult);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_ReadAddress);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 447);
            this.panel4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(347, 35);
            this.label8.TabIndex = 26;
            this.label8.Text = "读取测试";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ReadString
            // 
            this.btn_ReadString.BackColor = System.Drawing.Color.White;
            this.btn_ReadString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadString.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ReadString.Location = new System.Drawing.Point(250, 337);
            this.btn_ReadString.Name = "btn_ReadString";
            this.btn_ReadString.Size = new System.Drawing.Size(80, 25);
            this.btn_ReadString.TabIndex = 25;
            this.btn_ReadString.Text = "字符串读取";
            this.btn_ReadString.UseVisualStyleBackColor = false;
            this.btn_ReadString.Click += new System.EventHandler(this.btn_ReadString_Click);
            // 
            // txt_ReadStringLength
            // 
            this.txt_ReadStringLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReadStringLength.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadStringLength.Location = new System.Drawing.Point(162, 336);
            this.txt_ReadStringLength.Name = "txt_ReadStringLength";
            this.txt_ReadStringLength.Size = new System.Drawing.Size(60, 25);
            this.txt_ReadStringLength.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "长度";
            // 
            // btn_ReadFloat
            // 
            this.btn_ReadFloat.BackColor = System.Drawing.Color.White;
            this.btn_ReadFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadFloat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadFloat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ReadFloat.Location = new System.Drawing.Point(250, 232);
            this.btn_ReadFloat.Name = "btn_ReadFloat";
            this.btn_ReadFloat.Size = new System.Drawing.Size(80, 25);
            this.btn_ReadFloat.TabIndex = 22;
            this.btn_ReadFloat.Text = "Float读取";
            this.btn_ReadFloat.UseVisualStyleBackColor = false;
            this.btn_ReadFloat.Click += new System.EventHandler(this.btn_ReadFloat_Click);
            // 
            // btn_ReadBool
            // 
            this.btn_ReadBool.BackColor = System.Drawing.Color.White;
            this.btn_ReadBool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadBool.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadBool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ReadBool.Location = new System.Drawing.Point(250, 182);
            this.btn_ReadBool.Name = "btn_ReadBool";
            this.btn_ReadBool.Size = new System.Drawing.Size(80, 25);
            this.btn_ReadBool.TabIndex = 21;
            this.btn_ReadBool.Text = "Bool读取";
            this.btn_ReadBool.UseVisualStyleBackColor = false;
            this.btn_ReadBool.Click += new System.EventHandler(this.btn_ReadBool_Click);
            // 
            // btn_ReadInt
            // 
            this.btn_ReadInt.BackColor = System.Drawing.Color.White;
            this.btn_ReadInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadInt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ReadInt.Location = new System.Drawing.Point(250, 132);
            this.btn_ReadInt.Name = "btn_ReadInt";
            this.btn_ReadInt.Size = new System.Drawing.Size(80, 25);
            this.btn_ReadInt.TabIndex = 20;
            this.btn_ReadInt.Text = "Int读取";
            this.btn_ReadInt.UseVisualStyleBackColor = false;
            this.btn_ReadInt.Click += new System.EventHandler(this.btn_ReadInt_Click);
            // 
            // btn_ReadShort
            // 
            this.btn_ReadShort.BackColor = System.Drawing.Color.White;
            this.btn_ReadShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadShort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadShort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ReadShort.Location = new System.Drawing.Point(250, 82);
            this.btn_ReadShort.Name = "btn_ReadShort";
            this.btn_ReadShort.Size = new System.Drawing.Size(80, 25);
            this.btn_ReadShort.TabIndex = 19;
            this.btn_ReadShort.Text = "Short读取";
            this.btn_ReadShort.UseVisualStyleBackColor = false;
            this.btn_ReadShort.Click += new System.EventHandler(this.btn_ReadShort_Click);
            // 
            // txt_ReadResult
            // 
            this.txt_ReadResult.BackColor = System.Drawing.Color.White;
            this.txt_ReadResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ReadResult.Location = new System.Drawing.Point(52, 132);
            this.txt_ReadResult.Multiline = true;
            this.txt_ReadResult.Name = "txt_ReadResult";
            this.txt_ReadResult.ReadOnly = true;
            this.txt_ReadResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ReadResult.Size = new System.Drawing.Size(170, 190);
            this.txt_ReadResult.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "结果";
            // 
            // txt_ReadAddress
            // 
            this.txt_ReadAddress.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadAddress.Location = new System.Drawing.Point(52, 82);
            this.txt_ReadAddress.Name = "txt_ReadAddress";
            this.txt_ReadAddress.Size = new System.Drawing.Size(170, 25);
            this.txt_ReadAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(4, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "地址";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(700, 35);
            this.panel1.TabIndex = 12;
            // 
            // lb_Title
            // 
            this.lb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.lb_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(1, 0);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(699, 35);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Modbus TCP";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormModbusTcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModbusTcp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModbusTcp";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.ComboBox cmb_DataFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_WriteString;
        private System.Windows.Forms.TextBox txt_WriteStringLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_WriteFloat;
        private System.Windows.Forms.Button btn_WriteBool;
        private System.Windows.Forms.Button btn_WriteInt;
        private System.Windows.Forms.Button btn_WriteShort;
        private System.Windows.Forms.TextBox txt_WriteValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_WriteAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ReadString;
        private System.Windows.Forms.TextBox txt_ReadStringLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ReadFloat;
        private System.Windows.Forms.Button btn_ReadBool;
        private System.Windows.Forms.Button btn_ReadInt;
        private System.Windows.Forms.Button btn_ReadShort;
        private System.Windows.Forms.TextBox txt_ReadResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ReadAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Save;
    }
}