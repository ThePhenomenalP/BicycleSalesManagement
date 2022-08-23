namespace BicycleSalesManagement
{
    partial class frmStores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStore = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblStateCode = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtCityName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStateCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtZipCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddStore = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.cmsEdit.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 193);
            this.panel1.TabIndex = 6;
            // 
            // dgvStore
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStore.ColumnHeadersHeight = 25;
            this.dgvStore.ContextMenuStrip = this.cmsEdit;
            this.dgvStore.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStore.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStore.EnableHeadersVisualStyles = false;
            this.dgvStore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvStore.Location = new System.Drawing.Point(0, 0);
            this.dgvStore.MultiSelect = false;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStore.RowHeadersVisible = false;
            this.dgvStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStore.Size = new System.Drawing.Size(865, 193);
            this.dgvStore.TabIndex = 1;
            this.dgvStore.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvStore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvStore.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStore.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStore.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStore.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStore.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgvStore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvStore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvStore.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStore.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStore.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvStore.ThemeStyle.ReadOnly = true;
            this.dgvStore.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvStore.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStore.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvStore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStore_CellClick_1);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditItem});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(153, 54);
            // 
            // cmsEditItem
            // 
            this.cmsEditItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmsEditItem.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmsEditItem.Image = ((System.Drawing.Image)(resources.GetObject("cmsEditItem.Image")));
            this.cmsEditItem.Name = "cmsEditItem";
            this.cmsEditItem.Size = new System.Drawing.Size(152, 28);
            this.cmsEditItem.Text = "ویرایش";
            this.cmsEditItem.Click += new System.EventHandler(this.cmsEditItem_Click);
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
            this.toolTip1.SetToolTip(this.btnPrint, "Print");
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(733, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(88, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نام فروشگاه :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(733, 161);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(82, 29);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "شماره تلفن :";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmail.Location = new System.Drawing.Point(735, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmail.Size = new System.Drawing.Size(52, 29);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "ایمیل :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtTitle.HintForeColor = System.Drawing.Color.White;
            this.txtTitle.HintText = "";
            this.txtTitle.isPassword = false;
            this.txtTitle.LineFocusedColor = System.Drawing.Color.White;
            this.txtTitle.LineIdleColor = System.Drawing.Color.White;
            this.txtTitle.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtTitle.LineThickness = 3;
            this.txtTitle.Location = new System.Drawing.Point(476, 95);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(250, 36);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityName_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAddress.Location = new System.Drawing.Point(735, 277);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(60, 29);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "آدرس :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCityName
            // 
            this.lblCityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCityName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCityName.Location = new System.Drawing.Point(344, 102);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCityName.Size = new System.Drawing.Size(63, 29);
            this.lblCityName.TabIndex = 12;
            this.lblCityName.Text = "نام شهر :";
            this.lblCityName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateCode
            // 
            this.lblStateCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStateCode.AutoSize = true;
            this.lblStateCode.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStateCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStateCode.Location = new System.Drawing.Point(344, 159);
            this.lblStateCode.Name = "lblStateCode";
            this.lblStateCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStateCode.Size = new System.Drawing.Size(72, 29);
            this.lblStateCode.TabIndex = 13;
            this.lblStateCode.Text = "کد اظهار :";
            this.lblStateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblZipCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblZipCode.Location = new System.Drawing.Point(344, 220);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblZipCode.Size = new System.Drawing.Size(71, 29);
            this.lblZipCode.TabIndex = 14;
            this.lblZipCode.Text = "کد پستی :";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCityName
            // 
            this.txtCityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtCityName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCityName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCityName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCityName.HintForeColor = System.Drawing.Color.White;
            this.txtCityName.HintText = "";
            this.txtCityName.isPassword = false;
            this.txtCityName.LineFocusedColor = System.Drawing.Color.White;
            this.txtCityName.LineIdleColor = System.Drawing.Color.White;
            this.txtCityName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtCityName.LineThickness = 3;
            this.txtCityName.Location = new System.Drawing.Point(85, 95);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCityName.Size = new System.Drawing.Size(250, 36);
            this.txtCityName.TabIndex = 16;
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCityName.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtCityName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityName_KeyPress);
            // 
            // txtStateCode
            // 
            this.txtStateCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtStateCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStateCode.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStateCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtStateCode.HintForeColor = System.Drawing.Color.White;
            this.txtStateCode.HintText = "";
            this.txtStateCode.isPassword = false;
            this.txtStateCode.LineFocusedColor = System.Drawing.Color.White;
            this.txtStateCode.LineIdleColor = System.Drawing.Color.White;
            this.txtStateCode.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtStateCode.LineThickness = 3;
            this.txtStateCode.Location = new System.Drawing.Point(85, 154);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStateCode.Size = new System.Drawing.Size(250, 36);
            this.txtStateCode.TabIndex = 17;
            this.txtStateCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStateCode.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtStateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtStateCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityName_KeyPress);
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZipCode.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtZipCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtZipCode.HintForeColor = System.Drawing.Color.White;
            this.txtZipCode.HintText = "";
            this.txtZipCode.isPassword = false;
            this.txtZipCode.LineFocusedColor = System.Drawing.Color.White;
            this.txtZipCode.LineIdleColor = System.Drawing.Color.White;
            this.txtZipCode.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtZipCode.LineThickness = 3;
            this.txtZipCode.Location = new System.Drawing.Point(85, 215);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtZipCode.Size = new System.Drawing.Size(250, 36);
            this.txtZipCode.TabIndex = 18;
            this.txtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtZipCode.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtZipCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
            // 
            // btnAddStore
            // 
            this.btnAddStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStore.BorderRadius = 20;
            this.btnAddStore.CheckedState.Parent = this.btnAddStore;
            this.btnAddStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStore.CustomImages.Parent = this.btnAddStore;
            this.btnAddStore.Enabled = false;
            this.btnAddStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddStore.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddStore.ForeColor = System.Drawing.Color.White;
            this.btnAddStore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddStore.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStore.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStore.HoverState.Image")));
            this.btnAddStore.HoverState.Parent = this.btnAddStore;
            this.btnAddStore.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStore.Image")));
            this.btnAddStore.ImageSize = new System.Drawing.Size(27, 27);
            this.btnAddStore.Location = new System.Drawing.Point(454, 336);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddStore.ShadowDecoration.Parent = this.btnAddStore;
            this.btnAddStore.Size = new System.Drawing.Size(158, 45);
            this.btnAddStore.TabIndex = 0;
            this.btnAddStore.Text = "&افزودن فروشگاه";
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
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
            this.btnDelete.Text = "ح&ذف فروشگاه";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnPrint);
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1, 14);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(865, 65);
            this.bunifuGradientPanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "بخش فروشگاه ها";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
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
            this.txtSearch.PlaceholderText = "جستجو مشتری مورد نظر";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(250, 32);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 18;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(826, 264);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(37, 161);
            this.guna2GradientPanel2.TabIndex = 29;
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BorderRadius = 18;
            this.guna2GradientPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.guna2GradientPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel5.Location = new System.Drawing.Point(0, 268);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.ShadowDecoration.Parent = this.guna2GradientPanel5;
            this.guna2GradientPanel5.Size = new System.Drawing.Size(37, 157);
            this.guna2GradientPanel5.TabIndex = 32;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 18;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(771, 319);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel1.TabIndex = 28;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BorderRadius = 18;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(60)))), ((int)(((byte)(48)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(710, 351);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel3.TabIndex = 30;
            // 
            // guna2GradientPanel6
            // 
            this.guna2GradientPanel6.BorderRadius = 18;
            this.guna2GradientPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(24)))));
            this.guna2GradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel6.Location = new System.Drawing.Point(57, 319);
            this.guna2GradientPanel6.Name = "guna2GradientPanel6";
            this.guna2GradientPanel6.ShadowDecoration.Parent = this.guna2GradientPanel6;
            this.guna2GradientPanel6.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel6.TabIndex = 31;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 18;
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(60)))), ((int)(((byte)(48)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(115, 351);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.ShadowDecoration.Parent = this.guna2GradientPanel4;
            this.guna2GradientPanel4.Size = new System.Drawing.Size(37, 144);
            this.guna2GradientPanel4.TabIndex = 33;
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
            this.guna2Panel2.Controls.Add(this.bunifuGradientPanel1);
            this.guna2Panel2.Controls.Add(this.btnDelete);
            this.guna2Panel2.Controls.Add(this.btnAddStore);
            this.guna2Panel2.Controls.Add(this.txtZipCode);
            this.guna2Panel2.Controls.Add(this.txtStateCode);
            this.guna2Panel2.Controls.Add(this.txtCityName);
            this.guna2Panel2.Controls.Add(this.txtAddress);
            this.guna2Panel2.Controls.Add(this.lblZipCode);
            this.guna2Panel2.Controls.Add(this.lblStateCode);
            this.guna2Panel2.Controls.Add(this.lblCityName);
            this.guna2Panel2.Controls.Add(this.lblAddress);
            this.guna2Panel2.Controls.Add(this.txtEmail);
            this.guna2Panel2.Controls.Add(this.txtPhoneNumber);
            this.guna2Panel2.Controls.Add(this.txtTitle);
            this.guna2Panel2.Controls.Add(this.lblEmail);
            this.guna2Panel2.Controls.Add(this.lblPhoneNumber);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(865, 405);
            this.guna2Panel2.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddress.HintForeColor = System.Drawing.Color.White;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.White;
            this.txtAddress.LineIdleColor = System.Drawing.Color.White;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(478, 269);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(250, 36);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.HintForeColor = System.Drawing.Color.White;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.White;
            this.txtEmail.LineIdleColor = System.Drawing.Color.White;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(477, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(250, 36);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPhoneNumber.HintForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HintText = "";
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.LineFocusedColor = System.Drawing.Color.White;
            this.txtPhoneNumber.LineIdleColor = System.Drawing.Color.White;
            this.txtPhoneNumber.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPhoneNumber.LineThickness = 3;
            this.txtPhoneNumber.Location = new System.Drawing.Point(475, 153);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 36);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.OnValueChanged += new System.EventHandler(this.txtZipCode_OnValueChanged);
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZipCode_KeyDown);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStores";
            this.Text = "frmStores";
            this.Load += new System.EventHandler(this.frmStores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.cmsEdit.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsEditItem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblStateCode;
        private System.Windows.Forms.Label lblZipCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCityName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStateCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtZipCode;
        private Guna.UI2.WinForms.Guna2Button btnAddStore;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhoneNumber;
    }
}