namespace LibrarySystem
{
    partial class ConfirmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmBorrow));
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnContainer.SuspendLayout();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnClose);
            this.btnContainer.Controls.Add(this.btnViewBooks);
            this.btnContainer.Location = new System.Drawing.Point(49, 295);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(504, 52);
            this.btnContainer.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnClose.Location = new System.Drawing.Point(88, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 24);
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = true;
            this.btnClose.Text = "Close";
            this.btnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnClose_LinkClicked);
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewBooks.FlatAppearance.BorderSize = 0;
            this.btnViewBooks.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooks.ForeColor = System.Drawing.Color.Black;
            this.btnViewBooks.Location = new System.Drawing.Point(261, 1);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(240, 50);
            this.btnViewBooks.TabIndex = 22;
            this.btnViewBooks.Text = "View my books";
            this.btnViewBooks.UseVisualStyleBackColor = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Outfit", 12F);
            this.header.ForeColor = System.Drawing.Color.SeaGreen;
            this.header.Location = new System.Drawing.Point(155, 66);
            this.header.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(288, 50);
            this.header.TabIndex = 35;
            this.header.Text = "You have sucessfully  borrowed\r\nthe following book";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userInfoContainer
            // 
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.pictureBox1);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.Location = new System.Drawing.Point(49, 156);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(501, 86);
            this.userInfoContainer.TabIndex = 34;
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
            // infoContainer
            // 
            this.infoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblBookTitle);
            this.infoContainer.Controls.Add(this.lblAuthor);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(101, 3);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(386, 80);
            this.infoContainer.TabIndex = 25;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.Location = new System.Drawing.Point(3, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(181, 25);
            this.lblBookTitle.TabIndex = 15;
            this.lblBookTitle.Text = "C++ Programming";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAuthor.Location = new System.Drawing.Point(3, 40);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(108, 24);
            this.lblAuthor.TabIndex = 16;
            this.lblAuthor.Text = "by DS Malik";
            // 
            // ConfirmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 413);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.userInfoContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfirmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmBorrow";
            this.Load += new System.EventHandler(this.ConfirmBorrow_Load);
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.userInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.LinkLabel btnClose;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
    }
}