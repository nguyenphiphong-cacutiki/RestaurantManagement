
namespace ProjectGroup03_63KTPM2_Version01
{
    partial class ItemDish_Manager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbItemDishManager_name = new System.Windows.Forms.Label();
            this.lbItemDishManager_price = new System.Windows.Forms.Label();
            this.lbItemDishManager_howUse = new System.Windows.Forms.Label();
            this.pbItemDishManager_pic = new System.Windows.Forms.PictureBox();
            this.btItemDishManager_edit = new System.Windows.Forms.Button();
            this.btItemDishManager_delete = new System.Windows.Forms.Button();
            this.btItemDishManager_add = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDishManager_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbItemDishManager_pic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbItemDishManager_name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbItemDishManager_price, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbItemDishManager_howUse, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btItemDishManager_edit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btItemDishManager_delete, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btItemDishManager_add, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(145, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(137, 146);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbItemDishManager_name
            // 
            this.lbItemDishManager_name.AutoSize = true;
            this.lbItemDishManager_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemDishManager_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemDishManager_name.Location = new System.Drawing.Point(3, 0);
            this.lbItemDishManager_name.Name = "lbItemDishManager_name";
            this.lbItemDishManager_name.Size = new System.Drawing.Size(103, 48);
            this.lbItemDishManager_name.TabIndex = 0;
            this.lbItemDishManager_name.Text = "Tên món";
            this.lbItemDishManager_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbItemDishManager_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbItemDishManager_price
            // 
            this.lbItemDishManager_price.AutoSize = true;
            this.lbItemDishManager_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemDishManager_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemDishManager_price.Location = new System.Drawing.Point(3, 48);
            this.lbItemDishManager_price.Name = "lbItemDishManager_price";
            this.lbItemDishManager_price.Size = new System.Drawing.Size(103, 48);
            this.lbItemDishManager_price.TabIndex = 1;
            this.lbItemDishManager_price.Text = "Giá";
            this.lbItemDishManager_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbItemDishManager_price.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbItemDishManager_howUse
            // 
            this.lbItemDishManager_howUse.AutoSize = true;
            this.lbItemDishManager_howUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemDishManager_howUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemDishManager_howUse.Location = new System.Drawing.Point(3, 96);
            this.lbItemDishManager_howUse.Name = "lbItemDishManager_howUse";
            this.lbItemDishManager_howUse.Size = new System.Drawing.Size(103, 50);
            this.lbItemDishManager_howUse.TabIndex = 2;
            this.lbItemDishManager_howUse.Text = "Hướng dẫn sử dụng";
            this.lbItemDishManager_howUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbItemDishManager_howUse.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbItemDishManager_pic
            // 
            this.pbItemDishManager_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbItemDishManager_pic.Location = new System.Drawing.Point(3, 3);
            this.pbItemDishManager_pic.Name = "pbItemDishManager_pic";
            this.pbItemDishManager_pic.Size = new System.Drawing.Size(136, 146);
            this.pbItemDishManager_pic.TabIndex = 0;
            this.pbItemDishManager_pic.TabStop = false;
            // 
            // btItemDishManager_edit
            // 
            this.btItemDishManager_edit.BackgroundImage = global::ProjectGroup03_63KTPM2_Version01.Properties.Resources.edit11;
            this.btItemDishManager_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btItemDishManager_edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btItemDishManager_edit.Location = new System.Drawing.Point(112, 120);
            this.btItemDishManager_edit.Name = "btItemDishManager_edit";
            this.btItemDishManager_edit.Size = new System.Drawing.Size(22, 23);
            this.btItemDishManager_edit.TabIndex = 3;
            this.btItemDishManager_edit.Text = "button1";
            this.btItemDishManager_edit.UseVisualStyleBackColor = true;
            // 
            // btItemDishManager_delete
            // 
            this.btItemDishManager_delete.BackgroundImage = global::ProjectGroup03_63KTPM2_Version01.Properties.Resources.delete_row;
            this.btItemDishManager_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btItemDishManager_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btItemDishManager_delete.Location = new System.Drawing.Point(112, 70);
            this.btItemDishManager_delete.Name = "btItemDishManager_delete";
            this.btItemDishManager_delete.Size = new System.Drawing.Size(22, 23);
            this.btItemDishManager_delete.TabIndex = 4;
            this.btItemDishManager_delete.UseVisualStyleBackColor = true;
            // 
            // btItemDishManager_add
            // 
            this.btItemDishManager_add.BackgroundImage = global::ProjectGroup03_63KTPM2_Version01.Properties.Resources.add_day;
            this.btItemDishManager_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btItemDishManager_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btItemDishManager_add.Location = new System.Drawing.Point(112, 3);
            this.btItemDishManager_add.Name = "btItemDishManager_add";
            this.btItemDishManager_add.Size = new System.Drawing.Size(22, 23);
            this.btItemDishManager_add.TabIndex = 5;
            this.btItemDishManager_add.UseVisualStyleBackColor = true;
            // 
            // ItemDish_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemDish_Manager";
            this.Size = new System.Drawing.Size(285, 152);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemDishManager_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbItemDishManager_pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbItemDishManager_name;
        private System.Windows.Forms.Label lbItemDishManager_price;
        private System.Windows.Forms.Label lbItemDishManager_howUse;
        private System.Windows.Forms.Button btItemDishManager_edit;
        private System.Windows.Forms.Button btItemDishManager_delete;
        private System.Windows.Forms.Button btItemDishManager_add;
    }
}
