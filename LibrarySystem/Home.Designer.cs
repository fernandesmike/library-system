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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.titleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.authorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.flpBtnGrp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnViewBorrowers = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.flpBtnGrp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.signout = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flpHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnContainer.SuspendLayout();
            this.divLeft.SuspendLayout();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.gbAddBook.SuspendLayout();
            this.titleContainer.SuspendLayout();
            this.authorContainer.SuspendLayout();
            this.divRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.flpBtnGrp1.SuspendLayout();
            this.viewBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).BeginInit();
            this.viewBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpBtnGrp2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.signout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flpHeader.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(240, 50);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit book";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(284, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 50);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete book";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnDelete);
            this.btnContainer.Controls.Add(this.btnEdit);
            this.btnContainer.Location = new System.Drawing.Point(485, 219);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(524, 55);
            this.btnContainer.TabIndex = 22;
            // 
            // divLeft
            // 
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.Transparent;
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
            // btnLogout
            // 
            this.btnLogout.ActiveLinkColor = System.Drawing.Color.Brown;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnLogout.LinkColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(41, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnLogout.Size = new System.Drawing.Size(134, 38);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Signout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogout_LinkClicked_1);
            // 
            // gbAddBook
            // 
            this.gbAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddBook.AutoSize = true;
            this.gbAddBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAddBook.Controls.Add(this.btnAdd);
            this.gbAddBook.Controls.Add(this.titleContainer);
            this.gbAddBook.Controls.Add(this.authorContainer);
            this.gbAddBook.Font = new System.Drawing.Font("Outfit", 9F);
            this.gbAddBook.Location = new System.Drawing.Point(760, 351);
            this.gbAddBook.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.gbAddBook.Size = new System.Drawing.Size(524, 341);
            this.gbAddBook.TabIndex = 26;
            this.gbAddBook.TabStop = false;
            this.gbAddBook.Text = "Add book";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(7, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(504, 50);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add book";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // titleContainer
            // 
            this.titleContainer.AutoSize = true;
            this.titleContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleContainer.Controls.Add(this.lblTitle);
            this.titleContainer.Controls.Add(this.txtTitle);
            this.titleContainer.Controls.Add(this.lblErrorTitle);
            this.titleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleContainer.Location = new System.Drawing.Point(7, 36);
            this.titleContainer.Name = "titleContainer";
            this.titleContainer.Size = new System.Drawing.Size(504, 109);
            this.titleContainer.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 19);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Book title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(3, 32);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(498, 45);
            this.txtTitle.TabIndex = 19;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(3, 80);
            this.lblErrorTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(106, 19);
            this.lblErrorTitle.TabIndex = 20;
            this.lblErrorTitle.Text = "Error message";
            this.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorTitle.Visible = false;
            // 
            // authorContainer
            // 
            this.authorContainer.AutoSize = true;
            this.authorContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorContainer.Controls.Add(this.lblAuthor);
            this.authorContainer.Controls.Add(this.txtAuthor);
            this.authorContainer.Controls.Add(this.lblErrorAuthor);
            this.authorContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorContainer.Location = new System.Drawing.Point(7, 144);
            this.authorContainer.Name = "authorContainer";
            this.authorContainer.Size = new System.Drawing.Size(504, 109);
            this.authorContainer.TabIndex = 25;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAuthor.Location = new System.Drawing.Point(3, 0);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(55, 19);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(3, 32);
            this.txtAuthor.MaxLength = 20;
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(498, 45);
            this.txtAuthor.TabIndex = 19;
            // 
            // lblErrorAuthor
            // 
            this.lblErrorAuthor.AutoSize = true;
            this.lblErrorAuthor.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblErrorAuthor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAuthor.Location = new System.Drawing.Point(3, 80);
            this.lblErrorAuthor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblErrorAuthor.Name = "lblErrorAuthor";
            this.lblErrorAuthor.Size = new System.Drawing.Size(106, 19);
            this.lblErrorAuthor.TabIndex = 20;
            this.lblErrorAuthor.Text = "Error message";
            this.lblErrorAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorAuthor.Visible = false;
            // 
            // divRight
            // 
            this.divRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divRight.Controls.Add(this.dataGrid);
            this.divRight.Location = new System.Drawing.Point(1044, 243);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(240, 185);
            this.divRight.TabIndex = 24;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Outfit SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(740, 394);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
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
            this.flpBtnGrp1.Size = new System.Drawing.Size(219, 154);
            this.flpBtnGrp1.TabIndex = 35;
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            // 
            // viewBooks
            // 
            this.viewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBooks.AutoSize = true;
            this.viewBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBooks.Controls.Add(this.pictureBox1);
            this.viewBooks.Controls.Add(this.btnViewBooks);
            this.viewBooks.Location = new System.Drawing.Point(0, 110);
            this.viewBooks.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(219, 44);
            this.viewBooks.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
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
            // 
            // flpBtnGrp2
            // 
            this.flpBtnGrp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBtnGrp2.AutoSize = true;
            this.flpBtnGrp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpBtnGrp2.Controls.Add(this.lblCategory2);
            this.flpBtnGrp2.Controls.Add(this.flowLayoutPanel2);
            this.flpBtnGrp2.Controls.Add(this.flowLayoutPanel3);
            this.flpBtnGrp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBtnGrp2.Location = new System.Drawing.Point(18, 394);
            this.flpBtnGrp2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flpBtnGrp2.Name = "flpBtnGrp2";
            this.flpBtnGrp2.Size = new System.Drawing.Size(219, 154);
            this.flpBtnGrp2.TabIndex = 36;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Controls.Add(this.btnViewReports);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(213, 50);
            this.flowLayoutPanel2.TabIndex = 35;
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
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel3.Controls.Add(this.btnViewTransactions);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 110);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(219, 44);
            this.flowLayoutPanel3.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewTransactions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnViewTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTransactions.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnViewTransactions.FlatAppearance.BorderSize = 0;
            this.btnViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTransactions.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTransactions.Location = new System.Drawing.Point(38, 0);
            this.btnViewTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewTransactions.Size = new System.Drawing.Size(175, 44);
            this.btnViewTransactions.TabIndex = 36;
            this.btnViewTransactions.Text = "Transactions";
            this.btnViewTransactions.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewTransactions.UseVisualStyleBackColor = false;
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
            // signout
            // 
            this.signout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.signout.AutoSize = true;
            this.signout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signout.Controls.Add(this.pictureBox4);
            this.signout.Controls.Add(this.btnLogout);
            this.signout.Location = new System.Drawing.Point(15, 566);
            this.signout.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
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
            // flpHeader
            // 
            this.flpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpHeader.AutoSize = true;
            this.flpHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpHeader.Controls.Add(this.gbSearch);
            this.flpHeader.Location = new System.Drawing.Point(295, 0);
            this.flpHeader.Name = "flpHeader";
            this.flpHeader.Size = new System.Drawing.Size(514, 112);
            this.flpHeader.TabIndex = 28;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.AutoSize = true;
            this.gbSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSearch.Controls.Add(this.searchContainer);
            this.gbSearch.Font = new System.Drawing.Font("Outfit", 9F);
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.gbSearch.Size = new System.Drawing.Size(514, 112);
            this.gbSearch.TabIndex = 28;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search book";
            // 
            // searchContainer
            // 
            this.searchContainer.AutoSize = true;
            this.searchContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchContainer.Controls.Add(this.iconSearch);
            this.searchContainer.Controls.Add(this.txtSearch);
            this.searchContainer.Location = new System.Drawing.Point(7, 34);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(494, 51);
            this.searchContainer.TabIndex = 24;
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
            this.iconSearch.Size = new System.Drawing.Size(25, 45);
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
            this.txtSearch.Size = new System.Drawing.Size(450, 45);
            this.txtSearch.TabIndex = 19;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.flpHeader);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.gbAddBook);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1360, 800);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.btnContainer.ResumeLayout(false);
            this.divLeft.ResumeLayout(false);
            this.divLeft.PerformLayout();
            this.userInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            this.titleContainer.ResumeLayout(false);
            this.titleContainer.PerformLayout();
            this.authorContainer.ResumeLayout(false);
            this.authorContainer.PerformLayout();
            this.divRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.flpBtnGrp1.ResumeLayout(false);
            this.flpBtnGrp1.PerformLayout();
            this.viewBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).EndInit();
            this.viewBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpBtnGrp2.ResumeLayout(false);
            this.flpBtnGrp2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.signout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flpHeader.ResumeLayout(false);
            this.flpHeader.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.searchContainer.ResumeLayout(false);
            this.searchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.FlowLayoutPanel divLeft;
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.FlowLayoutPanel authorContainer;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel titleContainer;
        private System.Windows.Forms.GroupBox gbAddBook;
        private System.Windows.Forms.FlowLayoutPanel divRight;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorAuthor;
        private System.Windows.Forms.FlowLayoutPanel flpBtnGrp1;
        private System.Windows.Forms.FlowLayoutPanel viewBorrowers;
        private System.Windows.Forms.PictureBox icoBorrower;
        private System.Windows.Forms.Button btnViewBorrowers;
        private System.Windows.Forms.FlowLayoutPanel viewBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.FlowLayoutPanel flpBtnGrp2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.FlowLayoutPanel signout;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flpHeader;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}