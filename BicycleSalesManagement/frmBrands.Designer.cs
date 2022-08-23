namespace BicycleSalesManagement
{
    partial class frmBrands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrands));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBrand = new Guna.UI2.WinForms.Guna2Button();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBrand = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Panel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.cmsEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(265, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(158, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "ح&ذف برند";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddBrand.BorderRadius = 20;
            this.btnAddBrand.CheckedState.Parent = this.btnAddBrand;
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.CustomImages.Parent = this.btnAddBrand;
            this.btnAddBrand.Enabled = false;
            this.btnAddBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddBrand.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddBrand.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddBrand.HoverState.Parent = this.btnAddBrand;
            this.btnAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.Image")));
            this.btnAddBrand.ImageSize = new System.Drawing.Size(27, 27);
            this.btnAddBrand.Location = new System.Drawing.Point(453, 336);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddBrand.ShadowDecoration.Parent = this.btnAddBrand;
            this.btnAddBrand.Size = new System.Drawing.Size(158, 45);
            this.btnAddBrand.TabIndex = 0;
            this.btnAddBrand.Text = "&افزودن برند";
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtTitle.HintForeColor = System.Drawing.Color.White;
            this.txtTitle.HintText = "";
            this.txtTitle.isPassword = false;
            this.txtTitle.LineFocusedColor = System.Drawing.Color.White;
            this.txtTitle.LineIdleColor = System.Drawing.Color.White;
            this.txtTitle.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtTitle.LineThickness = 3;
            this.txtTitle.Location = new System.Drawing.Point(307, 162);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(250, 36);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.OnValueChanged += new System.EventHandler(this.txtName_OnValueChanged);
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(562, 163);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(66, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نام برند :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel4);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel6);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel3);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel5);
            this.guna2Panel2.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel2.Controls.Add(this.btnPrint);
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Controls.Add(this.bunifuGradientPanel1);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnAddBrand);
            this.guna2Panel2.Controls.Add(this.txtTitle);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(865, 406);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 18;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(60)))), ((int)(((byte)(48)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(116, 350);
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
            this.guna2GradientPanel6.Location = new System.Drawing.Point(58, 318);
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
            this.guna2GradientPanel3.Location = new System.Drawing.Point(710, 350);
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
            this.guna2GradientPanel1.Location = new System.Drawing.Point(771, 318);
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
            this.guna2GradientPanel5.Location = new System.Drawing.Point(1, 267);
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
            this.guna2GradientPanel2.Location = new System.Drawing.Point(826, 263);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(37, 161);
            this.guna2GradientPanel2.TabIndex = 29;
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
            this.btnPrint.Location = new System.Drawing.Point(10, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(39, 32);
            this.btnPrint.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnPrint, "Print");
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
            this.txtSearch.Location = new System.Drawing.Point(57, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "جستجو برند مورد نظر";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(250, 32);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 14);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(865, 65);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(619, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "بخش برند محصولات";
            // 
            // dgvBrand
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvBrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrand.ColumnHeadersHeight = 25;
            this.dgvBrand.ContextMenuStrip = this.cmsEdit;
            this.dgvBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvBrand.Location = new System.Drawing.Point(0, 0);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBrand.RowHeadersVisible = false;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.Size = new System.Drawing.Size(865, 193);
            this.dgvBrand.TabIndex = 0;
            this.dgvBrand.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvBrand.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvBrand.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBrand.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBrand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBrand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBrand.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvBrand.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvBrand.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvBrand.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBrand.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBrand.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBrand.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBrand.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvBrand.ThemeStyle.ReadOnly = true;
            this.dgvBrand.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvBrand.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBrand.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBrand.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBrand.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBrand.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvBrand.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellClick);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditItem});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(117, 32);
            // 
            // cmsEditItem
            // 
            this.cmsEditItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmsEditItem.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmsEditItem.Image = ((System.Drawing.Image)(resources.GetObject("cmsEditItem.Image")));
            this.cmsEditItem.Name = "cmsEditItem";
            this.cmsEditItem.Size = new System.Drawing.Size(116, 28);
            this.cmsEditItem.Text = "ویرایش";
            this.cmsEditItem.Click += new System.EventHandler(this.cmsEditItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBrand);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 193);
            this.panel2.TabIndex = 6;
            // 
            // frmBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrands";
            this.Text = "frmBrands";
            this.Load += new System.EventHandler(this.frmBrands_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.cmsEdit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAddBrand;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsEditItem;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
    }
}