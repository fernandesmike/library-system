namespace LibrarySystem
{
    partial class Borrower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrower));
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.flpBtnGrp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.iconBook = new System.Windows.Forms.PictureBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.flpBtnGrp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.viewReports = new System.Windows.Forms.FlowLayoutPanel();
            this.iconReports = new System.Windows.Forms.PictureBox();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.divLeft.SuspendLayout();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.flpBtnGrp1.SuspendLayout();
            this.viewBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).BeginInit();
            this.viewBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBook)).BeginInit();
            this.flpBtnGrp2.SuspendLayout();
            this.viewReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconReports)).BeginInit();
            this.signout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // divLeft
            // 
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divLeft.Controls.Add(this.userInfoContainer);
            this.divLeft.Controls.Add(this.flpBtnGrp1);
            this.divLeft.Controls.Add(this.flpBtnGrp2);
            this.divLeft.Controls.Add(this.signout);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.MaximumSize = new System.Drawing.Size(620, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.divLeft.Size = new System.Drawing.Size(256, 753);
            this.divLeft.TabIndex = 24;
            // 
            // userInfoContainer
            // 
            this.userInfoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInfoContainer.AutoSize = true;
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.imgAvatar);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userInfoContainer.Location = new System.Drawing.Point(19, 18);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(216, 156);
            this.userInfoContainer.TabIndex = 26;
            this.userInfoContainer.WrapContents = false;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(73, 3);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(70, 70);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 14;
            this.imgAvatar.TabStop = false;
            // 
            // infoContainer
            // 
            this.infoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblUser);
            this.infoContainer.Controls.Add(this.lblUserType);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(0, 76);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(216, 80);
            this.infoContainer.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(3, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(213, 30);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Welcome, Mike!";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUserType.Location = new System.Drawing.Point(3, 40);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(213, 24);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "Borrower";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpBtnGrp1
            // 
            this.flpBtnGrp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBtnGrp1.AutoSize = true;
            this.flpBtnGrp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBtnGrp1.Controls.Add(this.lblCategory);
            this.flpBtnGrp1.Controls.Add(this.viewBorrowers);
            this.flpBtnGrp1.Controls.Add(this.viewBooks);
            this.flpBtnGrp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBtnGrp1.Location = new System.Drawing.Point(18, 207);
            this.flpBtnGrp1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flpBtnGrp1.Name = "flpBtnGrp1";
            this.flpBtnGrp1.Size = new System.Drawing.Size(219, 149);
            this.flpBtnGrp1.TabIndex = 35;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(213, 24);
            this.lblCategory.TabIndex = 39;
            this.lblCategory.Text = "Transaction";
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBorrowers.BackColor = System.Drawing.Color.Transparent;
            this.viewBorrowers.Controls.Add(this.icoBorrower);
            this.viewBorrowers.Controls.Add(this.btnDashboard);
            this.viewBorrowers.Location = new System.Drawing.Point(3, 42);
            this.viewBorrowers.Name = "viewBorrowers";
            this.viewBorrowers.Size = new System.Drawing.Size(213, 50);
            this.viewBorrowers.TabIndex = 35;
            // 
            // icoBorrower
            // 
            this.icoBorrower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icoBorrower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoBorrower.BackgroundImage")));
            this.icoBorrower.ErrorImage = null;
            this.icoBorrower.Image = ((System.Drawing.Image)(resources.GetObject("icoBorrower.Image")));
            this.icoBorrower.InitialImage = ((System.Drawing.Image)(resources.GetObject("icoBorrower.InitialImage")));
            this.icoBorrower.Location = new System.Drawing.Point(3, 6);
            this.icoBorrower.Name = "icoBorrower";
            this.icoBorrower.Size = new System.Drawing.Size(32, 32);
            this.icoBorrower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoBorrower.TabIndex = 35;
            this.icoBorrower.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDashboard.Location = new System.Drawing.Point(38, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Size = new System.Drawing.Size(175, 44);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // viewBooks
            // 
            this.viewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBooks.AutoSize = true;
            this.viewBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBooks.Controls.Add(this.iconBook);
            this.viewBooks.Controls.Add(this.btnBooks);
            this.viewBooks.Location = new System.Drawing.Point(0, 105);
            this.viewBooks.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(219, 44);
            this.viewBooks.TabIndex = 37;
            // 
            // iconBook
            // 
            this.iconBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBook.Image = ((System.Drawing.Image)(resources.GetObject("iconBook.Image")));
            this.iconBook.Location = new System.Drawing.Point(3, 6);
            this.iconBook.Name = "iconBook";
            this.iconBook.Size = new System.Drawing.Size(32, 32);
            this.iconBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBook.TabIndex = 35;
            this.iconBook.TabStop = false;
            // 
            // btnBooks
            // 
            this.btnBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(38, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(5);
            this.btnBooks.Size = new System.Drawing.Size(175, 44);
            this.btnBooks.TabIndex = 36;
            this.btnBooks.Text = "My books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // flpBtnGrp2
            // 
            this.flpBtnGrp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBtnGrp2.AutoSize = true;
            this.flpBtnGrp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBtnGrp2.Controls.Add(this.lblCategory2);
            this.flpBtnGrp2.Controls.Add(this.viewReports);
            this.flpBtnGrp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBtnGrp2.Location = new System.Drawing.Point(18, 389);
            this.flpBtnGrp2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flpBtnGrp2.Name = "flpBtnGrp2";
            this.flpBtnGrp2.Size = new System.Drawing.Size(219, 95);
            this.flpBtnGrp2.TabIndex = 36;
            // 
            // lblCategory2
            // 
            this.lblCategory2.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory2.Location = new System.Drawing.Point(3, 0);
            this.lblCategory2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(213, 24);
            this.lblCategory2.TabIndex = 40;
            this.lblCategory2.Text = "System";
            // 
            // viewReports
            // 
            this.viewReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewReports.Controls.Add(this.iconReports);
            this.viewReports.Controls.Add(this.btnViewProfile);
            this.viewReports.Location = new System.Drawing.Point(3, 42);
            this.viewReports.Name = "viewReports";
            this.viewReports.Size = new System.Drawing.Size(213, 50);
            this.viewReports.TabIndex = 35;
            // 
            // iconReports
            // 
            this.iconReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconReports.Image = ((System.Drawing.Image)(resources.GetObject("iconReports.Image")));
            this.iconReports.Location = new System.Drawing.Point(3, 6);
            this.iconReports.Name = "iconReports";
            this.iconReports.Size = new System.Drawing.Size(32, 32);
            this.iconReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconReports.TabIndex = 35;
            this.iconReports.TabStop = false;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(38, 0);
            this.btnViewProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewProfile.Size = new System.Drawing.Size(175, 44);
            this.btnViewProfile.TabIndex = 30;
            this.btnViewProfile.Text = "Profile";
            this.btnViewProfile.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewProfile.UseVisualStyleBackColor = false;
            // 
            // signout
            // 
            this.signout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.signout.AutoSize = true;
            this.signout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signout.Controls.Add(this.pictureBox4);
            this.signout.Controls.Add(this.btnLogout);
            this.signout.Location = new System.Drawing.Point(15, 687);
            this.signout.Margin = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(225, 38);
            this.signout.TabIndex = 38;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveLinkColor = System.Drawing.Color.Brown;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnLogout.LinkColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(41, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnLogout.Size = new System.Drawing.Size(181, 38);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Signout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpTitle
            // 
            this.flpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTitle.AutoSize = true;
            this.flpTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitle.Controls.Add(this.lblContext);
            this.flpTitle.Controls.Add(this.lblParagraph);
            this.flpTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitle.Location = new System.Drawing.Point(285, 21);
            this.flpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(278, 72);
            this.flpTitle.TabIndex = 34;
            // 
            // lblContext
            // 
            this.lblContext.AutoEllipsis = true;
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.lblContext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContext.Location = new System.Drawing.Point(3, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(173, 38);
            this.lblContext.TabIndex = 12;
            this.lblContext.Text = "Dashboard";
            this.lblContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblParagraph.Location = new System.Drawing.Point(3, 48);
            this.lblParagraph.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(272, 24);
            this.lblParagraph.TabIndex = 14;
            this.lblParagraph.Text = "Manage your books and profile";
            this.lblParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.divLeft.ResumeLayout(false);
            this.divLeft.PerformLayout();
            this.userInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.flpBtnGrp1.ResumeLayout(false);
            this.flpBtnGrp1.PerformLayout();
            this.viewBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).EndInit();
            this.viewBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBook)).EndInit();
            this.flpBtnGrp2.ResumeLayout(false);
            this.viewReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconReports)).EndInit();
            this.signout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flpTitle.ResumeLayout(false);
            this.flpTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel divLeft;
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        internal System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserType;
        internal System.Windows.Forms.FlowLayoutPanel flpBtnGrp1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel viewBorrowers;
        internal System.Windows.Forms.PictureBox icoBorrower;
        internal System.Windows.Forms.Button btnDashboard;
        internal System.Windows.Forms.FlowLayoutPanel viewBooks;
        internal System.Windows.Forms.PictureBox iconBook;
        internal System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.FlowLayoutPanel flpBtnGrp2;
        private System.Windows.Forms.Label lblCategory2;
        internal System.Windows.Forms.FlowLayoutPanel viewReports;
        internal System.Windows.Forms.PictureBox iconReports;
        internal System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.FlowLayoutPanel signout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel btnLogout;
        internal System.Windows.Forms.FlowLayoutPanel flpTitle;
        internal System.Windows.Forms.Label lblContext;
        internal System.Windows.Forms.Label lblParagraph;
    }
}