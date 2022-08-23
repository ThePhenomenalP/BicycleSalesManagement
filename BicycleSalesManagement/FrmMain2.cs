using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BLL;

namespace BicycleSalesManagement
{
    public partial class FrmMain2 : Form
    {
        frmCustomers frmC = new frmCustomers();
        frmOrders frmO = new frmOrders();
        frmStores frmS = new frmStores();
        frmBrands frmB = new frmBrands();
        frmProducts frmP = new frmProducts();
        frmAbout frmA = new frmAbout();
        frmLogin frmL = new frmLogin();
        blClass blc = new blClass();
        public FrmMain2()
        {
            InitializeComponent();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            //imgSlide.Location = new Point(b.Location.X + 0, b.Location.Y - 35);
            //imgSlide.SendToBack();
        }

        private void btnCustomers_CheckedChanged(object sender, EventArgs e)
        {
            //imgSlide.Visible = true;
            //moveImageBox(sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmC.TopLevel = false;
            frmC.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmC);
            frmC.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmO.TopLevel = false;
            frmO.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmO);
            frmO.Show();
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmS.TopLevel = false;
            frmS.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmS);
            frmS.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmP.TopLevel = false;
            frmP.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmP);
            frmP.Show();            
            frmP.cmbBrand.ValueMember = "Id";
            frmP.cmbBrand.DisplayMember = "Title";
            frmP.cmbBrand.DataSource = blc.fillCmbB();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmB.TopLevel = false;
            frmB.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmB);
            frmB.Show();           
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            mainPanel1.Controls.Clear();
            frmA.TopLevel = false;
            frmA.Dock = DockStyle.Fill;
            mainPanel1.Controls.Add(frmA);
            frmA.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult w = MessageBox.Show("آیا می خواهید از برنامه خارج شوید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (w == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Properties.Settings.Default.DisplayUserName;
        }

        private void خروخازحسابکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUserName.Text = "";
            frmL.ShowDialog();            
            lblUserName.Text = Properties.Settings.Default.DisplayUserName;            
        }
    }
}
