﻿namespace LibrarySystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.SuspendLayout();
            // 
            // divLeft
            // 
            this.divLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divLeft.Controls.Add(this.viewBorrowers);
            this.divLeft.Controls.Add(this.lblMessage);
            this.divLeft.Controls.Add(this.info);
            this.divLeft.Controls.Add(this.lblCategory);
            this.divLeft.Controls.Add(this.viewReports);
            this.divLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.divLeft.Location = new System.Drawing.Point(0, 0);
            this.divLeft.MaximumSize = new System.Drawing.Size(620, 0);
            this.divLeft.Name = "divLeft";
            this.divLeft.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.divLeft.Size = new System.Drawing.Size(453, 753);
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
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMessage.Location = new System.Drawing.Point(18, 115);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(396, 24);
            this.lblMessage.TabIndex = 43;
            this.lblMessage.Text = "Please select a book to borrow";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info
            // 
            this.info.Controls.Add(this.infoContainer);
            this.info.Controls.Add(this.imgAvatar);
            this.info.Location = new System.Drawing.Point(18, 149);
            this.info.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(402, 226);
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
            this.infoContainer.Location = new System.Drawing.Point(0, 78);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(399, 130);
            this.infoContainer.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblID.Location = new System.Drawing.Point(3, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(396, 24);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "-";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoEllipsis = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBookTitle.Location = new System.Drawing.Point(3, 44);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBookTitle.MinimumSize = new System.Drawing.Size(213, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(396, 24);
            this.lblBookTitle.TabIndex = 12;
            this.lblBookTitle.Text = "Please select a book";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBookAuthor.Location = new System.Drawing.Point(3, 78);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(396, 24);
            this.lblBookAuthor.TabIndex = 14;
            this.lblBookAuthor.Text = "-";
            this.lblBookAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imgAvatar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar.Image")));
            this.imgAvatar.Location = new System.Drawing.Point(0, 5);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(399, 70);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 14;
            this.imgAvatar.TabStop = false;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.Location = new System.Drawing.Point(18, 388);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
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
            this.viewReports.Controls.Add(this.btnBorrow);
            this.viewReports.Location = new System.Drawing.Point(18, 422);
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
            this.btnBorrow.Location = new System.Drawing.Point(38, 0);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Padding = new System.Windows.Forms.Padding(5);
            this.btnBorrow.Size = new System.Drawing.Size(364, 44);
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
            this.flpDataGrid.Location = new System.Drawing.Point(491, 245);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(839, 508);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.GridColor = System.Drawing.Color.LightGray;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
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
            this.dataGrid.Size = new System.Drawing.Size(836, 493);
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
            this.flpSearch.Location = new System.Drawing.Point(491, 18);
            this.flpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.flpSearch.Name = "flpSearch";
            this.flpSearch.Size = new System.Drawing.Size(500, 88);
            this.flpSearch.TabIndex = 49;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSearch.Location = new System.Drawing.Point(3, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(123, 24);
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
            // flpTitle
            // 
            this.flpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTitle.AutoSize = true;
            this.flpTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitle.Controls.Add(this.lblContext);
            this.flpTitle.Controls.Add(this.lblParagraph);
            this.flpTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitle.Location = new System.Drawing.Point(491, 121);
            this.flpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(342, 72);
            this.flpTitle.TabIndex = 48;
            // 
            // lblContext
            // 
            this.lblContext.AutoEllipsis = true;
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Outfit", 18F, System.Drawing.FontStyle.Bold);
            this.lblContext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContext.Location = new System.Drawing.Point(3, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(237, 38);
            this.lblContext.TabIndex = 12;
            this.lblContext.Text = "Available books";
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
            this.lblParagraph.Size = new System.Drawing.Size(336, 24);
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
            this.lblUpdateMessage.Location = new System.Drawing.Point(491, 205);
            this.lblUpdateMessage.MinimumSize = new System.Drawing.Size(213, 31);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblUpdateMessage.Size = new System.Drawing.Size(839, 31);
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
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.flpDataGrid);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}