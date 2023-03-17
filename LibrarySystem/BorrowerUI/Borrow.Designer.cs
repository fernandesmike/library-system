namespace LibrarySystem.BorrowerUI
{
    partial class BookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.divLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.viewBorrowers = new System.Windows.Forms.FlowLayoutPanel();
            this.icoBorrower = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Panel();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.viewReports = new System.Windows.Forms.FlowLayoutPanel();
            this.iconEdit = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.flpDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGridHeader = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.divLeft.SuspendLayout();
            this.viewBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoBorrower)).BeginInit();
            this.info.SuspendLayout();
            this.infoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.viewReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEdit)).BeginInit();
            this.flpDataGrid.SuspendLayout();
            this.panelGridHeader.SuspendLayout();
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
            this.divLeft.Controls.Add(this.lblStatus);
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
            // 
            // info
            // 
            this.info.Controls.Add(this.infoContainer);
            this.info.Controls.Add(this.imgAvatar);
            this.info.Location = new System.Drawing.Point(18, 109);
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
            this.infoContainer.Controls.Add(this.lblUser);
            this.infoContainer.Controls.Add(this.lblType);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(0, 78);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(399, 92);
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
            this.lblUser.Size = new System.Drawing.Size(396, 24);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Mike Andrew Fernandez";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblType.Location = new System.Drawing.Point(3, 58);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(396, 24);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Borrower";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblCategory.Location = new System.Drawing.Point(18, 348);
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
            this.viewReports.Controls.Add(this.btnEdit);
            this.viewReports.Location = new System.Drawing.Point(18, 382);
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
            this.btnEdit.Text = "Borrow this book";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStatus.Location = new System.Drawing.Point(18, 75);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(396, 24);
            this.lblStatus.TabIndex = 43;
            this.lblStatus.Text = "Please select a book to borrow";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpDataGrid
            // 
            this.flpDataGrid.Controls.Add(this.panelGridHeader);
            this.flpDataGrid.Controls.Add(this.dataGrid);
            this.flpDataGrid.Location = new System.Drawing.Point(470, 133);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(860, 608);
            this.flpDataGrid.TabIndex = 47;
            // 
            // panelGridHeader
            // 
            this.panelGridHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelGridHeader.Controls.Add(this.lblGridTitle);
            this.panelGridHeader.Location = new System.Drawing.Point(3, 3);
            this.panelGridHeader.Name = "panelGridHeader";
            this.panelGridHeader.Size = new System.Drawing.Size(857, 54);
            this.panelGridHeader.TabIndex = 45;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoEllipsis = true;
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGridTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGridTitle.Location = new System.Drawing.Point(3, 15);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(73, 24);
            this.lblGridTitle.TabIndex = 42;
            this.lblGridTitle.Text = "Books";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGrid.GridColor = System.Drawing.Color.LightGray;
            this.dataGrid.Location = new System.Drawing.Point(3, 63);
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
            this.dataGrid.Size = new System.Drawing.Size(854, 545);
            this.dataGrid.TabIndex = 48;
            // 
            // flpSearch
            // 
            this.flpSearch.AutoSize = true;
            this.flpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSearch.Controls.Add(this.lblSearch);
            this.flpSearch.Controls.Add(this.searchContainer);
            this.flpSearch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearch.Location = new System.Drawing.Point(827, 18);
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
            // 
            // flpTitle
            // 
            this.flpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpTitle.AutoSize = true;
            this.flpTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTitle.Controls.Add(this.lblContext);
            this.flpTitle.Controls.Add(this.lblParagraph);
            this.flpTitle.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTitle.Location = new System.Drawing.Point(470, 18);
            this.flpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(243, 96);
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
            this.lblParagraph.Size = new System.Drawing.Size(234, 48);
            this.lblParagraph.TabIndex = 14;
            this.lblParagraph.Text = "You can borrow any books\r\nlisted below";
            this.lblParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 753);
            this.Controls.Add(this.flpSearch);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.flpDataGrid);
            this.Controls.Add(this.divLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book details";
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
            this.panelGridHeader.ResumeLayout(false);
            this.panelGridHeader.PerformLayout();
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
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.PictureBox imgAvatar;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.FlowLayoutPanel viewReports;
        internal System.Windows.Forms.PictureBox iconEdit;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FlowLayoutPanel flpDataGrid;
        private System.Windows.Forms.Panel panelGridHeader;
        internal System.Windows.Forms.Label lblGridTitle;
        internal System.Windows.Forms.DataGridView dataGrid;
        internal System.Windows.Forms.FlowLayoutPanel flpSearch;
        internal System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.FlowLayoutPanel searchContainer;
        private System.Windows.Forms.PictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.FlowLayoutPanel flpTitle;
        internal System.Windows.Forms.Label lblContext;
        internal System.Windows.Forms.Label lblParagraph;
    }
}