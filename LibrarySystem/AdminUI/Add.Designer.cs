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
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.titleContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.authorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.userInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.infoContainer.SuspendLayout();
            this.titleContainer.SuspendLayout();
            this.authorContainer.SuspendLayout();
            this.btnContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.userInfoContainer.Controls.Add(this.lblErrorTitle);
            this.userInfoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userInfoContainer.Location = new System.Drawing.Point(37, 22);
            this.userInfoContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInfoContainer.Name = "userInfoContainer";
            this.userInfoContainer.Size = new System.Drawing.Size(380, 178);
            this.userInfoContainer.TabIndex = 27;
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(2, 2);
            this.image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.infoContainer.Controls.Add(this.lblDescription);
            this.infoContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.infoContainer.Location = new System.Drawing.Point(2, 71);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.infoContainer.Size = new System.Drawing.Size(376, 65);
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
            this.lblTitle.Text = "Add new borrower";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(2, 32);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(371, 20);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Please provide the necessary borrower details below";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblErrorTitle.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTitle.Location = new System.Drawing.Point(2, 146);
            this.lblErrorTitle.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(376, 24);
            this.lblErrorTitle.TabIndex = 27;
            this.lblErrorTitle.Text = "Error message";
            this.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorTitle.Visible = false;
            // 
            // titleContainer
            // 
            this.titleContainer.AutoSize = true;
            this.titleContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleContainer.Controls.Add(this.lblFirst);
            this.titleContainer.Controls.Add(this.txtFirst);
            this.titleContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.titleContainer.Location = new System.Drawing.Point(37, 201);
            this.titleContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleContainer.Name = "titleContainer";
            this.titleContainer.Size = new System.Drawing.Size(378, 71);
            this.titleContainer.TabIndex = 29;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblFirst.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFirst.Location = new System.Drawing.Point(2, 0);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(67, 18);
            this.lblFirst.TabIndex = 18;
            this.lblFirst.Text = "Book title";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(2, 28);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(374, 41);
            this.txtFirst.TabIndex = 19;
            // 
            // authorContainer
            // 
            this.authorContainer.AutoSize = true;
            this.authorContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorContainer.Controls.Add(this.lblSecond);
            this.authorContainer.Controls.Add(this.txtSecond);
            this.authorContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorContainer.Location = new System.Drawing.Point(37, 298);
            this.authorContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorContainer.Name = "authorContainer";
            this.authorContainer.Size = new System.Drawing.Size(378, 71);
            this.authorContainer.TabIndex = 30;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblSecond.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSecond.Location = new System.Drawing.Point(2, 0);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(52, 18);
            this.lblSecond.TabIndex = 18;
            this.lblSecond.Text = "Author";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(2, 28);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSecond.Multiline = true;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(374, 41);
            this.txtSecond.TabIndex = 19;
            // 
            // btnContainer
            // 
            this.btnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContainer.Controls.Add(this.btnCancel);
            this.btnContainer.Controls.Add(this.btnSave);
            this.btnContainer.Location = new System.Drawing.Point(37, 509);
            this.btnContainer.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(378, 42);
            this.btnContainer.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Outfit", 10.8F);
            this.btnCancel.Location = new System.Drawing.Point(65, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 19);
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
            this.btnSave.Location = new System.Drawing.Point(196, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 41);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Add borrower";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblUsername);
            this.flowLayoutPanel1.Controls.Add(this.txtUsername);
            this.flowLayoutPanel1.Controls.Add(this.lblQuantityError);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 387);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 103);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Outfit", 10F);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUsername.Location = new System.Drawing.Point(2, 0);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 18);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(2, 28);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(374, 41);
            this.txtUsername.TabIndex = 19;
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.Font = new System.Drawing.Font("Outfit", 9F);
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(2, 71);
            this.lblQuantityError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 8);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(376, 24);
            this.lblQuantityError.TabIndex = 28;
            this.lblQuantityError.Text = "Please enter valid quantity";
            this.lblQuantityError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantityError.Visible = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 567);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.authorContainer);
            this.Controls.Add(this.titleContainer);
            this.Controls.Add(this.userInfoContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.LinkLabel btnCancel;
        internal System.Windows.Forms.Label lblErrorTitle;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblQuantityError;
    }
}