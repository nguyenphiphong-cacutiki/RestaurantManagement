namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmDialogBill_Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFrmDialogBill_TableId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnFrmDialogBill_Grandtotal = new System.Windows.Forms.Panel();
            this.pnFrmDialogBill_DishList = new System.Windows.Forms.Panel();
            this.lbFrmDialogBill_Grandtotal = new System.Windows.Forms.Label();
            this.btFrmDialogBill_Print = new System.Windows.Forms.Button();
            this.btFrmDialogBill_CanCel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnFrmDialogBill_Grandtotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbFrmDialogBill_TableId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // lbFrmDialogBill_TableId
            // 
            this.lbFrmDialogBill_TableId.AutoSize = true;
            this.lbFrmDialogBill_TableId.Location = new System.Drawing.Point(203, 43);
            this.lbFrmDialogBill_TableId.Name = "lbFrmDialogBill_TableId";
            this.lbFrmDialogBill_TableId.Size = new System.Drawing.Size(46, 20);
            this.lbFrmDialogBill_TableId.TabIndex = 1;
            this.lbFrmDialogBill_TableId.Text = "Bàn: ";
            this.lbFrmDialogBill_TableId.Click += new System.EventHandler(this.lbFrmDialogBill_TableId_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 43);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "SL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành tiền";
            // 
            // pnFrmDialogBill_Grandtotal
            // 
            this.pnFrmDialogBill_Grandtotal.Controls.Add(this.btFrmDialogBill_CanCel);
            this.pnFrmDialogBill_Grandtotal.Controls.Add(this.btFrmDialogBill_Print);
            this.pnFrmDialogBill_Grandtotal.Controls.Add(this.lbFrmDialogBill_Grandtotal);
            this.pnFrmDialogBill_Grandtotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFrmDialogBill_Grandtotal.Location = new System.Drawing.Point(0, 575);
            this.pnFrmDialogBill_Grandtotal.Name = "pnFrmDialogBill_Grandtotal";
            this.pnFrmDialogBill_Grandtotal.Size = new System.Drawing.Size(524, 100);
            this.pnFrmDialogBill_Grandtotal.TabIndex = 3;
            // 
            // pnFrmDialogBill_DishList
            // 
            this.pnFrmDialogBill_DishList.AutoScroll = true;
            this.pnFrmDialogBill_DishList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFrmDialogBill_DishList.Location = new System.Drawing.Point(0, 120);
            this.pnFrmDialogBill_DishList.Name = "pnFrmDialogBill_DishList";
            this.pnFrmDialogBill_DishList.Size = new System.Drawing.Size(524, 455);
            this.pnFrmDialogBill_DishList.TabIndex = 4;
            // 
            // lbFrmDialogBill_Grandtotal
            // 
            this.lbFrmDialogBill_Grandtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFrmDialogBill_Grandtotal.AutoSize = true;
            this.lbFrmDialogBill_Grandtotal.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrmDialogBill_Grandtotal.Location = new System.Drawing.Point(346, 13);
            this.lbFrmDialogBill_Grandtotal.Name = "lbFrmDialogBill_Grandtotal";
            this.lbFrmDialogBill_Grandtotal.Size = new System.Drawing.Size(65, 23);
            this.lbFrmDialogBill_Grandtotal.TabIndex = 0;
            this.lbFrmDialogBill_Grandtotal.Text = "Tổng: ";
            // 
            // btFrmDialogBill_Print
            // 
            this.btFrmDialogBill_Print.Location = new System.Drawing.Point(420, 49);
            this.btFrmDialogBill_Print.Name = "btFrmDialogBill_Print";
            this.btFrmDialogBill_Print.Size = new System.Drawing.Size(80, 39);
            this.btFrmDialogBill_Print.TabIndex = 1;
            this.btFrmDialogBill_Print.Text = "In";
            this.btFrmDialogBill_Print.UseVisualStyleBackColor = true;
            this.btFrmDialogBill_Print.Click += new System.EventHandler(this.btFrmDialogBill_Print_Click);
            // 
            // btFrmDialogBill_CanCel
            // 
            this.btFrmDialogBill_CanCel.Location = new System.Drawing.Point(319, 49);
            this.btFrmDialogBill_CanCel.Name = "btFrmDialogBill_CanCel";
            this.btFrmDialogBill_CanCel.Size = new System.Drawing.Size(78, 39);
            this.btFrmDialogBill_CanCel.TabIndex = 2;
            this.btFrmDialogBill_CanCel.Text = "Hủy";
            this.btFrmDialogBill_CanCel.UseVisualStyleBackColor = true;
            this.btFrmDialogBill_CanCel.Click += new System.EventHandler(this.btFrmDialogBill_CanCel_Click);
            // 
            // FrmDialogBill_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(524, 675);
            this.Controls.Add(this.pnFrmDialogBill_DishList);
            this.Controls.Add(this.pnFrmDialogBill_Grandtotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDialogBill_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDialogBill";
            this.Load += new System.EventHandler(this.FrmDialogBill_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnFrmDialogBill_Grandtotal.ResumeLayout(false);
            this.pnFrmDialogBill_Grandtotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFrmDialogBill_TableId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnFrmDialogBill_Grandtotal;
        private System.Windows.Forms.Button btFrmDialogBill_CanCel;
        private System.Windows.Forms.Button btFrmDialogBill_Print;
        private System.Windows.Forms.Label lbFrmDialogBill_Grandtotal;
        private System.Windows.Forms.Panel pnFrmDialogBill_DishList;
    }
}