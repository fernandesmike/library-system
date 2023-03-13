namespace LibrarySystem
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.userInfoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.image = new System.Windows.Forms.PictureBox();
            this.infoContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.titleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.authorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblErrorAuthor = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
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
            this.userInfoContainer.AutoSize = true;
            this.userInfoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userInfoContainer.Controls.Add(this.image);
            this.userInfoContainer.Controls.Add(this.infoContainer);
            this.userInfoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userInfoContainer.Location = new System.Drawing.Point(49, 27);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(507, 172);
            this.userInfoContainer.TabIndex = 27;
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
            this.infoContainer.Controls.Add(this.lblDescription);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(3, 89);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.infoContainer.Size = new System.Drawing.Size(501, 80);
            this.infoContainer.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(495, 25);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Add new borrower";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(3, 40);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(495, 24);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Please provide the necessary borrower details below";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleContainer
            // 
            this.titleContainer.AutoSize = true;
            this.titleContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleContainer.Controls.Add(this.lblFirst);
            this.titleContainer.Controls.Add(this.txtFirst);
            this.titleContainer.Controls.Add(this.lblErrorTitle);
            this.titleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleContainer.Location = new System.Drawing.Point(49, 229);
            this.titleContainer.Name = "titleContainer";
            this.titleContainer.Size = new System.Drawing.Size(504, 116);
            this.titleContainer.TabIndex = 29;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblFirst.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFirst.Location = new System.Drawing.Point(3, 0);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(82, 21);
            this.lblFirst.TabIndex = 18;
            this.lblFirst.Text = "Book title";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(3, 34);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(498, 50);
            this.txtFirst.TabIndex = 19;
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
            // authorContainer
            // 
            this.authorContainer.AutoSize = true;
            this.authorContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorContainer.Controls.Add(this.lblSecond);
            this.authorContainer.Controls.Add(this.txtSecond);
            this.authorContainer.Controls.Add(this.lblErrorAuthor);
            this.authorContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorContainer.Location = new System.Drawing.Point(49, 353);
            this.authorContainer.Name = "authorContainer";
            this.authorContainer.Size = new System.Drawing.Size(504, 116);
            this.authorContainer.TabIndex = 30;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblSecond.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSecond.Location = new System.Drawing.Point(3, 0);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(63, 21);
            this.lblSecond.TabIndex = 18;
            this.lblSecond.Text = "Author";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(3, 34);
            this.txtSecond.Multiline = true;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(498, 50);
            this.txtSecond.TabIndex = 19;
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
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnCancel);
            this.btnContainer.Controls.Add(this.btnSave);
            this.btnContainer.Location = new System.Drawing.Point(49, 501);
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
            this.btnSave.Text = "Add borrower";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 613);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.authorContainer);
            this.Controls.Add(this.titleContainer);
            this.Controls.Add(this.userInfoContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.userInfoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.infoContainer.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel infoContainer;
        internal System.Windows.Forms.PictureBox image;
        internal System.Windows.Forms.FlowLayoutPanel userInfoContainer;
        internal System.Windows.Forms.FlowLayoutPanel titleContainer;
        internal System.Windows.Forms.FlowLayoutPanel authorContainer;
        internal System.Windows.Forms.Panel btnContainer;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblDescription;
        internal System.Windows.Forms.Label lblSecond;
        internal System.Windows.Forms.Label lblFirst;
        internal System.Windows.Forms.TextBox txtFirst;
        internal System.Windows.Forms.TextBox txtSecond;
        internal System.Windows.Forms.Label lblErrorTitle;
        internal System.Windows.Forms.Label lblErrorAuthor;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.LinkLabel btnCancel;
    }
}