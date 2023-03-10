namespace LibrarySystem
{
    partial class BorrowerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerInfo));
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.viewReports = new System.Windows.Forms.FlowLayoutPanel();
            this.iconEdit = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconStatus = new System.Windows.Forms.PictureBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.flpDelete = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flpStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalBorrowed = new System.Windows.Forms.Label();
            this.lblBorrowingCount = new System.Windows.Forms.Label();
            this.flpActive = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblBorrowedCount = new System.Windows.Forms.Label();
            this.flpInactive = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblReturnCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.flpDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.flpGridHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.radioContainer = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbBorrowed = new System.Windows.Forms.RadioButton();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.divLeft.SuspendLayout();
            this.viewBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).BeginInit();
            this.panel1.SuspendLayout();
            this.viewReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEdit)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).BeginInit();
            this.flpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flpStatistics.SuspendLayout();
            this.flpBorrowers.SuspendLayout();
            this.flpActive.SuspendLayout();
            this.flpInactive.SuspendLayout();
            this.flpDataGrid.SuspendLayout();
            this.flpGridHeader.SuspendLayout();
            this.radioContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAvatar
            // 
            this.imgAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(3, 20);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(399, 70);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 14;
            this.imgAvatar.TabStop = false;
            // 
            // infoContainer
            // 
            this.infoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblID);
            this.infoContainer.Controls.Add(this.lblUser);
            this.infoContainer.Controls.Add(this.lblUserType);
            this.infoContainer.Controls.Add(this.lblStatus);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(70, 93);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(261, 132);
            this.infoContainer.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblID.Location = new System.Drawing.Point(3, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(255, 24);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(3, 34);
            this.lblUser.MinimumSize = new System.Drawing.Size(213, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(258, 24);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Mike Andrew Fernandez";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUserType.Location = new System.Drawing.Point(3, 58);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(255, 24);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "Borrower";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(3, 92);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(255, 24);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Account active";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // divLeft
            // 
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divLeft.Controls.Add(this.viewBorrowers);
            this.divLeft.Controls.Add(this.panel1);
            this.divLeft.Controls.Add(this.lblCategory);
            this.divLeft.Controls.Add(this.viewReports);
            this.divLeft.Controls.Add(this.flowLayoutPanel1);
            this.divLeft.Controls.Add(this.lblWarning);
            this.divLeft.Controls.Add(this.flpDelete);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.MaximumSize = new System.Drawing.Size(620, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.divLeft.Size = new System.Drawing.Size(453, 753);
            this.divLeft.TabIndex = 28;
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewBorrowers.AutoSize = true;
            this.viewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBorrowers.BackColor = System.Drawing.Color.Transparent;
            this.viewBorrowers.Controls.Add(this.icoBorrower);
            this.viewBorrowers.Controls.Add(this.btnBack);
            this.viewBorrowers.Location = new System.Drawing.Point(18, 18);
            this.viewBorrowers.Name = "viewBorrowers";
            this.viewBorrowers.Size = new System.Drawing.Size(213, 44);
            this.viewBorrowers.TabIndex = 36;
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
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBack.Location = new System.Drawing.Point(38, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(5);
            this.btnBack.Size = new System.Drawing.Size(175, 44);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoContainer);
            this.panel1.Controls.Add(this.imgAvatar);
            this.panel1.Location = new System.Drawing.Point(18, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 227);
            this.panel1.TabIndex = 29;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(18, 345);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 30, 3, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(213, 24);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Actions";
            // 
            // viewReports
            // 
            this.viewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewReports.Controls.Add(this.iconEdit);
            this.viewReports.Controls.Add(this.btnEdit);
            this.viewReports.Location = new System.Drawing.Point(18, 379);
            this.viewReports.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.viewReports.Name = "viewReports";
            this.viewReports.Size = new System.Drawing.Size(402, 50);
            this.viewReports.TabIndex = 37;
            // 
            // iconEdit
            // 
            this.iconEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconEdit.Image = ((System.Drawing.Image)(resources.GetObject("iconEdit.Image")));
            this.iconEdit.Location = new System.Drawing.Point(3, 6);
            this.iconEdit.Name = "iconEdit";
            this.iconEdit.Size = new System.Drawing.Size(32, 32);
            this.iconEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEdit.TabIndex = 35;
            this.iconEdit.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(38, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(5);
            this.btnEdit.Size = new System.Drawing.Size(364, 44);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit account";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.iconStatus);
            this.flowLayoutPanel1.Controls.Add(this.btnStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 447);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 50);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // iconStatus
            // 
            this.iconStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconStatus.Image = ((System.Drawing.Image)(resources.GetObject("iconStatus.Image")));
            this.iconStatus.Location = new System.Drawing.Point(3, 6);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(32, 32);
            this.iconStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconStatus.TabIndex = 35;
            this.iconStatus.TabStop = false;
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(38, 0);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Padding = new System.Windows.Forms.Padding(5);
            this.btnStatus.Size = new System.Drawing.Size(364, 44);
            this.btnStatus.TabIndex = 30;
            this.btnStatus.Text = "Disable account";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWarning.Location = new System.Drawing.Point(18, 530);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3, 30, 3, 10);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(312, 48);
            this.lblWarning.TabIndex = 44;
            this.lblWarning.Text = "WARNING: \r\nDeleting accounts cannot be undone";
            // 
            // flpDelete
            // 
            this.flpDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDelete.Controls.Add(this.pictureBox2);
            this.flpDelete.Controls.Add(this.btnDelete);
            this.flpDelete.Location = new System.Drawing.Point(18, 598);
            this.flpDelete.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flpDelete.Name = "flpDelete";
            this.flpDelete.Size = new System.Drawing.Size(402, 50);
            this.flpDelete.TabIndex = 43;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(38, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(364, 44);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete account";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // flpStatistics
            // 
            this.flpStatistics.AutoSize = true;
            this.flpStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpStatistics.Controls.Add(this.flpBorrowers);
            this.flpStatistics.Controls.Add(this.flpActive);
            this.flpStatistics.Controls.Add(this.flpInactive);
            this.flpStatistics.Location = new System.Drawing.Point(482, 97);
            this.flpStatistics.Name = "flpStatistics";
            this.flpStatistics.Size = new System.Drawing.Size(840, 108);
            this.flpStatistics.TabIndex = 36;
            // 
            // flpBorrowers
            // 
            this.flpBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBorrowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpBorrowers.Controls.Add(this.lblTotalBorrowed);
            this.flpBorrowers.Controls.Add(this.lblBorrowingCount);
            this.flpBorrowers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBorrowers.Location = new System.Drawing.Point(3, 3);
            this.flpBorrowers.Name = "flpBorrowers";
            this.flpBorrowers.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpBorrowers.Size = new System.Drawing.Size(256, 102);
            this.flpBorrowers.TabIndex = 30;
            // 
            // lblTotalBorrowed
            // 
            this.lblTotalBorrowed.AutoSize = true;
            this.lblTotalBorrowed.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBorrowed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTotalBorrowed.Location = new System.Drawing.Point(33, 15);
            this.lblTotalBorrowed.Name = "lblTotalBorrowed";
            this.lblTotalBorrowed.Size = new System.Drawing.Size(147, 24);
            this.lblTotalBorrowed.TabIndex = 29;
            this.lblTotalBorrowed.Text = "Total borrowing";
            this.lblTotalBorrowed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBorrowingCount
            // 
            this.lblBorrowingCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorrowingCount.AutoEllipsis = true;
            this.lblBorrowingCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowingCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBorrowingCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBorrowingCount.Location = new System.Drawing.Point(33, 49);
            this.lblBorrowingCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBorrowingCount.Name = "lblBorrowingCount";
            this.lblBorrowingCount.Size = new System.Drawing.Size(156, 38);
            this.lblBorrowingCount.TabIndex = 30;
            this.lblBorrowingCount.Text = "25";
            this.lblBorrowingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpActive
            // 
            this.flpActive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpActive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpActive.Controls.Add(this.lblBorrowed);
            this.flpActive.Controls.Add(this.lblBorrowedCount);
            this.flpActive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActive.Location = new System.Drawing.Point(292, 3);
            this.flpActive.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.flpActive.Name = "flpActive";
            this.flpActive.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpActive.Size = new System.Drawing.Size(256, 102);
            this.flpActive.TabIndex = 32;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBorrowed.Location = new System.Drawing.Point(33, 15);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(149, 24);
            this.lblBorrowed.TabIndex = 29;
            this.lblBorrowed.Text = "Borrowed books";
            this.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBorrowedCount
            // 
            this.lblBorrowedCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorrowedCount.AutoEllipsis = true;
            this.lblBorrowedCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBorrowedCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBorrowedCount.Location = new System.Drawing.Point(33, 49);
            this.lblBorrowedCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBorrowedCount.Name = "lblBorrowedCount";
            this.lblBorrowedCount.Size = new System.Drawing.Size(156, 38);
            this.lblBorrowedCount.TabIndex = 30;
            this.lblBorrowedCount.Text = "23";
            this.lblBorrowedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpInactive
            // 
            this.flpInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInactive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpInactive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpInactive.Controls.Add(this.lblReturned);
            this.flpInactive.Controls.Add(this.lblReturnCount);
            this.flpInactive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInactive.Location = new System.Drawing.Point(581, 3);
            this.flpInactive.Name = "flpInactive";
            this.flpInactive.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.flpInactive.Size = new System.Drawing.Size(256, 102);
            this.flpInactive.TabIndex = 33;
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblReturned.Location = new System.Drawing.Point(33, 15);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(169, 24);
            this.lblReturned.TabIndex = 29;
            this.lblReturned.Text = "Inactive borrowers";
            this.lblReturned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReturnCount
            // 
            this.lblReturnCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReturnCount.AutoEllipsis = true;
            this.lblReturnCount.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReturnCount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblReturnCount.Location = new System.Drawing.Point(39, 49);
            this.lblReturnCount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblReturnCount.Name = "lblReturnCount";
            this.lblReturnCount.Size = new System.Drawing.Size(156, 38);
            this.lblReturnCount.TabIndex = 30;
            this.lblReturnCount.Text = "2";
            this.lblReturnCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(478, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 24);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Mike\'s statistics";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(481, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(168, 24);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "As of 11 - 23 - 2023";
            // 
            // flpDataGrid
            // 
            this.flpDataGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.flpDataGrid.Controls.Add(this.lblGridTitle);
            this.flpDataGrid.Controls.Add(this.flpGridHeader);
            this.flpDataGrid.Controls.Add(this.dataGridView1);
            this.flpDataGrid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.flpDataGrid.Location = new System.Drawing.Point(482, 223);
            this.flpDataGrid.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(840, 524);
            this.flpDataGrid.TabIndex = 39;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoEllipsis = true;
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGridTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGridTitle.Location = new System.Drawing.Point(3, 5);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(135, 24);
            this.lblGridTitle.TabIndex = 39;
            this.lblGridTitle.Text = "Transactions";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpGridHeader
            // 
            this.flpGridHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpGridHeader.Controls.Add(this.radioContainer);
            this.flpGridHeader.Location = new System.Drawing.Point(3, 37);
            this.flpGridHeader.Name = "flpGridHeader";
            this.flpGridHeader.Size = new System.Drawing.Size(1035, 52);
            this.flpGridHeader.TabIndex = 38;
            // 
            // radioContainer
            // 
            this.radioContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radioContainer.Controls.Add(this.rbAll);
            this.radioContainer.Controls.Add(this.rbBorrowed);
            this.radioContainer.Controls.Add(this.rbReturned);
            this.radioContainer.Location = new System.Drawing.Point(3, 3);
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
            this.rbAll.Location = new System.Drawing.Point(12, 10);
            this.rbAll.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(52, 23);
            this.rbAll.TabIndex = 35;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All ";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbBorrowed
            // 
            this.rbBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBorrowed.AutoSize = true;
            this.rbBorrowed.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrowed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbBorrowed.Location = new System.Drawing.Point(90, 10);
            this.rbBorrowed.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbBorrowed.Name = "rbBorrowed";
            this.rbBorrowed.Size = new System.Drawing.Size(95, 23);
            this.rbBorrowed.TabIndex = 36;
            this.rbBorrowed.Text = "Borrowed";
            this.rbBorrowed.UseVisualStyleBackColor = true;
            // 
            // rbReturned
            // 
            this.rbReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbReturned.AutoSize = true;
            this.rbReturned.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReturned.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbReturned.Location = new System.Drawing.Point(202, 10);
            this.rbReturned.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(92, 23);
            this.rbReturned.TabIndex = 37;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 429);
            this.dataGridView1.TabIndex = 41;
            // 
            // BorrowerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.flpDataGrid);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpStatistics);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BorrowerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerInfo";
            this.Load += new System.EventHandler(this.BorrowerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.divLeft.ResumeLayout(false);
            this.divLeft.PerformLayout();
            this.viewBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).EndInit();
            this.panel1.ResumeLayout(false);
            this.viewReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconEdit)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).EndInit();
            this.flpDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.FlowLayoutPanel divLeft;
        internal System.Windows.Forms.FlowLayoutPanel viewBorrowers;
        internal System.Windows.Forms.PictureBox icoBorrower;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.FlowLayoutPanel flpStatistics;
        private System.Windows.Forms.FlowLayoutPanel flpBorrowers;
        internal System.Windows.Forms.Label lblTotalBorrowed;
        private System.Windows.Forms.Label lblBorrowingCount;
        private System.Windows.Forms.FlowLayoutPanel flpActive;
        internal System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblBorrowedCount;
        private System.Windows.Forms.FlowLayoutPanel flpInactive;
        internal System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblReturnCount;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.FlowLayoutPanel flpDataGrid;
        internal System.Windows.Forms.Label lblGridTitle;
        internal System.Windows.Forms.FlowLayoutPanel flpGridHeader;
        internal System.Windows.Forms.Panel radioContainer;
        internal System.Windows.Forms.RadioButton rbAll;
        internal System.Windows.Forms.RadioButton rbBorrowed;
        internal System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.FlowLayoutPanel viewReports;
        internal System.Windows.Forms.PictureBox iconEdit;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.PictureBox iconStatus;
        internal System.Windows.Forms.Button btnStatus;
        internal System.Windows.Forms.FlowLayoutPanel flpDelete;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.Label lblWarning;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.PictureBox imgAvatar;
        internal System.Windows.Forms.Label lblUserType;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblID;
    }
}