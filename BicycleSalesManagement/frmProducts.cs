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
    public partial class frmProducts : Form
    {
        REZAEntities db = new REZAEntities();
        blClass blc = new blClass();
        int id;
        string productName;
        string addOrUpdate = "Add";
        public frmProducts()
        {
            InitializeComponent();
        }

        private void txtModel_OnValueChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtPrice.Text != "" && txtModel.Text != "" && cmbBrand.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
            {
                btnAddProduct.Enabled = true;
            }
            else
            {
                btnAddProduct.Enabled = false;
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtPrice.Text != "" && txtModel.Text != "" && cmbBrand.SelectedIndex != -1 && cmbCategory.SelectedIndex != -1)
            {
                btnAddProduct.Enabled = true;
            }
            else
            {
                btnAddProduct.Enabled = false;
            }
        }
        private void txtPrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtPrice.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModel.Focus();
            }
        }

        private void txtModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBrand.Focus();
            }
        }

        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCategory.Focus();
            }
        }

        private void cmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSearch.Focus();
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {            
            txtTitle.Focus();                      
            cmbBrand.ValueMember = "Id";
            cmbBrand.DisplayMember = "Title";
            cmbBrand.DataSource = blc.fillCmbB();
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Title";
            cmbCategory.DataSource = blc.fillCmbC();
            dgvProducts.DataSource = blc.fillDgvP();
            dontShowId();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = (int)(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
                productName = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        public void dontShowId()
        {
            foreach (DataGridViewColumn i in dgvProducts.Columns)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult w = MessageBox.Show("را حذف کنید؟ " + productName + " آیا مطمعنید که میخواهید", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == w)
                {
                    MessageBox.Show(blc.deleteP(id), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = blc.fillDgvP();
                    dontShowId();
                    txtTitle.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }                        
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (addOrUpdate == "Add")
            {
                Product p = new Product();
                p.Title = txtTitle.Text;
                p.ModelYear =Convert.ToInt16( txtModel.Text);
                p.ListPrice =Convert.ToDecimal( txtPrice.Text);
                p.BrandId = (int)cmbBrand.SelectedValue;
                p.CategoryId = (int)cmbCategory.SelectedValue;
                MessageBox.Show(blc.addProduct(p), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = blc.fillDgvP();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtTitle.Focus();
            }
            else
            {
                Product p = new Product();
                p.Title = txtTitle.Text;
                p.ModelYear = Convert.ToInt16(txtModel.Text);
                p.ListPrice = Convert.ToDecimal(txtPrice.Text);
                p.BrandId = (int)cmbBrand.SelectedValue;
                p.CategoryId = (int)cmbCategory.SelectedValue;
                MessageBox.Show(blc.updateP(id, p), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = blc.fillDgvP();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtTitle.Focus();
                btnAddProduct.Text = "افزودن محصول";
                addOrUpdate = "Add";
            }
        }

        private void cmsEditToolItem_Click(object sender, EventArgs e)
        {
            addOrUpdate = "Update";
            Product p = new Product();
            if (id != 0)
            {
                p = blc.readP(id);
                txtTitle.Text = p.Title;
                txtModel.Text = p.ModelYear.ToString();
                txtPrice.Text = p.ListPrice.ToString();
                cmbBrand.SelectedValue = p.BrandId;
                cmbCategory.SelectedValue = p.CategoryId;               
                btnAddProduct.Text = "ویرایش";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = blc.searchP(txtSearch.Text);
            dontShowId();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Products Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bicycle Sales Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvProducts);
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtModel.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
