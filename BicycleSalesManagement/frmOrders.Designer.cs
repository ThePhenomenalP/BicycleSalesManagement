namespace BicycleSalesManagement
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddOrder = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiscountPercent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtItemCount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cmbProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 7;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.btnPrint.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.HoverState.Image")));
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(23, 23);
            this.btnPrint.Location = new System.Drawing.Point(10, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(39, 32);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 13;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.Location = new System.Drawing.Point(57, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "جستجو سفارشات مورد نظر";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(250, 32);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.HoverState.Image")));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(27, 27);
            this.btnDelete.Location = new System.Drawing.Point(266, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(158, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "ح&ذف سفارش";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddOrder.BorderRadius = 20;
            this.btnAddOrder.CheckedState.Parent = this.btnAddOrder;
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.CustomImages.Parent = this.btnAddOrder;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddOrder.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddOrder.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.HoverState.Image")));
            this.btnAddOrder.HoverState.Parent = this.btnAddOrder;
            this.btnAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.Image")));
            this.btnAddOrder.ImageSize = new System.Drawing.Size(27, 27);
            this.btnAddOrder.Location = new System.Drawing.Point(454, 336);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddOrder.ShadowDecoration.Parent = this.btnAddOrder;
            this.btnAddOrder.Size = new System.Drawing.Size(158, 45);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "&افزودن سفارش";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrice.HintForeColor = System.Drawing.Color.White;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.White;
            this.txtPrice.LineIdleColor = System.Drawing.Color.White;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(443, 243);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(250, 36);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.OnValueChanged += new System.EventHandler(this.txtOrderDate_OnValueChanged);
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtDiscountPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountPercent.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDiscountPercent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtDiscountPercent.HintForeColor = System.Drawing.Color.White;
            this.txtDiscountPercent.HintText = "";
            this.txtDiscountPercent.isPassword = false;
            this.txtDiscountPercent.LineFocusedColor = System.Drawing.Color.White;
            this.txtDiscountPercent.LineIdleColor = System.Drawing.Color.White;
            this.txtDiscountPercent.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtDiscountPercent.LineThickness = 3;
            this.txtDiscountPercent.Location = new System.Drawing.Point(443, 185);
            this.txtDiscountPercent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscountPercent.Size = new System.Drawing.Size(250, 36);
            this.txtDiscountPercent.TabIndex = 20;
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscountPercent.OnValueChanged += new System.EventHandler(this.txtOrderDate_OnValueChanged);
            this.txtDiscountPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            this.txtDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountPercent_KeyPress);
            // 
            // txtItemCount
            // 
            this.txtItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtItemCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCount.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtItemCount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtItemCount.HintForeColor = System.Drawing.Color.White;
            this.txtItemCount.HintText = "";
            this.txtItemCount.isPassword = false;
            this.txtItemCount.LineFocusedColor = System.Drawing.Color.White;
            this.txtItemCount.LineIdleColor = System.Drawing.Color.White;
            this.txtItemCount.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtItemCount.LineThickness = 3;
            this.txtItemCount.Location = new System.Drawing.Point(443, 128);
            this.txtItemCount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemCount.Size = new System.Drawing.Size(250, 36);
            this.txtItemCount.TabIndex = 19;
            this.txtItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemCount.OnValueChanged += new System.EventHandler(this.txtOrderDate_OnValueChanged);
            this.txtItemCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            this.txtItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderDate_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrice.Location = new System.Drawing.Point(701, 244);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(110, 29);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "قیمت هر سفارش:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDiscountPercent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDiscountPercent.Location = new System.Drawing.Point(701, 185);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDiscountPercent.Size = new System.Drawing.Size(115, 29);
            this.lblDiscountPercent.TabIndex = 13;
            this.lblDiscountPercent.Text = "تخفیف داده شده :";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblItemCount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblItemCount.Location = new System.Drawing.Point(701, 129);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemCount.Size = new System.Drawing.Size(105, 29);
            this.lblItemCount.TabIndex = 12;
            this.lblItemCount.Text = "تعداد سفارشات :";
            this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblProductName.Location = new System.Drawing.Point(277, 133);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProductName.Size = new System.Drawing.Size(84, 29);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "نام محصول :";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCustomerName.Location = new System.Drawing.Point(127, 212);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(81, 29);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "نام مشتری :";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStoreName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStoreName.Location = new System.Drawing.Point(269, 212);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStoreName.Size = new System.Drawing.Size(88, 29);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "نام فروشگاه :";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.bunifuGradientPanel1);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel4);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel6);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel3);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel5);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel2.Controls.Add(this.cmbProductName);
            this.guna2Panel2.Controls.Add(this.cmbCustomerName);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnAddOrder);
            this.guna2Panel2.Controls.Add(this.txtPrice);
            this.guna2Panel2.Controls.Add(this.txtDiscountPercent);
            this.guna2Panel2.Controls.Add(this.txtItemCount);
            this.guna2Panel2.Controls.Add(this.lblPrice);
            this.guna2Panel2.Controls.Add(this.lblDiscountPercent);
            this.guna2Panel2.Controls.Add(this.lblItemCount);
            this.guna2Panel2.Controls.Add(this.lblProductName);
            this.guna2Panel2.Controls.Add(this.lblCustomerName);
            this.guna2Panel2.Controls.Add(this.lblStoreName);
            this.guna2Panel2.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(865, 406);
            this.guna2Panel2.TabIndex = 6;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.Controls.Add(this.btnPrint);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 13);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(865, 65);
            this.bunifuGradientPanel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(676, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "بخش سفارشات";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 18;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(60)))), ((int)(((byte)(48)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(118, 348);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.ShadowDecoration.Parent = this.guna2GradientPanel4;
            this.guna2GradientPanel4.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel4.TabIndex = 33;
            // 
            // guna2GradientPanel6
            // 
            this.guna2GradientPanel6.BorderRadius = 18;
            this.guna2GradientPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel6.Location = new System.Drawing.Point(60, 316);
            this.guna2GradientPanel6.Name = "guna2GradientPanel6";
            this.guna2GradientPanel6.ShadowDecoration.Parent = this.guna2GradientPanel6;
            this.guna2GradientPanel6.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel6.TabIndex = 31;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BorderRadius = 18;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(60)))), ((int)(((byte)(48)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(710, 348);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel3.TabIndex = 30;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 18;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(771, 316);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel1.TabIndex = 28;
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BorderRadius = 18;
            this.guna2GradientPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel5.Location = new System.Drawing.Point(3, 265);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.ShadowDecoration.Parent = this.guna2GradientPanel5;
            this.guna2GradientPanel5.Size = new System.Drawing.Size(37, 157);
            this.guna2GradientPanel5.TabIndex = 32;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 18;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(826, 261);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(37, 161);
            this.guna2GradientPanel2.TabIndex = 29;
            // 
            // cmbProductName
            // 
            this.cmbProductName.BackColor = System.Drawing.Color.Transparent;
            this.cmbProductName.BorderColor = System.Drawing.Color.White;
            this.cmbProductName.BorderRadius = 8;
            this.cmbProductName.BorderThickness = 3;
            this.cmbProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.cmbProductName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProductName.FocusedState.Parent = this.cmbProductName;
            this.cmbProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProductName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProductName.HoverState.Parent = this.cmbProductName;
            this.cmbProductName.ItemHeight = 30;
            this.cmbProductName.ItemsAppearance.Parent = this.cmbProductName;
            this.cmbProductName.Location = new System.Drawing.Point(118, 165);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProductName.ShadowDecoration.Parent = this.cmbProductName;
            this.cmbProductName.Size = new System.Drawing.Size(250, 36);
            this.cmbProductName.TabIndex = 17;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbStoreName_SelectedIndexChanged);
            this.cmbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCustomerName.BorderColor = System.Drawing.Color.White;
            this.cmbCustomerName.BorderRadius = 8;
            this.cmbCustomerName.BorderThickness = 3;
            this.cmbCustomerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.cmbCustomerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCustomerName.FocusedState.Parent = this.cmbCustomerName;
            this.cmbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomerName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbCustomerName.HoverState.Parent = this.cmbCustomerName;
            this.cmbCustomerName.ItemHeight = 30;
            this.cmbCustomerName.ItemsAppearance.Parent = this.cmbCustomerName;
            this.cmbCustomerName.Location = new System.Drawing.Point(118, 244);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCustomerName.ShadowDecoration.Parent = this.cmbCustomerName;
            this.cmbCustomerName.Size = new System.Drawing.Size(250, 36);
            this.cmbCustomerName.TabIndex = 15;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbStoreName_SelectedIndexChanged);
            this.cmbCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 193);
            this.panel1.TabIndex = 7;
            // 
            // dgvOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeight = 25;
            this.dgvOrders.ContextMenuStrip = this.cmsEdit;
            this.dgvOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(865, 193);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrders.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvOrders.ThemeStyle.ReadOnly = true;
            this.dgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrders.ThemeStyle.RowsStyle.Height = 22;
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditItemTool});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(117, 32);
            // 
            // cmsEditItemTool
            // 
            this.cmsEditItemTool.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmsEditItemTool.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmsEditItemTool.Image = ((System.Drawing.Image)(resources.GetObject("cmsEditItemTool.Image")));
            this.cmsEditItemTool.Name = "cmsEditItemTool";
            this.cmsEditItemTool.Size = new System.Drawing.Size(116, 28);
            this.cmsEditItemTool.Text = "ویرایش";
            this.cmsEditItemTool.Click += new System.EventHandler(this.cmsEditItemTool_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAddOrder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiscountPercent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblStoreName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProductName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCustomerName;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsEditItemTool;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
    }
}