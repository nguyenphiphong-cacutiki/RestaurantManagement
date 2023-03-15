namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmSetUpTable
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
            this.ThuongThuong = new System.Windows.Forms.Label();
            this.tbFrmSetUpTable_index = new System.Windows.Forms.TextBox();
            this.btFrmSetUpTable_accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThuongThuong
            // 
            this.ThuongThuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThuongThuong.AutoSize = true;
            this.ThuongThuong.Location = new System.Drawing.Point(39, 65);
            this.ThuongThuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThuongThuong.Name = "ThuongThuong";
            this.ThuongThuong.Size = new System.Drawing.Size(91, 13);
            this.ThuongThuong.TabIndex = 0;
            this.ThuongThuong.Text = "Nhập số hiệu bàn";
            // 
            // tbFrmSetUpTable_index
            // 
            this.tbFrmSetUpTable_index.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrmSetUpTable_index.Location = new System.Drawing.Point(21, 97);
            this.tbFrmSetUpTable_index.Margin = new System.Windows.Forms.Padding(2);
            this.tbFrmSetUpTable_index.Name = "tbFrmSetUpTable_index";
            this.tbFrmSetUpTable_index.Size = new System.Drawing.Size(127, 20);
            this.tbFrmSetUpTable_index.TabIndex = 1;
            // 
            // btFrmSetUpTable_accept
            // 
            this.btFrmSetUpTable_accept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrmSetUpTable_accept.Location = new System.Drawing.Point(49, 140);
            this.btFrmSetUpTable_accept.Margin = new System.Windows.Forms.Padding(2);
            this.btFrmSetUpTable_accept.Name = "btFrmSetUpTable_accept";
            this.btFrmSetUpTable_accept.Size = new System.Drawing.Size(67, 19);
            this.btFrmSetUpTable_accept.TabIndex = 2;
            this.btFrmSetUpTable_accept.Text = "Xác nhận";
            this.btFrmSetUpTable_accept.UseVisualStyleBackColor = true;
            this.btFrmSetUpTable_accept.Click += new System.EventHandler(this.btFrmSetUpTable_accept_Click);
            // 
            // FrmSetUpTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 281);
            this.Controls.Add(this.btFrmSetUpTable_accept);
            this.Controls.Add(this.tbFrmSetUpTable_index);
            this.Controls.Add(this.ThuongThuong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetUpTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập bàn";
            this.Load += new System.EventHandler(this.FrmSetUpTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThuongThuong;
        private System.Windows.Forms.TextBox tbFrmSetUpTable_index;
        private System.Windows.Forms.Button btFrmSetUpTable_accept;
    }
}