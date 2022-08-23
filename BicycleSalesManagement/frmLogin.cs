using Bunifu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BusinessEntity;

namespace BicycleSalesManagement
{
    public partial class frmLogin : Form
    {
        blClass blc = new blClass();
        public frmMain FrmMain = new frmMain();
        public bool access = false;
        public frmLogin()
        {
            InitializeComponent();
            access = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            if (Properties.Settings.Default.userName != "")
            {
                txtUserName.Text = Properties.Settings.Default.userName;
            }
            if (Properties.Settings.Default.Password != 0)
            {
                txtPassword.Text = Properties.Settings.Default.Password.ToString();
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEnter.Text == "ثبت نام")
                {
                    Login log = new Login();
                    log.UserName = txtUserName2.Text;
                    log.Password = Convert.ToInt32(txtPassword2.Text);
                    MessageBox.Show(blc.register(log), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer2.Start();
                }
                else
                {
                    if (blc.exsit(txtUserName.Text, Convert.ToInt32(txtPassword.Text)) == true)
                    {
                        if (chbRimemberMe.Checked == true)
                        {
                            Properties.Settings.Default.userName = txtUserName.Text;
                            Properties.Settings.Default.Password = Convert.ToInt16(txtPassword.Text);
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.userName = "";
                            Properties.Settings.Default.Password = 0;
                            Properties.Settings.Default.Save();
                        }
                        this.Close();
                        access = true;
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه وارد شده است");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                                   
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chbRimemberMe.Checked == true)
            {
                Properties.Settings.Default.userName = txtUserName.Text;
                Properties.Settings.Default.Password = Convert.ToInt32(txtPassword.Text);
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.userName = "";
                Properties.Settings.Default.Password = 0;
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.DisplayUserName = txtUserName.Text;
            Properties.Settings.Default.Save();
        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtPassword.Text != "رمز عبور" && txtUserName.Text != "نام کاربری")
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtUserName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "نام کاربری")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                //txtUserName.ForeColor = Color.DarkGray;
                txtUserName.Text = "نام کاربری";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "رمز عبور")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                //txtPassword.ForeColor = Color.DarkGray;
                txtPassword.Text = "رمز عبور";
            }
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = SystemColors.MenuHighlight;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = SystemColors.HighlightText;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logInPanel.Left -= 25;
            RegisterPanel.Left -= 25;
            if (RegisterPanel.Left <= 30)
            {
                timer1.Stop();
                btnEnter.Text = "ثبت نام";
                btnEnter.FillColor = Color.FromArgb(78, 88, 169);
                lblRegister.Visible = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            logInPanel.Left += 25;
            RegisterPanel.Left += 25;
            if (logInPanel.Left >= 25)
            {
                timer2.Stop();
                btnEnter.Text = "ورود";
                btnEnter.FillColor = Color.Yellow;
                lblRegister.Visible = false;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            if (txtUserName2.Text != "" && txtPassword2.Text != "" && txtPassword2.Text !="رمز عبور" && txtUserName2.Text !="نام کاربری")
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        private void txtUserName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword2.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtUserName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtUserName2_Enter(object sender, EventArgs e)
        {
            if (txtUserName2.Text == "نام کاربری")
            {
                txtUserName2.Text = "";
                txtUserName2.ForeColor = Color.White;
            }
        }

        private void txtUserName2_Leave(object sender, EventArgs e)
        {
            if (txtUserName2.Text == "")
            {
                //txtUserName2.ForeColor = Color.DarkGray;
                txtUserName2.Text = "نام کاربری";
            }
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "رمز عبور")
            {
                txtPassword2.Text = "";
                txtPassword2.ForeColor = Color.White;
            }
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "")
            {
                //txtPassword2.ForeColor = Color.DarkGray;
                txtPassword2.Text = "رمز عبور";
            }
        }
    }
}
