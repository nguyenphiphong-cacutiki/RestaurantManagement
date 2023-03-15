namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmManagerCategory
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
            this.tbFrmManagerCaterory_search = new System.Windows.Forms.TextBox();
            this.btFrmManagerCaterory_add = new System.Windows.Forms.Button();
            this.btFrmManagerCaterory_delete = new System.Windows.Forms.Button();
            this.btFrmManagerCaterory_edit = new System.Windows.Forms.Button();
            this.dtgvFrmManagerCaterory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrmManagerCaterory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbFrmManagerCaterory_search);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_add);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_delete);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 61);
            this.panel1.TabIndex = 1;
            // 
            // tbFrmManagerCaterory_search
            // 
            this.tbFrmManagerCaterory_search.Location = new System.Drawing.Point(12, 12);
            this.tbFrmManagerCaterory_search.Multiline = true;
            this.tbFrmManagerCaterory_search.Name = "tbFrmManagerCaterory_search";
            this.tbFrmManagerCaterory_search.Size = new System.Drawing.Size(248, 25);
            this.tbFrmManagerCaterory_search.TabIndex = 3;
            // 
            // btFrmManagerCaterory_add
            // 
            this.btFrmManagerCaterory_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_add.Location = new System.Drawing.Point(279, 9);
            this.btFrmManagerCaterory_add.Name = "btFrmManagerCaterory_add";
            this.btFrmManagerCaterory_add.Size = new System.Drawing.Size(151, 35);
            this.btFrmManagerCaterory_add.TabIndex = 2;
            this.btFrmManagerCaterory_add.Text = "Thêm";
            this.btFrmManagerCaterory_add.UseVisualStyleBackColor = true;
            // 
            // btFrmManagerCaterory_delete
            // 
            this.btFrmManagerCaterory_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_delete.Location = new System.Drawing.Point(593, 9);
            this.btFrmManagerCaterory_delete.Name = "btFrmManagerCaterory_delete";
            this.btFrmManagerCaterory_delete.Size = new System.Drawing.Size(151, 35);
            this.btFrmManagerCaterory_delete.TabIndex = 0;
            this.btFrmManagerCaterory_delete.Text = "Xóa";
            this.btFrmManagerCaterory_delete.UseVisualStyleBackColor = true;
            // 
            // btFrmManagerCaterory_edit
            // 
            this.btFrmManagerCaterory_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_edit.Location = new System.Drawing.Point(436, 9);
            this.btFrmManagerCaterory_edit.Name = "btFrmManagerCaterory_edit";
            this.btFrmManagerCaterory_edit.Size = new System.Drawing.Size(151, 35);
            this.btFrmManagerCaterory_edit.TabIndex = 1;
            this.btFrmManagerCaterory_edit.Text = "Sửa";
            this.btFrmManagerCaterory_edit.UseVisualStyleBackColor = true;
            // 
            // dtgvFrmManagerCaterory
            // 
            this.dtgvFrmManagerCaterory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFrmManagerCaterory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFrmManagerCaterory.Location = new System.Drawing.Point(0, 61);
            this.dtgvFrmManagerCaterory.Name = "dtgvFrmManagerCaterory";
            this.dtgvFrmManagerCaterory.Size = new System.Drawing.Size(754, 242);
            this.dtgvFrmManagerCaterory.TabIndex = 2;
            // 
            // FrmManagerCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 303);
            this.Controls.Add(this.dtgvFrmManagerCaterory);
            this.Controls.Add(this.panel1);
            this.Name = "FrmManagerCategory";
            this.Text = "FrmManagerCategory";
            this.Load += new System.EventHandler(this.FrmManagerCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrmManagerCaterory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFrmManagerCaterory_search;
        private System.Windows.Forms.Button btFrmManagerCaterory_add;
        private System.Windows.Forms.Button btFrmManagerCaterory_delete;
        private System.Windows.Forms.Button btFrmManagerCaterory_edit;
        private System.Windows.Forms.DataGridView dtgvFrmManagerCaterory;
    }
}