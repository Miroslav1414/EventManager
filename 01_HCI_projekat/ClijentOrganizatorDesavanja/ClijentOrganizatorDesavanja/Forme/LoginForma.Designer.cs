namespace ClijentOrganizatorDesavanja
{
    partial class LoginForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForma));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelaKorisnickoIme = new System.Windows.Forms.Label();
            this.labelaLozinka = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 62);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(309, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 141);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(356, 200);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 34);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelaKorisnickoIme
            // 
            this.labelaKorisnickoIme.AutoSize = true;
            this.labelaKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.labelaKorisnickoIme.ForeColor = System.Drawing.Color.Navy;
            this.labelaKorisnickoIme.Location = new System.Drawing.Point(114, 34);
            this.labelaKorisnickoIme.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelaKorisnickoIme.Name = "labelaKorisnickoIme";
            this.labelaKorisnickoIme.Size = new System.Drawing.Size(111, 19);
            this.labelaKorisnickoIme.TabIndex = 3;
            this.labelaKorisnickoIme.Text = "Korisnicko ime";
            // 
            // labelaLozinka
            // 
            this.labelaLozinka.AutoSize = true;
            this.labelaLozinka.BackColor = System.Drawing.Color.Transparent;
            this.labelaLozinka.ForeColor = System.Drawing.Color.Navy;
            this.labelaLozinka.Location = new System.Drawing.Point(114, 107);
            this.labelaLozinka.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelaLozinka.Name = "labelaLozinka";
            this.labelaLozinka.Size = new System.Drawing.Size(63, 19);
            this.labelaLozinka.TabIndex = 4;
            this.labelaLozinka.Text = "Lozinka";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Location = new System.Drawing.Point(52, 200);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 34);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Registruj se";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginForma
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 307);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelaLozinka);
            this.Controls.Add(this.labelaKorisnickoIme);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForma";
            this.Load += new System.EventHandler(this.LoginForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelaKorisnickoIme;
        private System.Windows.Forms.Label labelaLozinka;
        private System.Windows.Forms.Button btnRegister;
    }
}