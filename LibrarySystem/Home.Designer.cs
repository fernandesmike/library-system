namespace LibrarySystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.btnContainer.SuspendLayout();
            this.divLeft.SuspendLayout();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.gbAddBook.SuspendLayout();
            this.titleContainer.SuspendLayout();
            this.authorContainer.SuspendLayout();
            this.divRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
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
            this.btnContainer.Location = new System.Drawing.Point(28, 646);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(524, 55);
            this.btnContainer.TabIndex = 22;
            // 
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.Transparent;
            this.divLeft.Controls.Add(this.userInfoContainer);
            this.divLeft.Controls.Add(this.gbSearch);
            this.divLeft.Controls.Add(this.gbAddBook);
            this.divLeft.Controls.Add(this.btnContainer);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.MaximumSize = new System.Drawing.Size(620, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.divLeft.Size = new System.Drawing.Size(580, 753);
            this.divLeft.TabIndex = 23;
            // 
            // userInfoContainer
            // 
            this.userInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoContainer.AutoSize = true;
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.imgAvatar);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.Controls.Add(this.btnLogout);
            this.userInfoContainer.Location = new System.Drawing.Point(28, 18);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(524, 86);
            this.userInfoContainer.TabIndex = 26;
            this.userInfoContainer.WrapContents = false;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(3, 3);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(80, 80);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 14;
            this.imgAvatar.TabStop = false;
            // 
            // infoContainer
            // 
            this.infoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblUser);
            this.infoContainer.Controls.Add(this.label3);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(101, 3);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(323, 80);
            this.infoContainer.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Font = new System.Drawing.Font("Outfit", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUser.Location = new System.Drawing.Point(3, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(314, 30);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Welcome, Mike!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Admin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveLinkColor = System.Drawing.Color.Brown;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.Font = new System.Drawing.Font("Outfit", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.LinkColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(430, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 86);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Signout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogout_LinkClicked_1);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.AutoSize = true;
            this.gbSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSearch.Controls.Add(this.searchContainer);
            this.gbSearch.Font = new System.Drawing.Font("Outfit", 9F);
            this.gbSearch.Location = new System.Drawing.Point(28, 137);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.gbSearch.Size = new System.Drawing.Size(524, 112);
            this.gbSearch.TabIndex = 27;
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
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
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
            this.gbAddBook.Location = new System.Drawing.Point(28, 272);
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
            this.divRight.AutoSize = true;
            this.divRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divRight.Controls.Add(this.dataGrid);
            this.divRight.Location = new System.Drawing.Point(617, 0);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(648, 756);
            this.divRight.TabIndex = 24;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Outfit SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(642, 750);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.btnContainer.ResumeLayout(false);
            this.divLeft.ResumeLayout(false);
            this.divLeft.PerformLayout();
            this.userInfoContainer.ResumeLayout(false);
            this.userInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.searchContainer.ResumeLayout(false);
            this.searchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            this.titleContainer.ResumeLayout(false);
            this.titleContainer.PerformLayout();
            this.authorContainer.ResumeLayout(false);
            this.authorContainer.PerformLayout();
            this.divRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.FlowLayoutPanel authorContainer;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel titleContainer;
        private System.Windows.Forms.GroupBox gbAddBook;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.FlowLayoutPanel divRight;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorAuthor;
    }
}