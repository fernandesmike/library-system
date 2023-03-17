namespace LibrarySystem
{
    partial class Test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpDataGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.radioContainer = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.flpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.radioContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpDataGrid
            // 
            this.flpDataGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.flpDataGrid.Controls.Add(this.lblUpdateMessage);
            this.flpDataGrid.Controls.Add(this.radioContainer);
            this.flpDataGrid.Controls.Add(this.dataGrid);
            this.flpDataGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDataGrid.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.flpDataGrid.Location = new System.Drawing.Point(175, 71);
            this.flpDataGrid.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpDataGrid.Name = "flpDataGrid";
            this.flpDataGrid.Size = new System.Drawing.Size(1041, 453);
            this.flpDataGrid.TabIndex = 37;
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoEllipsis = true;
            this.lblUpdateMessage.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUpdateMessage.Font = new System.Drawing.Font("Outfit SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMessage.ForeColor = System.Drawing.Color.White;
            this.lblUpdateMessage.Location = new System.Drawing.Point(3, 0);
            this.lblUpdateMessage.MinimumSize = new System.Drawing.Size(213, 31);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblUpdateMessage.Size = new System.Drawing.Size(1038, 31);
            this.lblUpdateMessage.TabIndex = 45;
            this.lblUpdateMessage.Text = "Update message goes here";
            this.lblUpdateMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUpdateMessage.Visible = false;
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
            this.dataGrid.Location = new System.Drawing.Point(3, 85);
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
            this.dataGrid.Size = new System.Drawing.Size(1038, 354);
            this.dataGrid.TabIndex = 40;
            // 
            // radioContainer
            // 
            this.radioContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radioContainer.Controls.Add(this.rbAll);
            this.radioContainer.Controls.Add(this.lblGridTitle);
            this.radioContainer.Controls.Add(this.rbActive);
            this.radioContainer.Controls.Add(this.rbInactive);
            this.radioContainer.Location = new System.Drawing.Point(3, 34);
            this.radioContainer.Name = "radioContainer";
            this.radioContainer.Size = new System.Drawing.Size(1032, 45);
            this.radioContainer.TabIndex = 46;
            // 
            // rbAll
            // 
            this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbAll.Location = new System.Drawing.Point(761, 10);
            this.rbAll.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(52, 23);
            this.rbAll.TabIndex = 35;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All ";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoEllipsis = true;
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Outfit", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGridTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGridTitle.Location = new System.Drawing.Point(3, 8);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(139, 24);
            this.lblGridTitle.TabIndex = 39;
            this.lblGridTitle.Text = "All borrowers";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbActive
            // 
            this.rbActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbActive.Location = new System.Drawing.Point(839, 10);
            this.rbActive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(83, 23);
            this.rbActive.TabIndex = 36;
            this.rbActive.Text = "Inactive";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            this.rbInactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbInactive.Location = new System.Drawing.Point(951, 10);
            this.rbInactive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(75, 23);
            this.rbInactive.TabIndex = 37;
            this.rbInactive.Text = "Active ";
            this.rbInactive.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 675);
            this.Controls.Add(this.flpDataGrid);
            this.Name = "Test";
            this.Text = "Test";
            this.flpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.radioContainer.ResumeLayout(false);
            this.radioContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flpDataGrid;
        internal System.Windows.Forms.Label lblUpdateMessage;
        internal System.Windows.Forms.Panel radioContainer;
        internal System.Windows.Forms.RadioButton rbAll;
        internal System.Windows.Forms.Label lblGridTitle;
        internal System.Windows.Forms.RadioButton rbActive;
        internal System.Windows.Forms.RadioButton rbInactive;
        internal System.Windows.Forms.DataGridView dataGrid;
    }
}