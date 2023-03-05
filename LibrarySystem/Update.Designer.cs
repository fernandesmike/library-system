namespace LibrarySystem
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.titleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.authorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.titleContainer.SuspendLayout();
            this.authorContainer.SuspendLayout();
            this.btnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInfoContainer
            // 
            this.userInfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.pictureBox1);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.Location = new System.Drawing.Point(49, 76);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(504, 86);
            this.userInfoContainer.TabIndex = 27;
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
            this.infoContainer.Size = new System.Drawing.Size(400, 80);
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
            // lblBookID
            // 
            this.lblBookID.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblBookID.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBookID.Location = new System.Drawing.Point(48, 162);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(144, 28);
            this.lblBookID.TabIndex = 16;
            this.lblBookID.Text = "Book ID: 012931";
            this.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Red;
            this.header.Location = new System.Drawing.Point(192, 38);
            this.header.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(218, 24);
            this.header.TabIndex = 28;
            this.header.Text = "You are currently editing";
            // 
            // titleContainer
            // 
            this.titleContainer.AutoSize = true;
            this.titleContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleContainer.Controls.Add(this.label5);
            this.titleContainer.Controls.Add(this.txtTitle);
            this.titleContainer.Controls.Add(this.lblErrorTitle);
            this.titleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleContainer.Location = new System.Drawing.Point(49, 274);
            this.titleContainer.Name = "titleContainer";
            this.titleContainer.Size = new System.Drawing.Size(504, 116);
            this.titleContainer.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Outfit", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Book title";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(3, 34);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(498, 50);
            this.txtTitle.TabIndex = 19;
            // 
            // authorContainer
            // 
            this.authorContainer.AutoSize = true;
            this.authorContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorContainer.Controls.Add(this.label1);
            this.authorContainer.Controls.Add(this.txtAuthor);
            this.authorContainer.Controls.Add(this.lblErrorAuthor);
            this.authorContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorContainer.Location = new System.Drawing.Point(49, 398);
            this.authorContainer.Name = "authorContainer";
            this.authorContainer.Size = new System.Drawing.Size(504, 116);
            this.authorContainer.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Outfit", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Author";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(3, 34);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(498, 50);
            this.txtAuthor.TabIndex = 19;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHeader.Location = new System.Drawing.Point(48, 212);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(365, 48);
            this.lblHeader.TabIndex = 31;
            this.lblHeader.Text = "Provide the following new information for \r\nthis book";
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnCancel);
            this.btnContainer.Controls.Add(this.btnSave);
            this.btnContainer.Location = new System.Drawing.Point(49, 538);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(504, 52);
            this.btnContainer.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnCancel.Location = new System.Drawing.Point(87, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 24);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.TabStop = true;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnCancel_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(261, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(3, 87);
            this.lblErrorTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(106, 19);
            this.lblErrorTitle.TabIndex = 21;
            this.lblErrorTitle.Text = "Error message";
            this.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorTitle.Visible = false;
            // 
            // lblErrorAuthor
            // 
            this.lblErrorAuthor.AutoSize = true;
            this.lblErrorAuthor.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblErrorAuthor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAuthor.Location = new System.Drawing.Point(3, 87);
            this.lblErrorAuthor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblErrorAuthor.Name = "lblErrorAuthor";
            this.lblErrorAuthor.Size = new System.Drawing.Size(106, 19);
            this.lblErrorAuthor.TabIndex = 21;
            this.lblErrorAuthor.Text = "Error message";
            this.lblErrorAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorAuthor.Visible = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.authorContainer);
            this.Controls.Add(this.titleContainer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.userInfoContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit book";
            this.Load += new System.EventHandler(this.Update_Load);
            this.userInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.titleContainer.ResumeLayout(false);
            this.titleContainer.PerformLayout();
            this.authorContainer.ResumeLayout(false);
            this.authorContainer.PerformLayout();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.FlowLayoutPanel titleContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.FlowLayoutPanel authorContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.LinkLabel btnCancel;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorAuthor;
    }
}