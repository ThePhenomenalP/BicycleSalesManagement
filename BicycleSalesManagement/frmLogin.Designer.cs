namespace BicycleSalesManagement
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.chbRimemberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblRegister = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logInPanel = new System.Windows.Forms.Panel();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.txtPassword2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.logInPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BorderRadius = 10;
            this.btnEnter.CheckedState.Parent = this.btnEnter;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.CustomImages.Parent = this.btnEnter;
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnter.Enabled = false;
            this.btnEnter.FillColor = System.Drawing.Color.Yellow;
            this.btnEnter.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnEnter.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnEnter.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnter.HoverState.Parent = this.btnEnter;
            this.btnEnter.Location = new System.Drawing.Point(26, 416);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.ShadowDecoration.Parent = this.btnEnter;
            this.btnEnter.Size = new System.Drawing.Size(295, 38);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "ورود";
            this.btnEnter.TextOffset = new System.Drawing.Point(0, -3);
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 6);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(217, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "         مدیریت فروش دوچرخه\r\nBicycle Sales Management";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(306, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // chbRimemberMe
            // 
            this.chbRimemberMe.AutoSize = true;
            this.chbRimemberMe.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbRimemberMe.ForeColor = System.Drawing.Color.Snow;
            this.chbRimemberMe.Location = new System.Drawing.Point(145, 113);
            this.chbRimemberMe.Name = "chbRimemberMe";
            this.chbRimemberMe.Size = new System.Drawing.Size(125, 30);
            this.chbRimemberMe.TabIndex = 8;
            this.chbRimemberMe.Text = "مرا به خاطر بسپار";
            this.chbRimemberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.White;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.White;
            this.txtPassword.LineIdleColor = System.Drawing.Color.White;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(22, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(250, 36);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "رمز عبور";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtUserName_OnValueChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress_1);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.HintForeColor = System.Drawing.Color.White;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.White;
            this.txtUserName.LineIdleColor = System.Drawing.Color.White;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.LineThickness = 2;
            this.txtUserName.Location = new System.Drawing.Point(22, 10);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(250, 36);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Text = "نام کاربری";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.OnValueChanged += new System.EventHandler(this.txtUserName_OnValueChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress_1);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-3, 61);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(350, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblRegister
            // 
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("B Nazanin", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegister.Location = new System.Drawing.Point(75, 457);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(196, 23);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "حساب کاربری ندارید؟ ثبت نام کنید.";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            this.lblRegister.MouseEnter += new System.EventHandler(this.lblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.txtUserName);
            this.logInPanel.Controls.Add(this.chbRimemberMe);
            this.logInPanel.Controls.Add(this.txtPassword);
            this.logInPanel.Location = new System.Drawing.Point(26, 261);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(295, 149);
            this.logInPanel.TabIndex = 13;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.txtPassword2);
            this.RegisterPanel.Controls.Add(this.txtUserName2);
            this.RegisterPanel.Location = new System.Drawing.Point(379, 261);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(295, 149);
            this.RegisterPanel.TabIndex = 14;
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.HintForeColor = System.Drawing.Color.White;
            this.txtPassword2.HintText = "";
            this.txtPassword2.isPassword = false;
            this.txtPassword2.LineFocusedColor = System.Drawing.Color.White;
            this.txtPassword2.LineIdleColor = System.Drawing.Color.White;
            this.txtPassword2.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword2.LineThickness = 3;
            this.txtPassword2.Location = new System.Drawing.Point(23, 64);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword2.Size = new System.Drawing.Size(250, 36);
            this.txtPassword2.TabIndex = 12;
            this.txtPassword2.Text = "رمز عبور";
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.txtPassword2.Enter += new System.EventHandler(this.txtPassword2_Enter);
            this.txtPassword2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword2_KeyDown);
            this.txtPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword2_KeyPress);
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // txtUserName2
            // 
            this.txtUserName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.txtUserName2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName2.ForeColor = System.Drawing.Color.White;
            this.txtUserName2.HintForeColor = System.Drawing.Color.White;
            this.txtUserName2.HintText = "";
            this.txtUserName2.isPassword = false;
            this.txtUserName2.LineFocusedColor = System.Drawing.Color.White;
            this.txtUserName2.LineIdleColor = System.Drawing.Color.White;
            this.txtUserName2.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName2.LineThickness = 3;
            this.txtUserName2.Location = new System.Drawing.Point(23, 10);
            this.txtUserName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName2.Size = new System.Drawing.Size(250, 36);
            this.txtUserName2.TabIndex = 11;
            this.txtUserName2.Text = "نام کاربری";
            this.txtUserName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            this.txtUserName2.Enter += new System.EventHandler(this.txtUserName2_Enter);
            this.txtUserName2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName2_KeyDown);
            this.txtUserName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName2_KeyPress);
            this.txtUserName2.Leave += new System.EventHandler(this.txtUserName2_Leave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(350, 483);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.logInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.CheckBox chbRimemberMe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRegister;
        private System.Windows.Forms.Panel RegisterPanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName2;
        private System.Windows.Forms.Panel logInPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}