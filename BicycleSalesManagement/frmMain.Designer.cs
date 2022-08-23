namespace BicycleSalesManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblBicycleSalesManagement = new System.Windows.Forms.Label();
            this.pbBike = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnStores = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrand = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.dashBoardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBike)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.guna2PictureBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(797, 514);
            this.mainPanel.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(797, 514);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(493, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.HoverState.Image")));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(969, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(56, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBicycleSalesManagement
            // 
            this.lblBicycleSalesManagement.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBicycleSalesManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBicycleSalesManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBicycleSalesManagement.Location = new System.Drawing.Point(126, 0);
            this.lblBicycleSalesManagement.Name = "lblBicycleSalesManagement";
            this.lblBicycleSalesManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBicycleSalesManagement.Size = new System.Drawing.Size(176, 36);
            this.lblBicycleSalesManagement.TabIndex = 4;
            this.lblBicycleSalesManagement.Text = "مدیریت فروش دوچرخه";
            this.lblBicycleSalesManagement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbBike
            // 
            this.pbBike.Image = ((System.Drawing.Image)(resources.GetObject("pbBike.Image")));
            this.pbBike.Location = new System.Drawing.Point(73, 0);
            this.pbBike.Name = "pbBike";
            this.pbBike.Size = new System.Drawing.Size(33, 36);
            this.pbBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBike.TabIndex = 3;
            this.pbBike.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.lblUserName);
            this.headerPanel.Controls.Add(this.btnExit);
            this.headerPanel.Controls.Add(this.lblBicycleSalesManagement);
            this.headerPanel.Controls.Add(this.btnMin);
            this.headerPanel.Controls.Add(this.btnMax);
            this.headerPanel.Controls.Add(this.pbBike);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.headerPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.ShadowDecoration.Parent = this.headerPanel;
            this.headerPanel.Size = new System.Drawing.Size(1025, 36);
            this.headerPanel.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.CustomIconSize = 12F;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnMin.HoverState.Parent = this.btnMin;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(863, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.ShadowDecoration.Parent = this.btnMin;
            this.btnMin.Size = new System.Drawing.Size(56, 36);
            this.btnMin.TabIndex = 2;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.CustomIconSize = 12F;
            this.btnMax.FillColor = System.Drawing.Color.Transparent;
            this.btnMax.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnMax.HoverState.Parent = this.btnMax;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(916, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.ShadowDecoration.Parent = this.btnMax;
            this.btnMax.Size = new System.Drawing.Size(56, 36);
            this.btnMax.TabIndex = 1;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomers.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnCustomers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnCustomers.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.HoverState.Image")));
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(228, 66);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "بخش &مشتری ها";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.CheckedState.Parent = this.btnOrders;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.CustomImages.Parent = this.btnOrders;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FillColor = System.Drawing.Color.Transparent;
            this.btnOrders.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnOrders.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnOrders.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.HoverState.Image")));
            this.btnOrders.HoverState.Parent = this.btnOrders;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOrders.Location = new System.Drawing.Point(0, 66);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrders.ShadowDecoration.Parent = this.btnOrders;
            this.btnOrders.Size = new System.Drawing.Size(228, 66);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "بخش &سفارشات";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStores
            // 
            this.btnStores.BackColor = System.Drawing.Color.Transparent;
            this.btnStores.CheckedState.Parent = this.btnStores;
            this.btnStores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStores.CustomImages.Parent = this.btnStores;
            this.btnStores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStores.FillColor = System.Drawing.Color.Transparent;
            this.btnStores.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStores.ForeColor = System.Drawing.Color.White;
            this.btnStores.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnStores.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnStores.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnStores.HoverState.Image")));
            this.btnStores.HoverState.Parent = this.btnStores;
            this.btnStores.Image = ((System.Drawing.Image)(resources.GetObject("btnStores.Image")));
            this.btnStores.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStores.Location = new System.Drawing.Point(0, 132);
            this.btnStores.Name = "btnStores";
            this.btnStores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStores.ShadowDecoration.Parent = this.btnStores;
            this.btnStores.Size = new System.Drawing.Size(228, 66);
            this.btnStores.TabIndex = 2;
            this.btnStores.Text = "بخش &فروشگاه ها";
            this.btnStores.Click += new System.EventHandler(this.btnStores_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.CheckedState.Parent = this.btnProducts;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.CustomImages.Parent = this.btnProducts;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FillColor = System.Drawing.Color.Transparent;
            this.btnProducts.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnProducts.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnProducts.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.HoverState.Image")));
            this.btnProducts.HoverState.Parent = this.btnProducts;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageSize = new System.Drawing.Size(25, 25);
            this.btnProducts.Location = new System.Drawing.Point(0, 198);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProducts.ShadowDecoration.Parent = this.btnProducts;
            this.btnProducts.Size = new System.Drawing.Size(228, 66);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "بخش م&حصولات";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.Transparent;
            this.btnBrand.CheckedState.Parent = this.btnBrand;
            this.btnBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrand.CustomImages.Parent = this.btnBrand;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.FillColor = System.Drawing.Color.Transparent;
            this.btnBrand.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnBrand.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnBrand.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.HoverState.Image")));
            this.btnBrand.HoverState.Parent = this.btnBrand;
            this.btnBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnBrand.Image")));
            this.btnBrand.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBrand.Location = new System.Drawing.Point(0, 264);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBrand.ShadowDecoration.Parent = this.btnBrand;
            this.btnBrand.Size = new System.Drawing.Size(228, 66);
            this.btnBrand.TabIndex = 4;
            this.btnBrand.Text = "بخش بر&ند محصولات";
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.CustomImages.Parent = this.btnAbout;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FillColor = System.Drawing.Color.Transparent;
            this.btnAbout.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnAbout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.btnAbout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.HoverState.Image")));
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(0, 330);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(228, 66);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "درباره &برنامه";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.Controls.Add(this.btnAbout);
            this.dashBoardPanel.Controls.Add(this.btnBrand);
            this.dashBoardPanel.Controls.Add(this.btnProducts);
            this.dashBoardPanel.Controls.Add(this.btnStores);
            this.dashBoardPanel.Controls.Add(this.btnOrders);
            this.dashBoardPanel.Controls.Add(this.btnCustomers);
            this.dashBoardPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashBoardPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dashBoardPanel.Location = new System.Drawing.Point(797, 36);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.ShadowDecoration.Parent = this.dashBoardPanel;
            this.dashBoardPanel.Size = new System.Drawing.Size(228, 514);
            this.dashBoardPanel.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1025, 550);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dashBoardPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فروش دوچرخه";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBike)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.dashBoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label lblBicycleSalesManagement;
        private System.Windows.Forms.PictureBox pbBike;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel headerPanel;
        private Guna.UI2.WinForms.Guna2ControlBox btnMin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMax;
        private Guna.UI2.WinForms.Guna2Panel dashBoardPanel;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnBrand;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnStores;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
    }
}

