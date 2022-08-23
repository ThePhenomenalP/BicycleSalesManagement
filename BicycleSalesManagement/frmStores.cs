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
using DGVPrinterHelper;

namespace BicycleSalesManagement
{
    public partial class frmStores : Form
    {
        REZAEntities db = new REZAEntities();
        blClass blc = new blClass();
        int id;
        string storeName;
        string addOrUpdate = "Add";
        public frmStores()
        {
            InitializeComponent();
        }

        private void txtZipCode_OnValueChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtPhoneNumber.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCityName.Text != "" && txtStateCode.Text != "" && txtZipCode.Text != "")
            {
                btnAddStore.Enabled = true;
            }
            else
            {
                btnAddStore.Enabled = false;
            }
        }

        private void txtZipCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtPhoneNumber.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtCityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public void dontShowId()
        {
            foreach (DataGridViewColumn i in dgvStore.Columns)
            {
                switch (i.Name)
                {
                    case "Id":
                        {
                            i.Visible = false;
                            break;
                        }
                    case "Orders":
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
        private void frmStores_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            dgvStore.DataSource = blc.fillDgvS();
            dontShowId();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult w = MessageBox.Show("را حذف کنید؟ " + storeName + " آیا مطمعنید که میخواهید فروشگاه", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (w == DialogResult.Yes)
                {
                    MessageBox.Show(blc.deleteS(id), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvStore.DataSource = null;
                    dgvStore.DataSource = blc.fillDgvS();
                    dontShowId();
                    txtTitle.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            if (addOrUpdate == "Add")
            {
                Store s = new Store();
                s.Title = txtTitle.Text;
                s.PhoneNumber = txtPhoneNumber.Text;
                s.EmailAddress = txtEmail.Text;
                s.StreetName = txtAddress.Text;
                s.CityName = txtCityName.Text;
                s.StateCode = txtStateCode.Text;
                s.ZipCode = txtZipCode.Text;
                MessageBox.Show(blc.addStore(s), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStore.DataSource = null;
                dgvStore.DataSource = blc.fillDgvS();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtTitle.Focus();
            }
            else
            {
                Store s = new Store();
                s.Title = txtTitle.Text;
                s.PhoneNumber = txtPhoneNumber.Text;
                s.EmailAddress = txtEmail.Text;
                s.StreetName = txtAddress.Text;
                s.CityName = txtCityName.Text;
                s.StateCode = txtStateCode.Text;
                s.ZipCode = txtZipCode.Text;
                MessageBox.Show(blc.updateS(id, s), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStore.DataSource = null;
                dgvStore.DataSource = blc.fillDgvS();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtTitle.Focus();
                btnAddStore.Text = "افزودن فروشگاه";
                addOrUpdate = "Add";
            }
        }

        private void cmsEditItem_Click(object sender, EventArgs e)
        {
            addOrUpdate = "Update";
            Store s = new Store();
            if(id != 0)
            {
                s = blc.readS(id);
                txtTitle.Text = s.Title;
                txtPhoneNumber.Text = s.PhoneNumber;
                txtEmail.Text = s.EmailAddress;
                txtAddress.Text = s.StreetName;
                txtCityName.Text = s.CityName;
                txtStateCode.Text = s.StateCode;
                txtZipCode.Text = s.ZipCode;
                btnAddStore.Text = "ویرایش";
            }            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Stores Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bicycle Sales Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvStore);
        }
        private void dgvStore_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = (int)(dgvStore.Rows[e.RowIndex].Cells[0].Value);
                storeName = dgvStore.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStore.DataSource = blc.searchS(txtSearch.Text);
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
    }
}
