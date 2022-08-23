using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using BusinessEntity;
using BLL;

namespace BicycleSalesManagement
{
    public partial class frmCustomers : Form
    {
        REZAEntities db = new REZAEntities();
        blClass blc = new blClass();
        int id;
        string personName;
        string addOrUpdate = "Add";
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCityName.Text != "" && txtStateCode.Text != "" && txtZipCode.Text != "")
            {
                btnAddCustomer.Enabled = true;
            }
            else
            {
                btnAddCustomer.Enabled = false;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            if(btnAddCustomer.Enabled == true)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    btnAddCustomer.PerformClick();
                }
            }
        }
        public void invisibleId()
        {
            foreach (DataGridViewColumn i in dgvCustomer.Columns)
            {
                switch (i.Name)
                {
                    case "Id":
                        {
                            i.Visible = false;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            dgvCustomer.DataSource = blc.fillDgvC();
            invisibleId();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (addOrUpdate == "Add")
            {
                Customer c = new Customer();
                c.FirstName = txtName.Text;
                c.LastName = txtLastName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;
                c.EmailAddress = txtEmail.Text;
                c.StreetName = txtAddress.Text;
                c.CityName = txtCityName.Text;
                c.StateCode = txtStateCode.Text;
                c.ZipCode = txtZipCode.Text;
                MessageBox.Show(blc.addCustomer(c)," 😃 تبریک ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = blc.fillDgvC();
                invisibleId();
                ClearTextBoxes(this.Controls);
                txtName.Focus();
            }
            else
            {
                Customer c = new Customer();
                c.FirstName = txtName.Text;
                c.LastName = txtLastName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;
                c.EmailAddress = txtEmail.Text;
                c.StreetName = txtAddress.Text;
                c.CityName = txtCityName.Text;
                c.StateCode = txtStateCode.Text;
                c.ZipCode = txtZipCode.Text;
                MessageBox.Show(blc.updateC(id, c), " 😃 تبریک  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = blc.fillDgvC();
                invisibleId();
                ClearTextBoxes(this.Controls);
                btnAddCustomer.Text = "افزودن مشتری";
                txtName.Focus();
                addOrUpdate = "Add";
            }
            
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if(txtPhoneNumber.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtZipCode.Text.Length >= 10 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtStateCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {            
            DialogResult w = MessageBox.Show("را حذف کنید؟ " + personName + " آیا مطمعنید که میخواهید", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (w == DialogResult.Yes)
            {
                MessageBox.Show(blc.deleteC(id), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = blc.fillDgvC();
                invisibleId();
                txtName.Focus();
            }
        }
        private void cmsEditItem_Click(object sender, EventArgs e)
        {
            addOrUpdate = "Update";
            Customer c = new Customer();
            if( id != 0 )
            {
                c = blc.readC(id);
                txtName.Text = c.FirstName;
                txtLastName.Text = c.LastName;
                txtPhoneNumber.Text = c.PhoneNumber;
                txtEmail.Text = c.EmailAddress;
                txtAddress.Text = c.StreetName;
                txtCityName.Text = c.CityName;
                txtStateCode.Text = c.StateCode;
                txtZipCode.Text = c.ZipCode;
                btnAddCustomer.Text = "ویرایش";
            }            
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = (int)dgvCustomer.SelectedRows[0].Cells[0].Value;
            //personName = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            //if (e.RowIndex > -1)
            //{
            //    id = (int)(dgvCustomer.SelectedRow[0].Cells[0].Value);
            //    personName = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            //}
        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = (int)(dgvCustomer.Rows[e.RowIndex].Cells[0].Value);
                personName = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = blc.searchC(txtSearch.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Report";
            printer.SubTitle = string.Format("Date: {0}",DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bicycle Sales Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvCustomer);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

    }
}
