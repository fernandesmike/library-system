namespace LibrarySystem.AdminUI
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.paragraph = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.btnBorrowerLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // appLogo
            // 
            this.appLogo.BackColor = System.Drawing.SystemColors.Control;
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("appLogo.InitialImage")));
            this.appLogo.Location = new System.Drawing.Point(192, 23);
            this.appLogo.Margin = new System.Windows.Forms.Padding(2);
            this.appLogo.Name = "appLogo";
            this.appLogo.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.appLogo.Size = new System.Drawing.Size(75, 81);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 30;
            this.appLogo.TabStop = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(93, 306);
            this.lblErrorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(84, 15);
            this.lblErrorName.TabIndex = 29;
            this.lblErrorName.Text = "Error message";
            this.lblErrorName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorName.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(94, 433);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(273, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.txtPass.Location = new System.Drawing.Point(93, 368);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(274, 47);
            this.txtPass.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(93, 255);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(274, 47);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(93, 337);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 19);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(93, 224);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 19);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // paragraph
            // 
            this.paragraph.AutoSize = true;
            this.paragraph.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paragraph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.paragraph.Location = new System.Drawing.Point(106, 155);
            this.paragraph.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paragraph.Name = "paragraph";
            this.paragraph.Size = new System.Drawing.Size(268, 19);
            this.paragraph.TabIndex = 22;
            this.paragraph.Text = "Please login to your account to continue";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Outfit", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(137, 120);
            this.header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(210, 28);
            this.header.TabIndex = 21;
            this.header.Text = "System admin login";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBorrowerLogin
            // 
            this.btnBorrowerLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBorrowerLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrowerLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrowerLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrowerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowerLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBorrowerLogin.FlatAppearance.BorderSize = 0;
            this.btnBorrowerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerLogin.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerLogin.Location = new System.Drawing.Point(96, 493);
            this.btnBorrowerLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrowerLogin.Name = "btnBorrowerLogin";
            this.btnBorrowerLogin.Padding = new System.Windows.Forms.Padding(4);
            this.btnBorrowerLogin.Size = new System.Drawing.Size(269, 36);
            this.btnBorrowerLogin.TabIndex = 4;
            this.btnBorrowerLogin.Text = "Login as borrower";
            this.btnBorrowerLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrowerLogin.UseVisualStyleBackColor = false;
            this.btnBorrowerLogin.Click += new System.EventHandler(this.BtnBorrowerLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 579);
            this.Controls.Add(this.btnBorrowerLogin);
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.paragraph);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label paragraph;
        private System.Windows.Forms.Label header;
        internal System.Windows.Forms.Button btnBorrowerLogin;
    }
}