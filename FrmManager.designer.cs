﻿namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManager));
            this.tabStatistical = new System.Windows.Forms.TabPage();
            this.dtgvStatistical = new System.Windows.Forms.DataGridView();
            this.panelStatistical = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStatistical_winningends = new System.Windows.Forms.DateTimePicker();
            this.btStatistical_printreport = new System.Windows.Forms.Button();
            this.btStatistical_excel = new System.Windows.Forms.Button();
            this.btStatistical_search = new System.Windows.Forms.Button();
            this.cbFrmStatistical_filterinformation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStatistical_winningbegins = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tcFrmManager = new System.Windows.Forms.TabControl();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.pnFrmManager_food = new System.Windows.Forms.Panel();
            tlpFrmManager_AllDishes = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnFrmManager_setup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFrmManager_moredishes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFrmManager_managerCategoryDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFrmManager_signout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAgent = new System.Windows.Forms.TabPage();
            this.dtgvFrmAgent = new System.Windows.Forms.DataGridView();
            this.splitAgent = new System.Windows.Forms.SplitContainer();
            this.rbFrmAgent_girl = new System.Windows.Forms.RadioButton();
            this.rbFrmAgent_boy = new System.Windows.Forms.RadioButton();
            this.dtpFrmAgent_date = new System.Windows.Forms.DateTimePicker();
            this.cbFrmAgent_nativeland = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nv_lb_gioitinh = new System.Windows.Forms.Label();
            this.tbFrmAgent_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFrmAgent_addpicture = new System.Windows.Forms.Button();
            this.pbFrmAgent_picture = new System.Windows.Forms.PictureBox();
            this.tbFrmAgent_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFrmAgent_cccd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btFrmAgent_deleteinfomation = new System.Windows.Forms.Button();
            this.btFrmAgent_editinformation = new System.Windows.Forms.Button();
            this.btFrmAgent_addinformation = new System.Windows.Forms.Button();
            this.tbFrmAgent_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFrmAgent_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabStatistical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).BeginInit();
            this.panelStatistical.SuspendLayout();
            this.tcFrmManager.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnFrmManager_food.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrmAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitAgent)).BeginInit();
            this.splitAgent.Panel1.SuspendLayout();
            this.splitAgent.Panel2.SuspendLayout();
            this.splitAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrmAgent_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStatistical
            // 
            this.tabStatistical.Controls.Add(this.dtgvStatistical);
            this.tabStatistical.Controls.Add(this.panelStatistical);
            this.tabStatistical.Location = new System.Drawing.Point(4, 22);
            this.tabStatistical.Name = "tabStatistical";
            this.tabStatistical.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistical.Size = new System.Drawing.Size(743, 330);
            this.tabStatistical.TabIndex = 2;
            this.tabStatistical.Text = "Thống kê doanh thu";
            this.tabStatistical.UseVisualStyleBackColor = true;
            // 
            // dtgvStatistical
            // 
            this.dtgvStatistical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvStatistical.Location = new System.Drawing.Point(3, 149);
            this.dtgvStatistical.Name = "dtgvStatistical";
            this.dtgvStatistical.RowHeadersWidth = 62;
            this.dtgvStatistical.Size = new System.Drawing.Size(737, 178);
            this.dtgvStatistical.TabIndex = 1;
            // 
            // panelStatistical
            // 
            this.panelStatistical.BackColor = System.Drawing.Color.Silver;
            this.panelStatistical.Controls.Add(this.label9);
            this.panelStatistical.Controls.Add(this.dtpStatistical_winningends);
            this.panelStatistical.Controls.Add(this.btStatistical_printreport);
            this.panelStatistical.Controls.Add(this.btStatistical_excel);
            this.panelStatistical.Controls.Add(this.btStatistical_search);
            this.panelStatistical.Controls.Add(this.cbFrmStatistical_filterinformation);
            this.panelStatistical.Controls.Add(this.label10);
            this.panelStatistical.Controls.Add(this.dtpStatistical_winningbegins);
            this.panelStatistical.Controls.Add(this.label8);
            this.panelStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistical.Location = new System.Drawing.Point(3, 3);
            this.panelStatistical.Name = "panelStatistical";
            this.panelStatistical.Size = new System.Drawing.Size(737, 146);
            this.panelStatistical.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(16, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tháng kết thúc";
            // 
            // dtpStatistical_winningends
            // 
            this.dtpStatistical_winningends.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatistical_winningends.Location = new System.Drawing.Point(136, 110);
            this.dtpStatistical_winningends.Name = "dtpStatistical_winningends";
            this.dtpStatistical_winningends.Size = new System.Drawing.Size(187, 20);
            this.dtpStatistical_winningends.TabIndex = 9;
            // 
            // btStatistical_printreport
            // 
            this.btStatistical_printreport.BackColor = System.Drawing.Color.Fuchsia;
            this.btStatistical_printreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btStatistical_printreport.Location = new System.Drawing.Point(623, 50);
            this.btStatistical_printreport.Name = "btStatistical_printreport";
            this.btStatistical_printreport.Size = new System.Drawing.Size(134, 36);
            this.btStatistical_printreport.TabIndex = 8;
            this.btStatistical_printreport.Text = "In báo cáo";
            this.btStatistical_printreport.UseVisualStyleBackColor = false;
            // 
            // btStatistical_excel
            // 
            this.btStatistical_excel.BackColor = System.Drawing.Color.Lime;
            this.btStatistical_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btStatistical_excel.Location = new System.Drawing.Point(479, 50);
            this.btStatistical_excel.Name = "btStatistical_excel";
            this.btStatistical_excel.Size = new System.Drawing.Size(134, 36);
            this.btStatistical_excel.TabIndex = 7;
            this.btStatistical_excel.Text = "Xuất excel";
            this.btStatistical_excel.UseVisualStyleBackColor = false;
            // 
            // btStatistical_search
            // 
            this.btStatistical_search.BackColor = System.Drawing.Color.Aqua;
            this.btStatistical_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btStatistical_search.Location = new System.Drawing.Point(339, 50);
            this.btStatistical_search.Name = "btStatistical_search";
            this.btStatistical_search.Size = new System.Drawing.Size(134, 36);
            this.btStatistical_search.TabIndex = 6;
            this.btStatistical_search.Text = "Tìm kiếm";
            this.btStatistical_search.UseVisualStyleBackColor = false;
            this.btStatistical_search.Click += new System.EventHandler(this.btStatistical_search_Click);
            // 
            // cbFrmStatistical_filterinformation
            // 
            this.cbFrmStatistical_filterinformation.FormattingEnabled = true;
            this.cbFrmStatistical_filterinformation.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbFrmStatistical_filterinformation.Location = new System.Drawing.Point(136, 25);
            this.cbFrmStatistical_filterinformation.Name = "cbFrmStatistical_filterinformation";
            this.cbFrmStatistical_filterinformation.Size = new System.Drawing.Size(187, 21);
            this.cbFrmStatistical_filterinformation.TabIndex = 5;
            this.cbFrmStatistical_filterinformation.SelectedIndexChanged += new System.EventHandler(this.cbFrmStatistical_filterinformation_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(17, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cách thống kê";
            // 
            // dtpStatistical_winningbegins
            // 
            this.dtpStatistical_winningbegins.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatistical_winningbegins.Location = new System.Drawing.Point(136, 69);
            this.dtpStatistical_winningbegins.Name = "dtpStatistical_winningbegins";
            this.dtpStatistical_winningbegins.Size = new System.Drawing.Size(187, 20);
            this.dtpStatistical_winningbegins.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(17, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tháng bắt đầu";
            // 
            // tcFrmManager
            // 
            this.tcFrmManager.Controls.Add(this.tabManager);
            this.tcFrmManager.Controls.Add(this.tabAgent);
            this.tcFrmManager.Controls.Add(this.tabStatistical);
            this.tcFrmManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFrmManager.Location = new System.Drawing.Point(0, 0);
            this.tcFrmManager.Name = "tcFrmManager";
            this.tcFrmManager.SelectedIndex = 0;
            this.tcFrmManager.Size = new System.Drawing.Size(751, 356);
            this.tcFrmManager.TabIndex = 0;
            this.tcFrmManager.Click += new System.EventHandler(this.tcFrmManager_Click);
            // 
            // tabManager
            // 
            this.tabManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabManager.Controls.Add(this.panel1);
            this.tabManager.Controls.Add(this.pnFrmManager_food);
            this.tabManager.Controls.Add(this.menuStrip2);
            this.tabManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabManager.Location = new System.Drawing.Point(4, 22);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabManager.Size = new System.Drawing.Size(743, 330);
            this.tabManager.TabIndex = 0;
            this.tabManager.Text = "Quản lý món";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label38);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 43);
            this.panel1.TabIndex = 7;
            // 
            // label38
            // 
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(737, 43);
            this.label38.TabIndex = 4;
            this.label38.Text = "Danh sách món ăn";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnFrmManager_food
            // 
            this.pnFrmManager_food.AutoScroll = true;
            this.pnFrmManager_food.Controls.Add(tlpFrmManager_AllDishes);
            this.pnFrmManager_food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFrmManager_food.Location = new System.Drawing.Point(3, 37);
            this.pnFrmManager_food.Name = "pnFrmManager_food";
            this.pnFrmManager_food.Size = new System.Drawing.Size(737, 290);
            this.pnFrmManager_food.TabIndex = 6;
            // 
            // tlpFrmManager_AllDishes
            // 
            tlpFrmManager_AllDishes.AutoSize = true;
            tlpFrmManager_AllDishes.ColumnCount = 2;
            tlpFrmManager_AllDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpFrmManager_AllDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpFrmManager_AllDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpFrmManager_AllDishes.Dock = System.Windows.Forms.DockStyle.Top;
            tlpFrmManager_AllDishes.Location = new System.Drawing.Point(0, 0);
            tlpFrmManager_AllDishes.Name = "tlpFrmManager_AllDishes";
            tlpFrmManager_AllDishes.RowCount = 1;
            tlpFrmManager_AllDishes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpFrmManager_AllDishes.Size = new System.Drawing.Size(737, 0);
            tlpFrmManager_AllDishes.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFrmManager_setup});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(737, 34);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnFrmManager_setup
            // 
            this.mnFrmManager_setup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFrmManager_moredishes,
            this.mnFrmManager_managerCategoryDish,
            this.mnFrmManager_signout});
            this.mnFrmManager_setup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnFrmManager_setup.Name = "mnFrmManager_setup";
            this.mnFrmManager_setup.Size = new System.Drawing.Size(85, 32);
            this.mnFrmManager_setup.Text = "Cài đặt";
            // 
            // mnFrmManager_moredishes
            // 
            this.mnFrmManager_moredishes.Name = "mnFrmManager_moredishes";
            this.mnFrmManager_moredishes.Size = new System.Drawing.Size(266, 32);
            this.mnFrmManager_moredishes.Text = "Thêm món ăn";
            this.mnFrmManager_moredishes.Click += new System.EventHandler(this.mnFrmManager_moredishes_Click);
            // 
            // mnFrmManager_managerCategoryDish
            // 
            this.mnFrmManager_managerCategoryDish.Name = "mnFrmManager_managerCategoryDish";
            this.mnFrmManager_managerCategoryDish.Size = new System.Drawing.Size(266, 32);
            this.mnFrmManager_managerCategoryDish.Text = "Quản lý thể loại món";
            this.mnFrmManager_managerCategoryDish.Click += new System.EventHandler(this.mnFrmManager_managerCategoryDish_Click);
            // 
            // mnFrmManager_signout
            // 
            this.mnFrmManager_signout.Name = "mnFrmManager_signout";
            this.mnFrmManager_signout.Size = new System.Drawing.Size(266, 32);
            this.mnFrmManager_signout.Text = "Đăng xuất";
            this.mnFrmManager_signout.Click += new System.EventHandler(this.mnFrmManager_signout_Click);
            // 
            // tabAgent
            // 
            this.tabAgent.Controls.Add(this.dtgvFrmAgent);
            this.tabAgent.Controls.Add(this.splitAgent);
            this.tabAgent.Location = new System.Drawing.Point(4, 22);
            this.tabAgent.Name = "tabAgent";
            this.tabAgent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgent.Size = new System.Drawing.Size(743, 330);
            this.tabAgent.TabIndex = 1;
            this.tabAgent.Text = "Quản lý nhân viên";
            this.tabAgent.UseVisualStyleBackColor = true;
            // 
            // dtgvFrmAgent
            // 
            this.dtgvFrmAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFrmAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFrmAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFrmAgent.Location = new System.Drawing.Point(3, 174);
            this.dtgvFrmAgent.Name = "dtgvFrmAgent";
            this.dtgvFrmAgent.RowHeadersWidth = 62;
            this.dtgvFrmAgent.Size = new System.Drawing.Size(737, 153);
            this.dtgvFrmAgent.TabIndex = 1;
            this.dtgvFrmAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFrmAgent_CellContentClick);
            // 
            // splitAgent
            // 
            this.splitAgent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.splitAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitAgent.Location = new System.Drawing.Point(3, 3);
            this.splitAgent.Name = "splitAgent";
            // 
            // splitAgent.Panel1
            // 
            this.splitAgent.Panel1.Controls.Add(this.rbFrmAgent_girl);
            this.splitAgent.Panel1.Controls.Add(this.rbFrmAgent_boy);
            this.splitAgent.Panel1.Controls.Add(this.dtpFrmAgent_date);
            this.splitAgent.Panel1.Controls.Add(this.cbFrmAgent_nativeland);
            this.splitAgent.Panel1.Controls.Add(this.label4);
            this.splitAgent.Panel1.Controls.Add(this.label3);
            this.splitAgent.Panel1.Controls.Add(this.nv_lb_gioitinh);
            this.splitAgent.Panel1.Controls.Add(this.tbFrmAgent_name);
            this.splitAgent.Panel1.Controls.Add(this.label1);
            this.splitAgent.Panel1.Controls.Add(this.btFrmAgent_addpicture);
            this.splitAgent.Panel1.Controls.Add(this.pbFrmAgent_picture);
            // 
            // splitAgent.Panel2
            // 
            this.splitAgent.Panel2.Controls.Add(this.tbFrmAgent_pass);
            this.splitAgent.Panel2.Controls.Add(this.label2);
            this.splitAgent.Panel2.Controls.Add(this.tbFrmAgent_cccd);
            this.splitAgent.Panel2.Controls.Add(this.label7);
            this.splitAgent.Panel2.Controls.Add(this.btFrmAgent_deleteinfomation);
            this.splitAgent.Panel2.Controls.Add(this.btFrmAgent_editinformation);
            this.splitAgent.Panel2.Controls.Add(this.btFrmAgent_addinformation);
            this.splitAgent.Panel2.Controls.Add(this.tbFrmAgent_email);
            this.splitAgent.Panel2.Controls.Add(this.label6);
            this.splitAgent.Panel2.Controls.Add(this.tbFrmAgent_phone);
            this.splitAgent.Panel2.Controls.Add(this.label5);
            this.splitAgent.Size = new System.Drawing.Size(737, 171);
            this.splitAgent.SplitterDistance = 371;
            this.splitAgent.TabIndex = 0;
            // 
            // rbFrmAgent_girl
            // 
            this.rbFrmAgent_girl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFrmAgent_girl.AutoSize = true;
            this.rbFrmAgent_girl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbFrmAgent_girl.Location = new System.Drawing.Point(278, 59);
            this.rbFrmAgent_girl.Name = "rbFrmAgent_girl";
            this.rbFrmAgent_girl.Size = new System.Drawing.Size(45, 22);
            this.rbFrmAgent_girl.TabIndex = 10;
            this.rbFrmAgent_girl.TabStop = true;
            this.rbFrmAgent_girl.Text = "Nữ";
            this.rbFrmAgent_girl.UseVisualStyleBackColor = true;
            // 
            // rbFrmAgent_boy
            // 
            this.rbFrmAgent_boy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFrmAgent_boy.AutoSize = true;
            this.rbFrmAgent_boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbFrmAgent_boy.Location = new System.Drawing.Point(206, 59);
            this.rbFrmAgent_boy.Name = "rbFrmAgent_boy";
            this.rbFrmAgent_boy.Size = new System.Drawing.Size(58, 22);
            this.rbFrmAgent_boy.TabIndex = 9;
            this.rbFrmAgent_boy.TabStop = true;
            this.rbFrmAgent_boy.Text = "Nam";
            this.rbFrmAgent_boy.UseVisualStyleBackColor = true;
            // 
            // dtpFrmAgent_date
            // 
            this.dtpFrmAgent_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFrmAgent_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpFrmAgent_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrmAgent_date.Location = new System.Drawing.Point(207, 93);
            this.dtpFrmAgent_date.Name = "dtpFrmAgent_date";
            this.dtpFrmAgent_date.Size = new System.Drawing.Size(154, 22);
            this.dtpFrmAgent_date.TabIndex = 8;
            // 
            // cbFrmAgent_nativeland
            // 
            this.cbFrmAgent_nativeland.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFrmAgent_nativeland.FormattingEnabled = true;
            this.cbFrmAgent_nativeland.Location = new System.Drawing.Point(207, 132);
            this.cbFrmAgent_nativeland.Name = "cbFrmAgent_nativeland";
            this.cbFrmAgent_nativeland.Size = new System.Drawing.Size(154, 21);
            this.cbFrmAgent_nativeland.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(129, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(129, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ngày sinh";
            // 
            // nv_lb_gioitinh
            // 
            this.nv_lb_gioitinh.AutoSize = true;
            this.nv_lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nv_lb_gioitinh.Location = new System.Drawing.Point(129, 57);
            this.nv_lb_gioitinh.Name = "nv_lb_gioitinh";
            this.nv_lb_gioitinh.Size = new System.Drawing.Size(62, 18);
            this.nv_lb_gioitinh.TabIndex = 4;
            this.nv_lb_gioitinh.Text = "Giới tính";
            // 
            // tbFrmAgent_name
            // 
            this.tbFrmAgent_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrmAgent_name.Location = new System.Drawing.Point(206, 24);
            this.tbFrmAgent_name.Name = "tbFrmAgent_name";
            this.tbFrmAgent_name.Size = new System.Drawing.Size(155, 20);
            this.tbFrmAgent_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(129, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên";
            // 
            // btFrmAgent_addpicture
            // 
            this.btFrmAgent_addpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmAgent_addpicture.Location = new System.Drawing.Point(16, 127);
            this.btFrmAgent_addpicture.Name = "btFrmAgent_addpicture";
            this.btFrmAgent_addpicture.Size = new System.Drawing.Size(82, 27);
            this.btFrmAgent_addpicture.TabIndex = 1;
            this.btFrmAgent_addpicture.Text = "Chọn ảnh";
            this.btFrmAgent_addpicture.UseVisualStyleBackColor = true;
            this.btFrmAgent_addpicture.Click += new System.EventHandler(this.nv_chonanh_Click);
            // 
            // pbFrmAgent_picture
            // 
            this.pbFrmAgent_picture.Image = ((System.Drawing.Image)(resources.GetObject("pbFrmAgent_picture.Image")));
            this.pbFrmAgent_picture.Location = new System.Drawing.Point(8, 6);
            this.pbFrmAgent_picture.Name = "pbFrmAgent_picture";
            this.pbFrmAgent_picture.Size = new System.Drawing.Size(97, 115);
            this.pbFrmAgent_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrmAgent_picture.TabIndex = 0;
            this.pbFrmAgent_picture.TabStop = false;
            // 
            // tbFrmAgent_pass
            // 
            this.tbFrmAgent_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrmAgent_pass.Location = new System.Drawing.Point(135, 108);
            this.tbFrmAgent_pass.Name = "tbFrmAgent_pass";
            this.tbFrmAgent_pass.Size = new System.Drawing.Size(179, 20);
            this.tbFrmAgent_pass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pass word";
            // 
            // tbFrmAgent_cccd
            // 
            this.tbFrmAgent_cccd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrmAgent_cccd.Location = new System.Drawing.Point(135, 11);
            this.tbFrmAgent_cccd.Name = "tbFrmAgent_cccd";
            this.tbFrmAgent_cccd.Size = new System.Drawing.Size(179, 20);
            this.tbFrmAgent_cccd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(35, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "CCCD";
            // 
            // btFrmAgent_deleteinfomation
            // 
            this.btFrmAgent_deleteinfomation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrmAgent_deleteinfomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btFrmAgent_deleteinfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmAgent_deleteinfomation.Location = new System.Drawing.Point(241, 138);
            this.btFrmAgent_deleteinfomation.Name = "btFrmAgent_deleteinfomation";
            this.btFrmAgent_deleteinfomation.Size = new System.Drawing.Size(106, 27);
            this.btFrmAgent_deleteinfomation.TabIndex = 10;
            this.btFrmAgent_deleteinfomation.Text = "Xóa thông tin";
            this.btFrmAgent_deleteinfomation.UseVisualStyleBackColor = false;
            this.btFrmAgent_deleteinfomation.Click += new System.EventHandler(this.btFrmAgent_deleteinfomation_Click);
            // 
            // btFrmAgent_editinformation
            // 
            this.btFrmAgent_editinformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrmAgent_editinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btFrmAgent_editinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmAgent_editinformation.Location = new System.Drawing.Point(124, 138);
            this.btFrmAgent_editinformation.Name = "btFrmAgent_editinformation";
            this.btFrmAgent_editinformation.Size = new System.Drawing.Size(106, 27);
            this.btFrmAgent_editinformation.TabIndex = 9;
            this.btFrmAgent_editinformation.Text = "Sửa thông tin";
            this.btFrmAgent_editinformation.UseVisualStyleBackColor = false;
            this.btFrmAgent_editinformation.Click += new System.EventHandler(this.btFrmAgent_editinformation_Click);
            // 
            // btFrmAgent_addinformation
            // 
            this.btFrmAgent_addinformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrmAgent_addinformation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btFrmAgent_addinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmAgent_addinformation.Location = new System.Drawing.Point(7, 138);
            this.btFrmAgent_addinformation.Name = "btFrmAgent_addinformation";
            this.btFrmAgent_addinformation.Size = new System.Drawing.Size(106, 27);
            this.btFrmAgent_addinformation.TabIndex = 8;
            this.btFrmAgent_addinformation.Text = "Thêm thông tin";
            this.btFrmAgent_addinformation.UseVisualStyleBackColor = false;
            this.btFrmAgent_addinformation.Click += new System.EventHandler(this.nv_bt_them_Click);
            // 
            // tbFrmAgent_email
            // 
            this.tbFrmAgent_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrmAgent_email.Location = new System.Drawing.Point(135, 78);
            this.tbFrmAgent_email.Name = "tbFrmAgent_email";
            this.tbFrmAgent_email.Size = new System.Drawing.Size(179, 20);
            this.tbFrmAgent_email.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(35, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // tbFrmAgent_phone
            // 
            this.tbFrmAgent_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrmAgent_phone.Location = new System.Drawing.Point(135, 45);
            this.tbFrmAgent_phone.Name = "tbFrmAgent_phone";
            this.tbFrmAgent_phone.Size = new System.Drawing.Size(179, 20);
            this.tbFrmAgent_phone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(35, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // FrmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 356);
            this.Controls.Add(this.tcFrmManager);
            this.Name = "FrmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabStatistical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistical)).EndInit();
            this.panelStatistical.ResumeLayout(false);
            this.panelStatistical.PerformLayout();
            this.tcFrmManager.ResumeLayout(false);
            this.tabManager.ResumeLayout(false);
            this.tabManager.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnFrmManager_food.ResumeLayout(false);
            this.pnFrmManager_food.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrmAgent)).EndInit();
            this.splitAgent.Panel1.ResumeLayout(false);
            this.splitAgent.Panel1.PerformLayout();
            this.splitAgent.Panel2.ResumeLayout(false);
            this.splitAgent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAgent)).EndInit();
            this.splitAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrmAgent_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabStatistical;
        private System.Windows.Forms.TabControl tcFrmManager;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.TabPage tabAgent;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnFrmManager_setup;
        private System.Windows.Forms.ToolStripMenuItem mnFrmManager_moredishes;
        private System.Windows.Forms.ToolStripMenuItem mnFrmManager_signout;
        private System.Windows.Forms.SplitContainer splitAgent;
        private System.Windows.Forms.RadioButton rbFrmAgent_girl;
        private System.Windows.Forms.RadioButton rbFrmAgent_boy;
        private System.Windows.Forms.DateTimePicker dtpFrmAgent_date;
        private System.Windows.Forms.ComboBox cbFrmAgent_nativeland;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nv_lb_gioitinh;
        private System.Windows.Forms.TextBox tbFrmAgent_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFrmAgent_addpicture;
        private System.Windows.Forms.PictureBox pbFrmAgent_picture;
        private System.Windows.Forms.Button btFrmAgent_deleteinfomation;
        private System.Windows.Forms.Button btFrmAgent_editinformation;
        private System.Windows.Forms.Button btFrmAgent_addinformation;
        private System.Windows.Forms.TextBox tbFrmAgent_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFrmAgent_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvFrmAgent;
        private System.Windows.Forms.TextBox tbFrmAgent_cccd;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelStatistical;
        private System.Windows.Forms.DataGridView dtgvStatistical;
        private System.Windows.Forms.Button btStatistical_printreport;
        private System.Windows.Forms.Button btStatistical_excel;
        private System.Windows.Forms.Button btStatistical_search;
        private System.Windows.Forms.ComboBox cbFrmStatistical_filterinformation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStatistical_winningbegins;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnFrmManager_food;
        private System.Windows.Forms.TextBox tbFrmAgent_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnFrmManager_managerCategoryDish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker dtpStatistical_winningends;
        private System.Windows.Forms.Label label9;
        public static System.Windows.Forms.TableLayoutPanel tlpFrmManager_AllDishes;
    }
}

