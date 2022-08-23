using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;

namespace BicycleSalesManagement
{
    public partial class frmMain : Form
    {
        frmCustomers frmC = new frmCustomers();
        frmOrders frmO = new frmOrders();
        frmStores frmS = new frmStores();
        frmBrands frmB = new frmBrands();
        frmProducts frmP = new frmProducts();
        frmAbout frmA = new frmAbout();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmC.TopLevel = false;
            frmC.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmC);
            frmC.Show();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmS.TopLevel = false;
            frmS.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmS);
            frmS.Show();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmB.TopLevel = false;
            frmB.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmB);
            frmB.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmP.TopLevel = false;
            frmP.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmP);
            frmP.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmA.TopLevel = false;
            frmA.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmA);
            frmA.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            frmO.TopLevel = false;
            frmO.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frmO);
            frmO.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult w = MessageBox.Show("آیا می خواهید از برنامه خارج شوید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (w == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmLogin frmL = new frmLogin();
            //lblUserName.Text = ((TextBox)frmL.Controls["textBox1"]).Text;
            lblUserName.Text = Properties.Settings.Default.DisplayUserName;
        }
    }
}
