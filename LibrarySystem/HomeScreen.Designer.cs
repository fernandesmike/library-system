namespace LibrarySystem
{
    partial class HomeScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.divRight = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblBorrowMessage = new System.Windows.Forms.Label();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.bookIdContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookID = new System.Windows.Forms.Label();
            this.divRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.divLeft.SuspendLayout();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.gbAddBook.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.bookIdContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // divRight
            // 
            this.divRight.AutoSize = true;
            this.divRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divRight.Controls.Add(this.dataGrid);
            this.divRight.Location = new System.Drawing.Point(616, -2);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(648, 756);
            this.divRight.TabIndex = 26;
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
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Outfit SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
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
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.Transparent;
            this.divLeft.Controls.Add(this.userInfoContainer);
            this.divLeft.Controls.Add(this.gbSearch);
            this.divLeft.Controls.Add(this.gbAddBook);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.MaximumSize = new System.Drawing.Size(620, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.divLeft.Size = new System.Drawing.Size(586, 753);
            this.divLeft.TabIndex = 25;
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
            this.userInfoContainer.Size = new System.Drawing.Size(530, 86);
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
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Basic";
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
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.AutoSize = true;
            this.gbSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSearch.Controls.Add(this.flowLayoutPanel1);
            this.gbSearch.Controls.Add(this.lblBorrowMessage);
            this.gbSearch.Controls.Add(this.btnBorrowBook);
            this.gbSearch.Controls.Add(this.searchContainer);
            this.gbSearch.Font = new System.Drawing.Font("Outfit", 9F);
            this.gbSearch.Location = new System.Drawing.Point(28, 127);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.gbSearch.Size = new System.Drawing.Size(530, 317);
            this.gbSearch.TabIndex = 27;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Borrow book";
            // 
            // lblBorrowMessage
            // 
            this.lblBorrowMessage.AutoSize = true;
            this.lblBorrowMessage.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblBorrowMessage.ForeColor = System.Drawing.Color.Red;
            this.lblBorrowMessage.Location = new System.Drawing.Point(126, 97);
            this.lblBorrowMessage.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblBorrowMessage.Name = "lblBorrowMessage";
            this.lblBorrowMessage.Size = new System.Drawing.Size(272, 19);
            this.lblBorrowMessage.TabIndex = 30;
            this.lblBorrowMessage.Text = "Please search or select a book to borrow";
            this.lblBorrowMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBorrowBook.Enabled = false;
            this.btnBorrowBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBorrowBook.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.Location = new System.Drawing.Point(10, 240);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(504, 50);
            this.btnBorrowBook.TabIndex = 29;
            this.btnBorrowBook.Text = "Borrow book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            // 
            // searchContainer
            // 
            this.searchContainer.AutoSize = true;
            this.searchContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchContainer.Controls.Add(this.iconSearch);
            this.searchContainer.Controls.Add(this.txtSearch);
            this.searchContainer.Location = new System.Drawing.Point(7, 34);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(510, 51);
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
            this.txtSearch.Size = new System.Drawing.Size(466, 45);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // gbAddBook
            // 
            this.gbAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddBook.AutoSize = true;
            this.gbAddBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAddBook.Controls.Add(this.btnReturnBook);
            this.gbAddBook.Controls.Add(this.btnReport);
            this.gbAddBook.Font = new System.Drawing.Font("Outfit", 9F);
            this.gbAddBook.Location = new System.Drawing.Point(28, 467);
            this.gbAddBook.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.gbAddBook.Size = new System.Drawing.Size(530, 195);
            this.gbAddBook.TabIndex = 26;
            this.gbAddBook.TabStop = false;
            this.gbAddBook.Text = "Other options";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReport.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(10, 123);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(504, 50);
            this.btnReport.TabIndex = 28;
            this.btnReport.Text = "Report an issue";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReturnBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReturnBook.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(10, 52);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(504, 50);
            this.btnReturnBook.TabIndex = 29;
            this.btnReturnBook.Text = "Return a book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.bookIdContainer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 86);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lblBookTitle);
            this.flowLayoutPanel2.Controls.Add(this.lblAuthor);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(101, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(251, 80);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoEllipsis = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBookTitle.Location = new System.Drawing.Point(3, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(248, 25);
            this.lblBookTitle.TabIndex = 15;
            this.lblBookTitle.Text = "Please select a book";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAuthor.Location = new System.Drawing.Point(3, 40);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 24);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "by -";
            // 
            // bookIdContainer
            // 
            this.bookIdContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookIdContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookIdContainer.Controls.Add(this.lblBookID);
            this.bookIdContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bookIdContainer.Location = new System.Drawing.Point(370, 3);
            this.bookIdContainer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bookIdContainer.Name = "bookIdContainer";
            this.bookIdContainer.Padding = new System.Windows.Forms.Padding(10);
            this.bookIdContainer.Size = new System.Drawing.Size(139, 80);
            this.bookIdContainer.TabIndex = 26;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBookID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBookID.Location = new System.Drawing.Point(13, 13);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblBookID.Size = new System.Drawing.Size(99, 29);
            this.lblBookID.TabIndex = 16;
            this.lblBookID.Text = "Book ID: -";
            this.lblBookID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.divLeft);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.divRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.bookIdContainer.ResumeLayout(false);
            this.bookIdContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel divRight;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.FlowLayoutPanel divLeft;
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbAddBook;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Label lblBorrowMessage;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.FlowLayoutPanel bookIdContainer;
        private System.Windows.Forms.Label lblBookID;
    }
}