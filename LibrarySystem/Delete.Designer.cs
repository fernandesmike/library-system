namespace LibrarySystem
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.header = new System.Windows.Forms.Label();
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.bookIdContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.bookIdContainer.SuspendLayout();
            this.btnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Outfit", 12F);
            this.header.ForeColor = System.Drawing.Color.Red;
            this.header.Location = new System.Drawing.Point(155, 60);
            this.header.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(292, 50);
            this.header.TabIndex = 30;
            this.header.Text = "Are you sure you want to delete \r\nthis book?";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userInfoContainer
            // 
            this.userInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.pictureBox1);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.Controls.Add(this.bookIdContainer);
            this.userInfoContainer.Location = new System.Drawing.Point(49, 150);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(504, 86);
            this.userInfoContainer.TabIndex = 29;
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
            this.infoContainer.AutoSize = true;
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.Controls.Add(this.lblBookTitle);
            this.infoContainer.Controls.Add(this.lblAuthor);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(101, 3);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(187, 80);
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
            // bookIdContainer
            // 
            this.bookIdContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookIdContainer.AutoSize = true;
            this.bookIdContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookIdContainer.Controls.Add(this.lblBookID);
            this.bookIdContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bookIdContainer.Location = new System.Drawing.Point(306, 3);
            this.bookIdContainer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bookIdContainer.Name = "bookIdContainer";
            this.bookIdContainer.Padding = new System.Windows.Forms.Padding(10);
            this.bookIdContainer.Size = new System.Drawing.Size(183, 80);
            this.bookIdContainer.TabIndex = 26;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBookID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBookID.Location = new System.Drawing.Point(13, 15);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.lblBookID.Size = new System.Drawing.Size(157, 34);
            this.lblBookID.TabIndex = 16;
            this.lblBookID.Text = "Book ID: 012931";
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnCancel);
            this.btnContainer.Controls.Add(this.btnDelete);
            this.btnContainer.Location = new System.Drawing.Point(49, 289);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(504, 52);
            this.btnContainer.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnCancel.Location = new System.Drawing.Point(88, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 24);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.TabStop = true;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnCancel_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(261, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 50);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Yes, delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 413);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.userInfoContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.userInfoContainer.ResumeLayout(false);
            this.userInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.bookIdContainer.ResumeLayout(false);
            this.bookIdContainer.PerformLayout();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.FlowLayoutPanel bookIdContainer;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel btnCancel;
    }
}