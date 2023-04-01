namespace LibrarySystem
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.bookInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.image = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCopiesBorrowed = new System.Windows.Forms.Label();
            this.lblDaysBorrowed = new System.Windows.Forms.Label();
            this.btnContainer.SuspendLayout();
            this.returnDate.SuspendLayout();
            this.borrowDate.SuspendLayout();
            this.bookInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnClose);
            this.btnContainer.Controls.Add(this.btnReturn);
            this.btnContainer.Location = new System.Drawing.Point(36, 420);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(378, 42);
            this.btnContainer.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnClose.Location = new System.Drawing.Point(65, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 19);
            this.btnClose.TabIndex = 24;
            this.btnClose.TabStop = true;
            this.btnClose.Text = "Close";
            this.btnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnClose_LinkClicked);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(196, 1);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 41);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Return book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // returnDate
            // 
            this.returnDate.AutoSize = true;
            this.returnDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnDate.Controls.Add(this.lblSecond);
            this.returnDate.Controls.Add(this.lblReturnDate);
            this.returnDate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.returnDate.Location = new System.Drawing.Point(243, 331);
            this.returnDate.Margin = new System.Windows.Forms.Padding(2);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(173, 46);
            this.returnDate.TabIndex = 35;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblSecond.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSecond.Location = new System.Drawing.Point(2, 0);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(122, 18);
            this.lblSecond.TabIndex = 18;
            this.lblSecond.Text = "To be returned on";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.Location = new System.Drawing.Point(2, 26);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(169, 20);
            this.lblReturnDate.TabIndex = 22;
            this.lblReturnDate.Text = "MM - DD - YY";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borrowDate
            // 
            this.borrowDate.AutoSize = true;
            this.borrowDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrowDate.Controls.Add(this.lblFirst);
            this.borrowDate.Controls.Add(this.lblBorrowDate);
            this.borrowDate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.borrowDate.Location = new System.Drawing.Point(36, 331);
            this.borrowDate.Margin = new System.Windows.Forms.Padding(2);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(170, 46);
            this.borrowDate.TabIndex = 34;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblFirst.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFirst.Location = new System.Drawing.Point(2, 0);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(97, 18);
            this.lblFirst.TabIndex = 18;
            this.lblFirst.Text = "Borrowed last";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowDate.Location = new System.Drawing.Point(2, 26);
            this.lblBorrowDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(166, 20);
            this.lblBorrowDate.TabIndex = 21;
            this.lblBorrowDate.Text = "MM - DD - YY";
            this.lblBorrowDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookInfoContainer
            // 
            this.bookInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookInfoContainer.AutoSize = true;
            this.bookInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookInfoContainer.Controls.Add(this.image);
            this.bookInfoContainer.Controls.Add(this.infoContainer);
            this.bookInfoContainer.Controls.Add(this.lblCopiesBorrowed);
            this.bookInfoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bookInfoContainer.Location = new System.Drawing.Point(36, 24);
            this.bookInfoContainer.Margin = new System.Windows.Forms.Padding(2);
            this.bookInfoContainer.Name = "bookInfoContainer";
            this.bookInfoContainer.Size = new System.Drawing.Size(380, 182);
            this.bookInfoContainer.TabIndex = 33;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(2, 2);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(376, 65);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 14;
            this.image.TabStop = false;
            // 
            // infoContainer
            // 
            this.infoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblTitle);
            this.infoContainer.Controls.Add(this.lblAuthor);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(2, 71);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(2);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.infoContainer.Size = new System.Drawing.Size(376, 69);
            this.infoContainer.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(2, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 20);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Book title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAuthor.Location = new System.Drawing.Point(2, 32);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(371, 20);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "by -";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopiesBorrowed
            // 
            this.lblCopiesBorrowed.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.lblCopiesBorrowed.ForeColor = System.Drawing.Color.Black;
            this.lblCopiesBorrowed.Location = new System.Drawing.Point(2, 150);
            this.lblCopiesBorrowed.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.lblCopiesBorrowed.Name = "lblCopiesBorrowed";
            this.lblCopiesBorrowed.Size = new System.Drawing.Size(376, 24);
            this.lblCopiesBorrowed.TabIndex = 27;
            this.lblCopiesBorrowed.Text = "Borrowed count copies";
            this.lblCopiesBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDaysBorrowed
            // 
            this.lblDaysBorrowed.AutoEllipsis = true;
            this.lblDaysBorrowed.BackColor = System.Drawing.Color.Honeydew;
            this.lblDaysBorrowed.Font = new System.Drawing.Font("Outfit SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysBorrowed.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDaysBorrowed.Location = new System.Drawing.Point(33, 230);
            this.lblDaysBorrowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDaysBorrowed.MinimumSize = new System.Drawing.Size(160, 25);
            this.lblDaysBorrowed.Name = "lblDaysBorrowed";
            this.lblDaysBorrowed.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblDaysBorrowed.Size = new System.Drawing.Size(383, 69);
            this.lblDaysBorrowed.TabIndex = 51;
            this.lblDaysBorrowed.Text = "You have already borrowed this book for 6 days";
            this.lblDaysBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 498);
            this.Controls.Add(this.lblDaysBorrowed);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.bookInfoContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book details";
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.returnDate.ResumeLayout(false);
            this.returnDate.PerformLayout();
            this.borrowDate.ResumeLayout(false);
            this.borrowDate.PerformLayout();
            this.bookInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel btnContainer;
        internal System.Windows.Forms.LinkLabel btnClose;
        internal System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.FlowLayoutPanel returnDate;
        internal System.Windows.Forms.Label lblSecond;
        internal System.Windows.Forms.FlowLayoutPanel borrowDate;
        internal System.Windows.Forms.Label lblFirst;
        internal System.Windows.Forms.FlowLayoutPanel bookInfoContainer;
        internal System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.Label lblCopiesBorrowed;
        internal System.Windows.Forms.Label lblBorrowDate;
        internal System.Windows.Forms.Label lblReturnDate;
        internal System.Windows.Forms.Label lblDaysBorrowed;
    }
}