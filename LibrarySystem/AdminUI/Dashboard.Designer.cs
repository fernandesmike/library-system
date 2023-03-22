namespace LibrarySystem
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.flpBtnGrp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnViewBorrowers = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.iconBook = new System.Windows.Forms.PictureBox();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.flpBtnGrp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.viewReports = new System.Windows.Forms.FlowLayoutPanel();
            this.iconReports = new System.Windows.Forms.PictureBox();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBorrowersUI = new System.Windows.Forms.FlowLayoutPanel();
            this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalBorrowers = new System.Windows.Forms.Label();
            this.lblBorrowersCount = new System.Windows.Forms.Label();
            this.flpActive = new System.Windows.Forms.FlowLayoutPanel();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblActiveCount = new System.Windows.Forms.Label();
            this.flpInactive = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInactive = new System.Windows.Forms.Label();
            this.lblInactiveCount = new System.Windows.Forms.Label();
            this.flpDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.flpGridHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radioContainer = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.tmHideMessage = new System.Windows.Forms.Timer(this.components);
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
            this.flpBorrowersUI.SuspendLayout();
            this.flpStatistics.SuspendLayout();
            this.flpBorrowers.SuspendLayout();
            this.flpActive.SuspendLayout();
            this.flpInactive.SuspendLayout();
            this.flpDataGrid.SuspendLayout();
            this.flpGridHeader.SuspendLayout();
            this.radioContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.flpSearch.SuspendLayout();
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
            this.divLeft.TabIndex = 23;
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
            this.lblUserType.Text = "Admin";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpBtnGrp1
            // 
            this.flpBtnGrp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBtnGrp1.AutoSize = true;
            this.flpBtnGrp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBtnGrp1.Controls.Add(this.lblCategory1);
            this.flpBtnGrp1.Controls.Add(this.viewBorrowers);
            this.flpBtnGrp1.Controls.Add(this.viewBooks);
            this.flpBtnGrp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBtnGrp1.Location = new System.Drawing.Point(18, 207);
            this.flpBtnGrp1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flpBtnGrp1.Name = "flpBtnGrp1";
            this.flpBtnGrp1.Size = new System.Drawing.Size(219, 149);
            this.flpBtnGrp1.TabIndex = 35;
            // 
            // lblCategory1
            // 
            this.lblCategory1.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory1.Location = new System.Drawing.Point(3, 0);
            this.lblCategory1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(213, 24);
            this.lblCategory1.TabIndex = 39;
            this.lblCategory1.Text = "Masterfiles";
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBorrowers.BackColor = System.Drawing.Color.Transparent;
            this.viewBorrowers.Controls.Add(this.icoBorrower);
            this.viewBorrowers.Controls.Add(this.btnViewBorrowers);
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
            // btnViewBorrowers
            // 
            this.btnViewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewBorrowers.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBorrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewBorrowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBorrowers.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnViewBorrowers.FlatAppearance.BorderSize = 0;
            this.btnViewBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBorrowers.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBorrowers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnViewBorrowers.Location = new System.Drawing.Point(38, 0);
            this.btnViewBorrowers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewBorrowers.Name = "btnViewBorrowers";
            this.btnViewBorrowers.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewBorrowers.Size = new System.Drawing.Size(175, 44);
            this.btnViewBorrowers.TabIndex = 30;
            this.btnViewBorrowers.Text = "Borrowers";
            this.btnViewBorrowers.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewBorrowers.UseVisualStyleBackColor = false;
            this.btnViewBorrowers.Click += new System.EventHandler(this.BtnViewBorrowers_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBooks.AutoSize = true;
            this.viewBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBooks.Controls.Add(this.iconBook);
            this.viewBooks.Controls.Add(this.btnViewBooks);
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
            // btnViewBooks
            // 
            this.btnViewBooks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBooks.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnViewBooks.FlatAppearance.BorderSize = 0;
            this.btnViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBooks.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooks.Location = new System.Drawing.Point(38, 0);
            this.btnViewBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewBooks.Size = new System.Drawing.Size(175, 44);
            this.btnViewBooks.TabIndex = 36;
            this.btnViewBooks.Text = "Books";
            this.btnViewBooks.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewBooks.UseVisualStyleBackColor = false;
            this.btnViewBooks.Click += new System.EventHandler(this.BtnViewBooks_Click);
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
            this.viewReports.Controls.Add(this.btnViewReports);
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
            // btnViewReports
            // 
            this.btnViewReports.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewReports.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReports.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(38, 0);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewReports.Size = new System.Drawing.Size(175, 44);
            this.btnViewReports.TabIndex = 30;
            this.btnViewReports.Text = "Reports";
            this.btnViewReports.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.BtnViewReports_Click);
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
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogout_LinkClicked_1);
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblParagraph.Location = new System.Drawing.Point(3, 48);
            this.lblParagraph.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(279, 48);
            this.lblParagraph.TabIndex = 14;
            this.lblParagraph.Text = "Manage borrower accounts and\r\nview statistics";
            this.lblParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContext
            // 
            this.lblContext.AutoEllipsis = true;
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.lblContext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContext.Location = new System.Drawing.Point(3, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(163, 38);
            this.lblContext.TabIndex = 12;
            this.lblContext.Text = "Borrowers";
            this.lblContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpTitle
            // 
            this.flpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTitle.AutoSize = true;
            this.flpTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitle.Controls.Add(this.lblContext);
            this.flpTitle.Controls.Add(this.lblParagraph);
            this.flpTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitle.Location = new System.Drawing.Point(286, 21);
            this.flpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(285, 96);
            this.flpTitle.TabIndex = 33;
            // 
            // flpBorrowersUI
            // 
            this.flpBorrowersUI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBorrowersUI.Controls.Add(this.flpStatistics);
            this.flpBorrowersUI.Controls.Add(this.flpDataGrid);
            this.flpBorrowersUI.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBorrowersUI.Location = new System.Drawing.Point(289, 134);
            this.flpBorrowersUI.Name = "flpBorrowersUI";
            this.flpBorrowersUI.Size = new System.Drawing.Size(1044, 619);
            this.flpBorrowersUI.TabIndex = 35;
            // 
            // flpStatistics
            // 
            this.flpStatistics.AutoSize = true;
            this.flpStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpStatistics.Controls.Add(this.flpBorrowers);
            this.flpStatistics.Controls.Add(this.flpActive);
            this.flpStatistics.Controls.Add(this.flpInactive);
            this.flpStatistics.Location = new System.Drawing.Point(3, 3);
            this.flpStatistics.Name = "flpStatistics";
            this.flpStatistics.Size = new System.Drawing.Size(1038, 108);
            this.flpStatistics.TabIndex = 35;
            // 
            // flpBorrowers
            // 
            this.flpBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBorrowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpBorrowers.Controls.Add(this.lblTotalBorrowers);
            this.flpBorrowers.Controls.Add(this.lblBorrowersCount);
            this.flpBorrowers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBorrowers.Location = new System.Drawing.Point(3, 3);
            this.flpBorrowers.Name = "flpBorrowers";
            this.flpBorrowers.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpBorrowers.Size = new System.Drawing.Size(322, 102);
            this.flpBorrowers.TabIndex = 30;
            // 
            // lblTotalBorrowers
            // 
            this.lblTotalBorrowers.AutoSize = true;
            this.lblTotalBorrowers.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBorrowers.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTotalBorrowers.Location = new System.Drawing.Point(33, 15);
            this.lblTotalBorrowers.Name = "lblTotalBorrowers";
            this.lblTotalBorrowers.Size = new System.Drawing.Size(148, 24);
            this.lblTotalBorrowers.TabIndex = 29;
            this.lblTotalBorrowers.Text = "Total borrowers";
            this.lblTotalBorrowers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBorrowersCount
            // 
            this.lblBorrowersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorrowersCount.AutoEllipsis = true;
            this.lblBorrowersCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowersCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBorrowersCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBorrowersCount.Location = new System.Drawing.Point(33, 49);
            this.lblBorrowersCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBorrowersCount.Name = "lblBorrowersCount";
            this.lblBorrowersCount.Size = new System.Drawing.Size(259, 38);
            this.lblBorrowersCount.TabIndex = 30;
            this.lblBorrowersCount.Text = "25";
            this.lblBorrowersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpActive
            // 
            this.flpActive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpActive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpActive.Controls.Add(this.lblActive);
            this.flpActive.Controls.Add(this.lblActiveCount);
            this.flpActive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActive.Location = new System.Drawing.Point(358, 3);
            this.flpActive.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.flpActive.Name = "flpActive";
            this.flpActive.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpActive.Size = new System.Drawing.Size(322, 102);
            this.flpActive.TabIndex = 32;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblActive.Location = new System.Drawing.Point(33, 15);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(156, 24);
            this.lblActive.TabIndex = 29;
            this.lblActive.Text = "Active borrowers";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblActiveCount
            // 
            this.lblActiveCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActiveCount.AutoEllipsis = true;
            this.lblActiveCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblActiveCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblActiveCount.Location = new System.Drawing.Point(33, 49);
            this.lblActiveCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblActiveCount.Name = "lblActiveCount";
            this.lblActiveCount.Size = new System.Drawing.Size(259, 38);
            this.lblActiveCount.TabIndex = 30;
            this.lblActiveCount.Text = "23";
            this.lblActiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpInactive
            // 
            this.flpInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInactive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpInactive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpInactive.Controls.Add(this.lblInactive);
            this.flpInactive.Controls.Add(this.lblInactiveCount);
            this.flpInactive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInactive.Location = new System.Drawing.Point(713, 3);
            this.flpInactive.Name = "flpInactive";
            this.flpInactive.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpInactive.Size = new System.Drawing.Size(322, 102);
            this.flpInactive.TabIndex = 33;
            // 
            // lblInactive
            // 
            this.lblInactive.AutoSize = true;
            this.lblInactive.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactive.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblInactive.Location = new System.Drawing.Point(33, 15);
            this.lblInactive.Name = "lblInactive";
            this.lblInactive.Size = new System.Drawing.Size(169, 24);
            this.lblInactive.TabIndex = 29;
            this.lblInactive.Text = "Inactive borrowers";
            this.lblInactive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInactiveCount
            // 
            this.lblInactiveCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInactiveCount.AutoEllipsis = true;
            this.lblInactiveCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInactiveCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInactiveCount.Location = new System.Drawing.Point(33, 49);
            this.lblInactiveCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInactiveCount.Name = "lblInactiveCount";
            this.lblInactiveCount.Size = new System.Drawing.Size(259, 38);
            this.lblInactiveCount.TabIndex = 30;
            this.lblInactiveCount.Text = "2";
            this.lblInactiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpDataGrid
            // 
            this.flpDataGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.flpDataGrid.Controls.Add(this.lblUpdateMessage);
            this.flpDataGrid.Controls.Add(this.lblGridTitle);
            this.flpDataGrid.Controls.Add(this.datePicker);
            this.flpDataGrid.Controls.Add(this.flpGridHeader);
            this.flpDataGrid.Controls.Add(this.dataGrid);
            this.flpDataGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDataGrid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.flpDataGrid.Location = new System.Drawing.Point(0, 124);
            this.flpDataGrid.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(1041, 490);
            this.flpDataGrid.TabIndex = 36;
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoEllipsis = true;
            this.lblUpdateMessage.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUpdateMessage.Font = new System.Drawing.Font("Outfit SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMessage.ForeColor = System.Drawing.Color.White;
            this.lblUpdateMessage.Location = new System.Drawing.Point(3, 0);
            this.lblUpdateMessage.MinimumSize = new System.Drawing.Size(213, 31);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblUpdateMessage.Size = new System.Drawing.Size(1038, 31);
            this.lblUpdateMessage.TabIndex = 45;
            this.lblUpdateMessage.Text = "Update message goes here";
            this.lblUpdateMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpdateMessage.Visible = false;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoEllipsis = true;
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGridTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGridTitle.Location = new System.Drawing.Point(3, 36);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(139, 24);
            this.lblGridTitle.TabIndex = 39;
            this.lblGridTitle.Text = "All borrowers";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePicker
            // 
            this.datePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datePicker.Location = new System.Drawing.Point(3, 68);
            this.datePicker.MaxDate = new System.DateTime(2023, 3, 22, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 46;
            this.datePicker.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // flpGridHeader
            // 
            this.flpGridHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpGridHeader.Controls.Add(this.btnAdd);
            this.flpGridHeader.Controls.Add(this.radioContainer);
            this.flpGridHeader.Location = new System.Drawing.Point(3, 96);
            this.flpGridHeader.Name = "flpGridHeader";
            this.flpGridHeader.Size = new System.Drawing.Size(1035, 52);
            this.flpGridHeader.TabIndex = 38;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Outfit", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(0, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(190, 41);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "+ Add book";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // radioContainer
            // 
            this.radioContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radioContainer.Controls.Add(this.rbAll);
            this.radioContainer.Controls.Add(this.rbActive);
            this.radioContainer.Controls.Add(this.rbInactive);
            this.radioContainer.Location = new System.Drawing.Point(193, 3);
            this.radioContainer.Name = "radioContainer";
            this.radioContainer.Size = new System.Drawing.Size(832, 45);
            this.radioContainer.TabIndex = 39;
            // 
            // rbAll
            // 
            this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbAll.Location = new System.Drawing.Point(532, 10);
            this.rbAll.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(52, 23);
            this.rbAll.TabIndex = 35;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All ";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbActive.Location = new System.Drawing.Point(610, 10);
            this.rbActive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(83, 23);
            this.rbActive.TabIndex = 36;
            this.rbActive.Text = "Inactive";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.RbActive_CheckedChanged);
            // 
            // rbInactive
            // 
            this.rbInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbInactive.Location = new System.Drawing.Point(722, 10);
            this.rbInactive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(75, 23);
            this.rbInactive.TabIndex = 37;
            this.rbInactive.Text = "Active ";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.RbInactive_CheckedChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.GridColor = System.Drawing.Color.LightGray;
            this.dataGrid.Location = new System.Drawing.Point(3, 154);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowTemplate.DividerHeight = 1;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1038, 329);
            this.dataGrid.TabIndex = 40;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick_1);
            // 
            // searchContainer
            // 
            this.searchContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchContainer.AutoSize = true;
            this.searchContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchContainer.Controls.Add(this.iconSearch);
            this.searchContainer.Controls.Add(this.txtSearch);
            this.searchContainer.Location = new System.Drawing.Point(3, 44);
            this.searchContainer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(494, 41);
            this.searchContainer.TabIndex = 38;
            // 
            // iconSearch
            // 
            this.iconSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iconSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconSearch.Image = ((System.Drawing.Image)(resources.GetObject("iconSearch.Image")));
            this.iconSearch.Location = new System.Drawing.Point(3, 3);
            this.iconSearch.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.iconSearch.MaximumSize = new System.Drawing.Size(57, 57);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(25, 35);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSearch.TabIndex = 20;
            this.iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Outfit", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSearch.Location = new System.Drawing.Point(41, 3);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 35);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearch.Location = new System.Drawing.Point(3, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(162, 24);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search borrowers";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpSearch
            // 
            this.flpSearch.AutoSize = true;
            this.flpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSearch.Controls.Add(this.lblSearch);
            this.flpSearch.Controls.Add(this.searchContainer);
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearch.Location = new System.Drawing.Point(836, 21);
            this.flpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(500, 88);
            this.flpSearch.TabIndex = 37;
            // 
            // tmHideMessage
            // 
            this.tmHideMessage.Interval = 3000;
            this.tmHideMessage.Tick += new System.EventHandler(this.TmHideMessage_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.flpBorrowersUI);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.divLeft);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
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
            this.flpBorrowersUI.ResumeLayout(false);
            this.flpBorrowersUI.PerformLayout();
            this.flpStatistics.ResumeLayout(false);
            this.flpBorrowers.ResumeLayout(false);
            this.flpBorrowers.PerformLayout();
            this.flpActive.ResumeLayout(false);
            this.flpActive.PerformLayout();
            this.flpInactive.ResumeLayout(false);
            this.flpInactive.PerformLayout();
            this.flpDataGrid.ResumeLayout(false);
            this.flpDataGrid.PerformLayout();
            this.flpGridHeader.ResumeLayout(false);
            this.radioContainer.ResumeLayout(false);
            this.radioContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.searchContainer.ResumeLayout(false);
            this.searchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.flpSearch.ResumeLayout(false);
            this.flpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flpBtnGrp2;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.FlowLayoutPanel signout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flpBorrowers;
        private System.Windows.Forms.Label lblBorrowersCount;
        private System.Windows.Forms.FlowLayoutPanel flpActive;
        private System.Windows.Forms.Label lblActiveCount;
        private System.Windows.Forms.FlowLayoutPanel flpInactive;
        private System.Windows.Forms.Label lblInactiveCount;
        internal System.Windows.Forms.Button btnViewBooks;
        internal System.Windows.Forms.Button btnViewBorrowers;
        internal System.Windows.Forms.Button btnViewReports;
        internal System.Windows.Forms.PictureBox icoBorrower;
        internal System.Windows.Forms.PictureBox iconBook;
        internal System.Windows.Forms.PictureBox iconReports;
        internal System.Windows.Forms.FlowLayoutPanel viewBooks;
        internal System.Windows.Forms.FlowLayoutPanel viewReports;
        internal System.Windows.Forms.FlowLayoutPanel flpTitle;
        internal System.Windows.Forms.FlowLayoutPanel flpBorrowersUI;
        internal System.Windows.Forms.FlowLayoutPanel divLeft;
        internal System.Windows.Forms.Label lblParagraph;
        internal System.Windows.Forms.Label lblContext;
        internal System.Windows.Forms.FlowLayoutPanel flpDataGrid;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label lblSearch;
        internal System.Windows.Forms.FlowLayoutPanel flpSearch;
        internal System.Windows.Forms.FlowLayoutPanel flpStatistics;
        internal System.Windows.Forms.Label lblTotalBorrowers;
        internal System.Windows.Forms.Label lblActive;
        internal System.Windows.Forms.Label lblInactive;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.FlowLayoutPanel flpGridHeader;
        internal System.Windows.Forms.Label lblGridTitle;
        internal System.Windows.Forms.Panel radioContainer;
        internal System.Windows.Forms.RadioButton rbAll;
        internal System.Windows.Forms.RadioButton rbActive;
        internal System.Windows.Forms.RadioButton rbInactive;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.DataGridView dataGrid;
        internal System.Windows.Forms.FlowLayoutPanel flpBtnGrp1;
        private System.Windows.Forms.FlowLayoutPanel viewBorrowers;
        internal System.Windows.Forms.Label lblUpdateMessage;
        internal System.Windows.Forms.Timer tmHideMessage;
        internal System.Windows.Forms.DateTimePicker datePicker;
    }
}