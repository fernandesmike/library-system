namespace LibrarySystem
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.bookInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.image = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCopiesBorrowed = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
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
            this.btnContainer.Location = new System.Drawing.Point(48, 517);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(504, 52);
            this.btnContainer.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnClose.Location = new System.Drawing.Point(87, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 24);
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
            this.btnReturn.Location = new System.Drawing.Point(261, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(240, 50);
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
            this.returnDate.Location = new System.Drawing.Point(324, 407);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(231, 56);
            this.returnDate.TabIndex = 35;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblSecond.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSecond.Location = new System.Drawing.Point(3, 0);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(147, 21);
            this.lblSecond.TabIndex = 18;
            this.lblSecond.Text = "To be returned on";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // borrowDate
            // 
            this.borrowDate.AutoSize = true;
            this.borrowDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrowDate.Controls.Add(this.lblFirst);
            this.borrowDate.Controls.Add(this.lblBorrowDate);
            this.borrowDate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.borrowDate.Location = new System.Drawing.Point(48, 407);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(228, 56);
            this.borrowDate.TabIndex = 34;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblFirst.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFirst.Location = new System.Drawing.Point(3, 0);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(118, 21);
            this.lblFirst.TabIndex = 18;
            this.lblFirst.Text = "Borrowed last";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.bookInfoContainer.Location = new System.Drawing.Point(48, 29);
            this.bookInfoContainer.Name = "bookInfoContainer";
            this.bookInfoContainer.Size = new System.Drawing.Size(507, 227);
            this.bookInfoContainer.TabIndex = 33;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(501, 80);
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
            this.infoContainer.Location = new System.Drawing.Point(3, 89);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(501, 85);
            this.infoContainer.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(495, 25);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Book title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAuthor.Location = new System.Drawing.Point(3, 40);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(495, 24);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "by -";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopiesBorrowed
            // 
            this.lblCopiesBorrowed.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.lblCopiesBorrowed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCopiesBorrowed.Location = new System.Drawing.Point(3, 187);
            this.lblCopiesBorrowed.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblCopiesBorrowed.Name = "lblCopiesBorrowed";
            this.lblCopiesBorrowed.Size = new System.Drawing.Size(501, 30);
            this.lblCopiesBorrowed.TabIndex = 27;
            this.lblCopiesBorrowed.Text = "Borrowed count copies";
            this.lblCopiesBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowDate.Location = new System.Drawing.Point(3, 31);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(222, 25);
            this.lblBorrowDate.TabIndex = 21;
            this.lblBorrowDate.Text = "MM - DD - YY";
            this.lblBorrowDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.Location = new System.Drawing.Point(3, 31);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(225, 25);
            this.lblReturnDate.TabIndex = 22;
            this.lblReturnDate.Text = "MM - DD - YY";
            this.lblReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDaysBorrowed
            // 
            this.lblDaysBorrowed.AutoEllipsis = true;
            this.lblDaysBorrowed.BackColor = System.Drawing.Color.Honeydew;
            this.lblDaysBorrowed.Font = new System.Drawing.Font("Outfit SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysBorrowed.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDaysBorrowed.Location = new System.Drawing.Point(44, 283);
            this.lblDaysBorrowed.MinimumSize = new System.Drawing.Size(213, 31);
            this.lblDaysBorrowed.Name = "lblDaysBorrowed";
            this.lblDaysBorrowed.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblDaysBorrowed.Size = new System.Drawing.Size(511, 85);
            this.lblDaysBorrowed.TabIndex = 51;
            this.lblDaysBorrowed.Text = "You have already borrowed this book for 6 days";
            this.lblDaysBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.lblDaysBorrowed);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.bookInfoContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book details";
            this.Load += new System.EventHandler(this.Books_Load);
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