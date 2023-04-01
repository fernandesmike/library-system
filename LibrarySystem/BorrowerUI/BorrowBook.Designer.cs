namespace LibrarySystem
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Panel();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.viewReports = new System.Windows.Forms.FlowLayoutPanel();
            this.iconEdit = new System.Windows.Forms.PictureBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.flpDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.tmHideMessage = new System.Windows.Forms.Timer(this.components);
            this.titleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantities = new System.Windows.Forms.TextBox();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.divLeft.SuspendLayout();
            this.viewBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).BeginInit();
            this.info.SuspendLayout();
            this.infoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.viewReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEdit)).BeginInit();
            this.flpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.flpSearch.SuspendLayout();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.flpTitle.SuspendLayout();
            this.titleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // divLeft
            // 
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divLeft.Controls.Add(this.viewBorrowers);
            this.divLeft.Controls.Add(this.lblMessage);
            this.divLeft.Controls.Add(this.info);
            this.divLeft.Controls.Add(this.titleContainer);
            this.divLeft.Controls.Add(this.lblCategory);
            this.divLeft.Controls.Add(this.viewReports);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.Margin = new System.Windows.Forms.Padding(2);
            this.divLeft.MaximumSize = new System.Drawing.Size(465, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(11, 12, 11, 0);
            this.divLeft.Size = new System.Drawing.Size(340, 612);
            this.divLeft.TabIndex = 29;
            // 
            // viewBorrowers
            // 
            this.viewBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewBorrowers.AutoSize = true;
            this.viewBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewBorrowers.BackColor = System.Drawing.Color.Transparent;
            this.viewBorrowers.Controls.Add(this.icoBorrower);
            this.viewBorrowers.Controls.Add(this.btnBack);
            this.viewBorrowers.Location = new System.Drawing.Point(13, 14);
            this.viewBorrowers.Margin = new System.Windows.Forms.Padding(2);
            this.viewBorrowers.Name = "viewBorrowers";
            this.viewBorrowers.Size = new System.Drawing.Size(159, 36);
            this.viewBorrowers.TabIndex = 36;
            // 
            // icoBorrower
            // 
            this.icoBorrower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icoBorrower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoBorrower.BackgroundImage")));
            this.icoBorrower.ErrorImage = null;
            this.icoBorrower.Image = ((System.Drawing.Image)(resources.GetObject("icoBorrower.Image")));
            this.icoBorrower.InitialImage = ((System.Drawing.Image)(resources.GetObject("icoBorrower.InitialImage")));
            this.icoBorrower.Location = new System.Drawing.Point(2, 5);
            this.icoBorrower.Margin = new System.Windows.Forms.Padding(2);
            this.icoBorrower.Name = "icoBorrower";
            this.icoBorrower.Size = new System.Drawing.Size(24, 26);
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
            this.btnBack.Location = new System.Drawing.Point(28, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(4);
            this.btnBack.Size = new System.Drawing.Size(131, 36);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMessage.Location = new System.Drawing.Point(13, 93);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 41, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(297, 20);
            this.lblMessage.TabIndex = 43;
            this.lblMessage.Text = "Please select a book to borrow";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info
            // 
            this.info.Controls.Add(this.infoContainer);
            this.info.Controls.Add(this.imgAvatar);
            this.info.Location = new System.Drawing.Point(13, 121);
            this.info.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(302, 184);
            this.info.TabIndex = 29;
            // 
            // infoContainer
            // 
            this.infoContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblID);
            this.infoContainer.Controls.Add(this.lblBookTitle);
            this.infoContainer.Controls.Add(this.lblBookAuthor);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(0, 63);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.infoContainer.Size = new System.Drawing.Size(299, 106);
            this.infoContainer.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblID.Location = new System.Drawing.Point(2, 8);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(297, 20);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "-";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoEllipsis = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBookTitle.Location = new System.Drawing.Point(2, 36);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblBookTitle.MinimumSize = new System.Drawing.Size(160, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(297, 20);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Please select a book";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBookAuthor.Location = new System.Drawing.Point(2, 64);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(297, 20);
            this.lblBookAuthor.TabIndex = 14;
            this.lblBookAuthor.Text = "-";
            this.lblBookAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(0, 4);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(299, 57);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 14;
            this.imgAvatar.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(13, 424);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(160, 20);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Actions";
            // 
            // viewReports
            // 
            this.viewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewReports.Controls.Add(this.iconEdit);
            this.viewReports.Controls.Add(this.btnBorrow);
            this.viewReports.Location = new System.Drawing.Point(13, 452);
            this.viewReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.viewReports.Name = "viewReports";
            this.viewReports.Size = new System.Drawing.Size(302, 41);
            this.viewReports.TabIndex = 37;
            // 
            // iconEdit
            // 
            this.iconEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconEdit.Image = ((System.Drawing.Image)(resources.GetObject("iconEdit.Image")));
            this.iconEdit.Location = new System.Drawing.Point(2, 5);
            this.iconEdit.Margin = new System.Windows.Forms.Padding(2);
            this.iconEdit.Name = "iconEdit";
            this.iconEdit.Size = new System.Drawing.Size(24, 26);
            this.iconEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEdit.TabIndex = 35;
            this.iconEdit.TabStop = false;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(28, 0);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Padding = new System.Windows.Forms.Padding(4);
            this.btnBorrow.Size = new System.Drawing.Size(273, 36);
            this.btnBorrow.TabIndex = 30;
            this.btnBorrow.Text = "Borrow this book";
            this.btnBorrow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // flpDataGrid
            // 
            this.flpDataGrid.Controls.Add(this.dataGrid);
            this.flpDataGrid.Location = new System.Drawing.Point(368, 199);
            this.flpDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(629, 413);
            this.flpDataGrid.TabIndex = 47;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGrid.GridColor = System.Drawing.Color.LightGray;
            this.dataGrid.Location = new System.Drawing.Point(2, 2);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowTemplate.DividerHeight = 1;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(627, 401);
            this.dataGrid.TabIndex = 48;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // flpSearch
            // 
            this.flpSearch.AutoSize = true;
            this.flpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSearch.Controls.Add(this.lblSearch);
            this.flpSearch.Controls.Add(this.searchContainer);
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearch.Location = new System.Drawing.Point(368, 15);
            this.flpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(375, 70);
            this.flpSearch.TabIndex = 49;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearch.Location = new System.Drawing.Point(2, 8);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 19);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search books";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchContainer
            // 
            this.searchContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchContainer.AutoSize = true;
            this.searchContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchContainer.Controls.Add(this.iconSearch);
            this.searchContainer.Controls.Add(this.txtSearch);
            this.searchContainer.Location = new System.Drawing.Point(2, 35);
            this.searchContainer.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(371, 33);
            this.searchContainer.TabIndex = 38;
            // 
            // iconSearch
            // 
            this.iconSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iconSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconSearch.Image = ((System.Drawing.Image)(resources.GetObject("iconSearch.Image")));
            this.iconSearch.Location = new System.Drawing.Point(2, 2);
            this.iconSearch.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.iconSearch.MaximumSize = new System.Drawing.Size(43, 46);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(19, 29);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSearch.TabIndex = 20;
            this.iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Outfit", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSearch.Location = new System.Drawing.Point(31, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 29);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // flpTitle
            // 
            this.flpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTitle.AutoSize = true;
            this.flpTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitle.Controls.Add(this.lblContext);
            this.flpTitle.Controls.Add(this.lblParagraph);
            this.flpTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitle.Location = new System.Drawing.Point(368, 98);
            this.flpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(266, 57);
            this.flpTitle.TabIndex = 48;
            // 
            // lblContext
            // 
            this.lblContext.AutoEllipsis = true;
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.lblContext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContext.Location = new System.Drawing.Point(2, 0);
            this.lblContext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(187, 30);
            this.lblContext.TabIndex = 12;
            this.lblContext.Text = "Available books";
            this.lblContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblParagraph.Location = new System.Drawing.Point(2, 38);
            this.lblParagraph.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(262, 19);
            this.lblParagraph.TabIndex = 14;
            this.lblParagraph.Text = "You can borrow any books listed below";
            this.lblParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoEllipsis = true;
            this.lblUpdateMessage.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUpdateMessage.Font = new System.Drawing.Font("Outfit SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMessage.ForeColor = System.Drawing.Color.White;
            this.lblUpdateMessage.Location = new System.Drawing.Point(368, 167);
            this.lblUpdateMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateMessage.MinimumSize = new System.Drawing.Size(160, 25);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblUpdateMessage.Size = new System.Drawing.Size(629, 25);
            this.lblUpdateMessage.TabIndex = 50;
            this.lblUpdateMessage.Text = "Update message goes here";
            this.lblUpdateMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpdateMessage.Visible = false;
            // 
            // tmHideMessage
            // 
            this.tmHideMessage.Interval = 3000;
            this.tmHideMessage.Tick += new System.EventHandler(this.TmHideMessage_Tick);
            // 
            // titleContainer
            // 
            this.titleContainer.AutoSize = true;
            this.titleContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleContainer.Controls.Add(this.lblQuantity);
            this.titleContainer.Controls.Add(this.txtQuantities);
            this.titleContainer.Controls.Add(this.lblAvailableCopies);
            this.titleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleContainer.Location = new System.Drawing.Point(13, 309);
            this.titleContainer.Margin = new System.Windows.Forms.Padding(2);
            this.titleContainer.Name = "titleContainer";
            this.titleContainer.Size = new System.Drawing.Size(182, 105);
            this.titleContainer.TabIndex = 44;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQuantity.Location = new System.Drawing.Point(2, 0);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(156, 18);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "No. of copies to borrow";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQuantities
            // 
            this.txtQuantities.Enabled = false;
            this.txtQuantities.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantities.Location = new System.Drawing.Point(2, 28);
            this.txtQuantities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.txtQuantities.Multiline = true;
            this.txtQuantities.Name = "txtQuantities";
            this.txtQuantities.Size = new System.Drawing.Size(91, 41);
            this.txtQuantities.TabIndex = 19;
            this.txtQuantities.Text = "1";
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.AutoSize = true;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblAvailableCopies.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAvailableCopies.Location = new System.Drawing.Point(2, 79);
            this.lblAvailableCopies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(178, 18);
            this.lblAvailableCopies.TabIndex = 20;
            this.lblAvailableCopies.Text = "Number of copies available";
            this.lblAvailableCopies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 612);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.flpDataGrid);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrow book";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.divLeft.ResumeLayout(false);
            this.divLeft.PerformLayout();
            this.viewBorrowers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).EndInit();
            this.info.ResumeLayout(false);
            this.infoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.viewReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconEdit)).EndInit();
            this.flpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.flpSearch.ResumeLayout(false);
            this.flpSearch.PerformLayout();
            this.searchContainer.ResumeLayout(false);
            this.searchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.flpTitle.ResumeLayout(false);
            this.flpTitle.PerformLayout();
            this.titleContainer.ResumeLayout(false);
            this.titleContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel divLeft;
        internal System.Windows.Forms.FlowLayoutPanel viewBorrowers;
        internal System.Windows.Forms.PictureBox icoBorrower;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Panel info;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.Label lblBookTitle;
        internal System.Windows.Forms.Label lblBookAuthor;
        internal System.Windows.Forms.PictureBox imgAvatar;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.FlowLayoutPanel viewReports;
        internal System.Windows.Forms.PictureBox iconEdit;
        internal System.Windows.Forms.Button btnBorrow;
        internal System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FlowLayoutPanel flpDataGrid;
        internal System.Windows.Forms.DataGridView dataGrid;
        internal System.Windows.Forms.FlowLayoutPanel flpSearch;
        internal System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.FlowLayoutPanel flpTitle;
        internal System.Windows.Forms.Label lblContext;
        internal System.Windows.Forms.Label lblParagraph;
        internal System.Windows.Forms.Label lblUpdateMessage;
        internal System.Windows.Forms.Timer tmHideMessage;
        internal System.Windows.Forms.FlowLayoutPanel titleContainer;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.TextBox txtQuantities;
        internal System.Windows.Forms.Label lblAvailableCopies;
    }
}