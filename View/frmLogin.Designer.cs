namespace BankingApplication.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            System.Windows.Forms.Button btnLogin;
            this.txtNoRek = new System.Windows.Forms.TextBox();
            this.lblNoRek = new System.Windows.Forms.Label();
            this.ptrLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoRek
            // 
            this.txtNoRek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRek.Location = new System.Drawing.Point(166, 343);
            this.txtNoRek.Name = "txtNoRek";
            this.txtNoRek.Size = new System.Drawing.Size(671, 56);
            this.txtNoRek.TabIndex = 0;
            // 
            // lblNoRek
            // 
            this.lblNoRek.AutoSize = true;
            this.lblNoRek.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRek.Location = new System.Drawing.Point(169, 292);
            this.lblNoRek.Name = "lblNoRek";
            this.lblNoRek.Size = new System.Drawing.Size(262, 38);
            this.lblNoRek.TabIndex = 2;
            this.lblNoRek.Text = "Nomor Rekening";
            // 
            // ptrLogo
            // 
            this.ptrLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptrLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptrLogo.Image")));
            this.ptrLogo.Location = new System.Drawing.Point(380, 12);
            this.ptrLogo.Name = "ptrLogo";
            this.ptrLogo.Size = new System.Drawing.Size(255, 254);
            this.ptrLogo.TabIndex = 3;
            this.ptrLogo.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(166, 453);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(671, 53);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(169, 412);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(162, 38);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(89)))), ((int)(((byte)(63)))));
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(170)))));
            btnLogin.Location = new System.Drawing.Point(166, 530);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(671, 72);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(228)))), ((int)(((byte)(212)))));
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(166, 608);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(671, 72);
            this.btnDaftar.TabIndex = 6;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(202)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1019, 726);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ptrLogo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNoRek);
            this.Controls.Add(this.txtNoRek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.ptrLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoRek;
        private System.Windows.Forms.Label lblNoRek;
        private System.Windows.Forms.PictureBox ptrLogo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDaftar;
    }
}