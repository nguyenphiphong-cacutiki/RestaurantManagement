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
            this.tbFrmManagerCaterory_input = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.tbFrmManagerCaterory_input);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_add);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_delete);
            this.panel1.Controls.Add(this.btFrmManagerCaterory_edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 86);
            this.panel1.TabIndex = 1;
            // 
            // tbFrmManagerCaterory_input
            // 
            this.tbFrmManagerCaterory_input.Location = new System.Drawing.Point(12, 14);
            this.tbFrmManagerCaterory_input.Multiline = true;
            this.tbFrmManagerCaterory_input.Name = "tbFrmManagerCaterory_input";
            this.tbFrmManagerCaterory_input.Size = new System.Drawing.Size(272, 25);
            this.tbFrmManagerCaterory_input.TabIndex = 3;
            // 
            // btFrmManagerCaterory_add
            // 
            this.btFrmManagerCaterory_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_add.Location = new System.Drawing.Point(12, 48);
            this.btFrmManagerCaterory_add.Name = "btFrmManagerCaterory_add";
            this.btFrmManagerCaterory_add.Size = new System.Drawing.Size(62, 32);
            this.btFrmManagerCaterory_add.TabIndex = 2;
            this.btFrmManagerCaterory_add.Text = "Thêm";
            this.btFrmManagerCaterory_add.UseVisualStyleBackColor = true;
            this.btFrmManagerCaterory_add.Click += new System.EventHandler(this.btFrmManagerCaterory_add_Click);
            // 
            // btFrmManagerCaterory_delete
            // 
            this.btFrmManagerCaterory_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_delete.Location = new System.Drawing.Point(222, 48);
            this.btFrmManagerCaterory_delete.Name = "btFrmManagerCaterory_delete";
            this.btFrmManagerCaterory_delete.Size = new System.Drawing.Size(62, 32);
            this.btFrmManagerCaterory_delete.TabIndex = 0;
            this.btFrmManagerCaterory_delete.Text = "Xóa";
            this.btFrmManagerCaterory_delete.UseVisualStyleBackColor = true;
            this.btFrmManagerCaterory_delete.Click += new System.EventHandler(this.btFrmManagerCaterory_delete_Click);
            // 
            // btFrmManagerCaterory_edit
            // 
            this.btFrmManagerCaterory_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFrmManagerCaterory_edit.Location = new System.Drawing.Point(117, 48);
            this.btFrmManagerCaterory_edit.Name = "btFrmManagerCaterory_edit";
            this.btFrmManagerCaterory_edit.Size = new System.Drawing.Size(62, 32);
            this.btFrmManagerCaterory_edit.TabIndex = 1;
            this.btFrmManagerCaterory_edit.Text = "Sửa";
            this.btFrmManagerCaterory_edit.UseVisualStyleBackColor = true;
            this.btFrmManagerCaterory_edit.Click += new System.EventHandler(this.btFrmManagerCaterory_edit_Click);
            // 
            // dtgvFrmManagerCaterory
            // 
            this.dtgvFrmManagerCaterory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFrmManagerCaterory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFrmManagerCaterory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFrmManagerCaterory.Location = new System.Drawing.Point(0, 86);
            this.dtgvFrmManagerCaterory.Name = "dtgvFrmManagerCaterory";
            this.dtgvFrmManagerCaterory.ReadOnly = true;
            this.dtgvFrmManagerCaterory.Size = new System.Drawing.Size(298, 217);
            this.dtgvFrmManagerCaterory.TabIndex = 2;
            this.dtgvFrmManagerCaterory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFrmManagerCaterory_CellClick);
            // 
            // FrmManagerCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 303);
            this.Controls.Add(this.dtgvFrmManagerCaterory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManagerCategory";
            this.Text = "Quản lý thê loại món";
            this.Load += new System.EventHandler(this.FrmManagerCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrmManagerCaterory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFrmManagerCaterory_input;
        private System.Windows.Forms.Button btFrmManagerCaterory_add;
        private System.Windows.Forms.Button btFrmManagerCaterory_delete;
        private System.Windows.Forms.Button btFrmManagerCaterory_edit;
        private System.Windows.Forms.DataGridView dtgvFrmManagerCaterory;
    }
}