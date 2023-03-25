namespace ProjectGroup03_63KTPM2_Version01
{
    partial class ItemDish_Employee
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbItemDishEmployee_Price = new System.Windows.Forms.Label();
            this.lbItemDishEmployee_Amount = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rdItemDishEmployee_Done = new System.Windows.Forms.RadioButton();
            this.btItemDishEmployee_CanCel = new System.Windows.Forms.Button();
            this.rdItemDishEmployee_Working = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbItemDishEmployee_DishName = new System.Windows.Forms.Label();
            this.PbItemDish_Employee = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemDish_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbItemDish_Employee, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(84, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.02532F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.97468F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.rdo_click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel4.Controls.Add(this.lbItemDishEmployee_Price, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbItemDishEmployee_Amount, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(447, 24);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbItemDishEmployee_Price
            // 
            this.lbItemDishEmployee_Price.AutoSize = true;
            this.lbItemDishEmployee_Price.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbItemDishEmployee_Price.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemDishEmployee_Price.ForeColor = System.Drawing.Color.Blue;
            this.lbItemDishEmployee_Price.Location = new System.Drawing.Point(3, 0);
            this.lbItemDishEmployee_Price.Name = "lbItemDishEmployee_Price";
            this.lbItemDishEmployee_Price.Size = new System.Drawing.Size(51, 24);
            this.lbItemDishEmployee_Price.TabIndex = 0;
            this.lbItemDishEmployee_Price.Text = "33.000";
            // 
            // lbItemDishEmployee_Amount
            // 
            this.lbItemDishEmployee_Amount.AutoSize = true;
            this.lbItemDishEmployee_Amount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbItemDishEmployee_Amount.Location = new System.Drawing.Point(284, 4);
            this.lbItemDishEmployee_Amount.Name = "lbItemDishEmployee_Amount";
            this.lbItemDishEmployee_Amount.Size = new System.Drawing.Size(160, 20);
            this.lbItemDishEmployee_Amount.TabIndex = 1;
            this.lbItemDishEmployee_Amount.Text = "Số lượng: ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05404F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.377678F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78414F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78414F));
            this.tableLayoutPanel3.Controls.Add(this.rdItemDishEmployee_Done, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btItemDishEmployee_CanCel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdItemDishEmployee_Working, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(447, 43);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rdItemDishEmployee_Done
            // 
            this.rdItemDishEmployee_Done.AutoSize = true;
            this.rdItemDishEmployee_Done.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdItemDishEmployee_Done.Location = new System.Drawing.Point(406, 3);
            this.rdItemDishEmployee_Done.Name = "rdItemDishEmployee_Done";
            this.rdItemDishEmployee_Done.Size = new System.Drawing.Size(38, 37);
            this.rdItemDishEmployee_Done.TabIndex = 3;
            this.rdItemDishEmployee_Done.TabStop = true;
            this.rdItemDishEmployee_Done.Text = " ";
            this.rdItemDishEmployee_Done.UseVisualStyleBackColor = true;
            this.rdItemDishEmployee_Done.CheckedChanged += new System.EventHandler(this.Update);
            // 
            // btItemDishEmployee_CanCel
            // 
            this.btItemDishEmployee_CanCel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btItemDishEmployee_CanCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btItemDishEmployee_CanCel.Location = new System.Drawing.Point(258, 3);
            this.btItemDishEmployee_CanCel.Name = "btItemDishEmployee_CanCel";
            this.btItemDishEmployee_CanCel.Size = new System.Drawing.Size(26, 37);
            this.btItemDishEmployee_CanCel.TabIndex = 1;
            this.btItemDishEmployee_CanCel.Text = "X";
            this.btItemDishEmployee_CanCel.UseVisualStyleBackColor = true;
            this.btItemDishEmployee_CanCel.Click += new System.EventHandler(this.btItemDishEmployee_CanCel_Click_1);
            // 
            // rdItemDishEmployee_Working
            // 
            this.rdItemDishEmployee_Working.AutoSize = true;
            this.rdItemDishEmployee_Working.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdItemDishEmployee_Working.Location = new System.Drawing.Point(325, 3);
            this.rdItemDishEmployee_Working.Name = "rdItemDishEmployee_Working";
            this.rdItemDishEmployee_Working.Size = new System.Drawing.Size(38, 37);
            this.rdItemDishEmployee_Working.TabIndex = 2;
            this.rdItemDishEmployee_Working.TabStop = true;
            this.rdItemDishEmployee_Working.Text = " ";
            this.rdItemDishEmployee_Working.UseVisualStyleBackColor = true;
            this.rdItemDishEmployee_Working.CheckedChanged += new System.EventHandler(this.Update);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lbItemDishEmployee_DishName, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(249, 37);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // lbItemDishEmployee_DishName
            // 
            this.lbItemDishEmployee_DishName.AutoSize = true;
            this.lbItemDishEmployee_DishName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbItemDishEmployee_DishName.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemDishEmployee_DishName.Location = new System.Drawing.Point(3, 0);
            this.lbItemDishEmployee_DishName.Name = "lbItemDishEmployee_DishName";
            this.lbItemDishEmployee_DishName.Size = new System.Drawing.Size(185, 37);
            this.lbItemDishEmployee_DishName.TabIndex = 1;
            this.lbItemDishEmployee_DishName.Text = "Trà sữa hoa đậu biếc";
            // 
            // PbItemDish_Employee
            // 
            this.PbItemDish_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbItemDish_Employee.Location = new System.Drawing.Point(3, 3);
            this.PbItemDish_Employee.Name = "PbItemDish_Employee";
            this.PbItemDish_Employee.Size = new System.Drawing.Size(75, 79);
            this.PbItemDish_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbItemDish_Employee.TabIndex = 1;
            this.PbItemDish_Employee.TabStop = false;
            // 
            // ItemDish_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemDish_Employee";
            this.Size = new System.Drawing.Size(540, 85);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbItemDish_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbItemDishEmployee_Price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rdItemDishEmployee_Done;
        private System.Windows.Forms.Button btItemDishEmployee_CanCel;
        private System.Windows.Forms.RadioButton rdItemDishEmployee_Working;
        private System.Windows.Forms.PictureBox PbItemDish_Employee;
        private System.Windows.Forms.Label lbItemDishEmployee_Amount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbItemDishEmployee_DishName;
    }
}
