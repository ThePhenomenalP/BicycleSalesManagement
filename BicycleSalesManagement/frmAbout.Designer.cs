namespace BicycleSalesManagement
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelCopyright = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelProductName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Controls.Add(this.labelCopyright);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.labelProductName);
            this.panel1.Location = new System.Drawing.Point(247, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 368);
            this.panel1.TabIndex = 0;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCompanyName.Location = new System.Drawing.Point(507, 234);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCompanyName.Size = new System.Drawing.Size(105, 20);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "شرکت کد تجاری";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelCopyright.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCopyright.Location = new System.Drawing.Point(428, 161);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCopyright.Size = new System.Drawing.Size(182, 20);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright ©  2021 - SMRT";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelVersion.Location = new System.Drawing.Point(527, 90);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelVersion.Size = new System.Drawing.Size(83, 20);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "ورژن 1.0.0.0";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelProductName.Location = new System.Drawing.Point(460, 21);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProductName.Size = new System.Drawing.Size(152, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "مدیریت فروش دوچرخه";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.textBoxDescription);
            this.panel2.Location = new System.Drawing.Point(247, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 229);
            this.panel2.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.textBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescription.DefaultText = resources.GetString("textBoxDescription.DefaultText");
            this.textBoxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.DisabledState.Parent = this.textBoxDescription;
            this.textBoxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.textBoxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.FocusedState.Parent = this.textBoxDescription;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDescription.HoverState.Parent = this.textBoxDescription;
            this.textBoxDescription.Location = new System.Drawing.Point(6, 14);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.PasswordChar = '\0';
            this.textBoxDescription.PlaceholderText = "";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDescription.SelectedText = "";
            this.textBoxDescription.SelectionStart = 771;
            this.textBoxDescription.ShadowDecoration.Parent = this.textBoxDescription;
            this.textBoxDescription.Size = new System.Drawing.Size(606, 209);
            this.textBoxDescription.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 589);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this.pictureBox1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.textBoxDescription;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(865, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAbout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelCompanyName;
        private Bunifu.Framework.UI.BunifuCustomLabel labelCopyright;
        private Bunifu.Framework.UI.BunifuCustomLabel labelVersion;
        private Bunifu.Framework.UI.BunifuCustomLabel labelProductName;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
