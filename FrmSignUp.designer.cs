namespace ProjectGroup03_63KTPM2_Version01
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFrmSignUp_inform = new System.Windows.Forms.Label();
            this.btFrmSignUp_signUp = new System.Windows.Forms.Button();
            this.btFrmSignUp_signIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFrmSignUp_confirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrmSignUp_user = new System.Windows.Forms.TextBox();
            this.tbFrmSignUp_pass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.lbFrmSignUp_inform);
            this.panel2.Controls.Add(this.btFrmSignUp_signUp);
            this.panel2.Controls.Add(this.btFrmSignUp_signIn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbFrmSignUp_confirmPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbFrmSignUp_user);
            this.panel2.Controls.Add(this.tbFrmSignUp_pass);
            this.panel2.Location = new System.Drawing.Point(27, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 360);
            this.panel2.TabIndex = 34;
            // 
            // lbFrmSignUp_inform
            // 
            this.lbFrmSignUp_inform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrmSignUp_inform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFrmSignUp_inform.Location = new System.Drawing.Point(121, 187);
            this.lbFrmSignUp_inform.Name = "lbFrmSignUp_inform";
            this.lbFrmSignUp_inform.Size = new System.Drawing.Size(291, 13);
            this.lbFrmSignUp_inform.TabIndex = 34;
            this.lbFrmSignUp_inform.Text = "label5";
            this.lbFrmSignUp_inform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFrmSignUp_inform.Visible = false;
            // 
            // btFrmSignUp_signUp
            // 
            this.btFrmSignUp_signUp.BackColor = System.Drawing.Color.Gray;
            this.btFrmSignUp_signUp.ForeColor = System.Drawing.SystemColors.Window;
            this.btFrmSignUp_signUp.Location = new System.Drawing.Point(139, 220);
            this.btFrmSignUp_signUp.Name = "btFrmSignUp_signUp";
            this.btFrmSignUp_signUp.Size = new System.Drawing.Size(101, 48);
            this.btFrmSignUp_signUp.TabIndex = 33;
            this.btFrmSignUp_signUp.Text = "Đăng kí";
            this.btFrmSignUp_signUp.UseVisualStyleBackColor = false;
            this.btFrmSignUp_signUp.Click += new System.EventHandler(this.btFrmSignUp_signUp_Click);
            // 
            // btFrmSignUp_signIn
            // 
            this.btFrmSignUp_signIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btFrmSignUp_signIn.BackColor = System.Drawing.Color.Gray;
            this.btFrmSignUp_signIn.ForeColor = System.Drawing.SystemColors.Window;
            this.btFrmSignUp_signIn.Location = new System.Drawing.Point(294, 220);
            this.btFrmSignUp_signIn.Name = "btFrmSignUp_signIn";
            this.btFrmSignUp_signIn.Size = new System.Drawing.Size(101, 48);
            this.btFrmSignUp_signIn.TabIndex = 32;
            this.btFrmSignUp_signIn.Text = "Đăng nhập";
            this.btFrmSignUp_signIn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "ĐĂNG KÍ TÀI KHOẢN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // tbFrmSignUp_confirmPass
            // 
            this.tbFrmSignUp_confirmPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFrmSignUp_confirmPass.Location = new System.Drawing.Point(121, 151);
            this.tbFrmSignUp_confirmPass.Name = "tbFrmSignUp_confirmPass";
            this.tbFrmSignUp_confirmPass.Size = new System.Drawing.Size(291, 20);
            this.tbFrmSignUp_confirmPass.TabIndex = 29;
            this.tbFrmSignUp_confirmPass.TextChanged += new System.EventHandler(this.passChange);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "User";
            // 
            // tbFrmSignUp_user
            // 
            this.tbFrmSignUp_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFrmSignUp_user.Location = new System.Drawing.Point(121, 97);
            this.tbFrmSignUp_user.Name = "tbFrmSignUp_user";
            this.tbFrmSignUp_user.Size = new System.Drawing.Size(291, 20);
            this.tbFrmSignUp_user.TabIndex = 26;
            // 
            // tbFrmSignUp_pass
            // 
            this.tbFrmSignUp_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFrmSignUp_pass.Location = new System.Drawing.Point(121, 125);
            this.tbFrmSignUp_pass.Name = "tbFrmSignUp_pass";
            this.tbFrmSignUp_pass.Size = new System.Drawing.Size(291, 20);
            this.tbFrmSignUp_pass.TabIndex = 25;
            this.tbFrmSignUp_pass.TextChanged += new System.EventHandler(this.passChange);
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÍ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.dangki_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFrmSignUp_signIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFrmSignUp_confirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrmSignUp_user;
        private System.Windows.Forms.TextBox tbFrmSignUp_pass;
        private System.Windows.Forms.Button btFrmSignUp_signUp;
        private System.Windows.Forms.Label lbFrmSignUp_inform;
    }
}

