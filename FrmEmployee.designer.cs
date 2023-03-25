namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmEmployee
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
            this.msFrmEmployee_MoreFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFrmEmployee_Setup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFrmEmployee_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btFrmEmployee_getSupport = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.thuong = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pB = new System.Windows.Forms.PictureBox();
            this.PnFrmEmplyee_ = new System.Windows.Forms.Panel();
            this.btFrmEmployee_PrintBill = new System.Windows.Forms.Button();
            this.btFrmEmployee_TableReset = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            pnFrmEmployee_TableList = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            pnFrmEmployee_DishList = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.thuong.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.PnFrmEmplyee_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            pnFrmEmployee_TableList.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFrmEmployee_MoreFeature
            // 
            this.msFrmEmployee_MoreFeature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFrmEmployee_Setup,
            this.mnFrmEmployee_SignOut});
            this.msFrmEmployee_MoreFeature.Name = "msFrmEmployee_MoreFeature";
            this.msFrmEmployee_MoreFeature.Size = new System.Drawing.Size(105, 22);
            this.msFrmEmployee_MoreFeature.Text = "Chức năng khác";
            // 
            // mnFrmEmployee_Setup
            // 
            this.mnFrmEmployee_Setup.Name = "mnFrmEmployee_Setup";
            this.mnFrmEmployee_Setup.Size = new System.Drawing.Size(142, 22);
            this.mnFrmEmployee_Setup.Text = "Thiết lập bàn";
            this.mnFrmEmployee_Setup.Click += new System.EventHandler(this.mnFrmEmployee_Setup_Click);
            // 
            // mnFrmEmployee_SignOut
            // 
            this.mnFrmEmployee_SignOut.Name = "mnFrmEmployee_SignOut";
            this.mnFrmEmployee_SignOut.Size = new System.Drawing.Size(142, 22);
            this.mnFrmEmployee_SignOut.Text = "Đăng xuất";
            this.mnFrmEmployee_SignOut.Click += new System.EventHandler(this.mnFrmEmployee_SignOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFrmEmployee_MoreFeature});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btFrmEmployee_getSupport
            // 
            this.btFrmEmployee_getSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrmEmployee_getSupport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFrmEmployee_getSupport.Location = new System.Drawing.Point(313, 1);
            this.btFrmEmployee_getSupport.Margin = new System.Windows.Forms.Padding(2);
            this.btFrmEmployee_getSupport.Name = "btFrmEmployee_getSupport";
            this.btFrmEmployee_getSupport.Size = new System.Drawing.Size(113, 20);
            this.btFrmEmployee_getSupport.TabIndex = 1;
            this.btFrmEmployee_getSupport.Text = "Nhận hỗ trợ";
            this.btFrmEmployee_getSupport.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(pnFrmEmployee_DishList);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.thuong);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PnFrmEmplyee_);
            this.splitContainer2.Size = new System.Drawing.Size(429, 268);
            this.splitContainer2.SplitterDistance = 353;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(347, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(6, 241);
            this.label4.TabIndex = 1;
            // 
            // thuong
            // 
            this.thuong.ColumnCount = 2;
            this.thuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.thuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.thuong.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.thuong.Controls.Add(this.pB, 0, 0);
            this.thuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.thuong.Location = new System.Drawing.Point(0, 0);
            this.thuong.Margin = new System.Windows.Forms.Padding(2);
            this.thuong.Name = "thuong";
            this.thuong.RowCount = 1;
            this.thuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thuong.Size = new System.Drawing.Size(353, 27);
            this.thuong.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 23);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05404F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.377678F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78414F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78414F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 19);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đang làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đã làm";
            // 
            // pB
            // 
            this.pB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pB.Location = new System.Drawing.Point(2, 2);
            this.pB.Margin = new System.Windows.Forms.Padding(2);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(48, 23);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB.TabIndex = 1;
            this.pB.TabStop = false;
            // 
            // PnFrmEmplyee_
            // 
            this.PnFrmEmplyee_.Controls.Add(this.btFrmEmployee_PrintBill);
            this.PnFrmEmplyee_.Controls.Add(this.btFrmEmployee_TableReset);
            this.PnFrmEmplyee_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFrmEmplyee_.Location = new System.Drawing.Point(0, 0);
            this.PnFrmEmplyee_.Margin = new System.Windows.Forms.Padding(2);
            this.PnFrmEmplyee_.Name = "PnFrmEmplyee_";
            this.PnFrmEmplyee_.Size = new System.Drawing.Size(73, 268);
            this.PnFrmEmplyee_.TabIndex = 0;
            // 
            // btFrmEmployee_PrintBill
            // 
            this.btFrmEmployee_PrintBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btFrmEmployee_PrintBill.Location = new System.Drawing.Point(0, 188);
            this.btFrmEmployee_PrintBill.Margin = new System.Windows.Forms.Padding(2);
            this.btFrmEmployee_PrintBill.Name = "btFrmEmployee_PrintBill";
            this.btFrmEmployee_PrintBill.Size = new System.Drawing.Size(73, 40);
            this.btFrmEmployee_PrintBill.TabIndex = 3;
            this.btFrmEmployee_PrintBill.Text = "In hóa đơn";
            this.btFrmEmployee_PrintBill.UseVisualStyleBackColor = true;
            this.btFrmEmployee_PrintBill.Click += new System.EventHandler(this.btFrmEmployee_PrintBill_Click);
            // 
            // btFrmEmployee_TableReset
            // 
            this.btFrmEmployee_TableReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btFrmEmployee_TableReset.Location = new System.Drawing.Point(0, 228);
            this.btFrmEmployee_TableReset.Margin = new System.Windows.Forms.Padding(2);
            this.btFrmEmployee_TableReset.Name = "btFrmEmployee_TableReset";
            this.btFrmEmployee_TableReset.Size = new System.Drawing.Size(73, 40);
            this.btFrmEmployee_TableReset.TabIndex = 2;
            this.btFrmEmployee_TableReset.Text = "Reset bàn";
            this.btFrmEmployee_TableReset.UseVisualStyleBackColor = true;
            this.btFrmEmployee_TableReset.Click += new System.EventHandler(this.btFrmEmployee_TableReset_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(pnFrmEmployee_TableList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(533, 268);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnFrmEmployee_TableList
            // 
            pnFrmEmployee_TableList.Controls.Add(this.label3);
            pnFrmEmployee_TableList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnFrmEmployee_TableList.Location = new System.Drawing.Point(0, 0);
            pnFrmEmployee_TableList.Margin = new System.Windows.Forms.Padding(2);
            pnFrmEmployee_TableList.Name = "pnFrmEmployee_TableList";
            pnFrmEmployee_TableList.Size = new System.Drawing.Size(101, 268);
            pnFrmEmployee_TableList.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(95, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(6, 268);
            this.label3.TabIndex = 0;
            // 
            // pnFrmEmployee_DishList
            // 
            pnFrmEmployee_DishList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnFrmEmployee_DishList.Location = new System.Drawing.Point(0, 27);
            pnFrmEmployee_DishList.Name = "pnFrmEmployee_DishList";
            pnFrmEmployee_DishList.Size = new System.Drawing.Size(347, 241);
            pnFrmEmployee_DishList.TabIndex = 4;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btFrmEmployee_getSupport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEmployee";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.NV_TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.thuong.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.PnFrmEmplyee_.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            pnFrmEmployee_TableList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem msFrmEmployee_MoreFeature;
        private System.Windows.Forms.ToolStripMenuItem mnFrmEmployee_Setup;
        private System.Windows.Forms.ToolStripMenuItem mnFrmEmployee_SignOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btFrmEmployee_getSupport;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel thuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Panel PnFrmEmplyee_;
        private System.Windows.Forms.Button btFrmEmployee_PrintBill;
        private System.Windows.Forms.Button btFrmEmployee_TableReset;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public static System.Windows.Forms.Panel pnFrmEmployee_DishList;
        public static System.Windows.Forms.Panel pnFrmEmployee_TableList;
    }
}