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
using DGVPrinterHelper;

namespace BicycleSalesManagement
{
    public partial class frmOrders : Form
    {
        REZAEntities db = new REZAEntities();
        blClass blc = new blClass();
        int id;
        string productName;
        string addOrUpdate = "Add";
        public frmOrders()
        {
            InitializeComponent();
        }

        private void txtOrderDate_OnValueChanged(object sender, EventArgs e)
        {
            if (txtDiscountPercent.Text != "" && txtItemCount.Text != "" && txtPrice.Text != ""  && cmbCustomerName.SelectedIndex != -1 && cmbProductName.SelectedIndex != -1 )
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void cmbStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDiscountPercent.Text != "" && txtItemCount.Text != "" && txtPrice.Text != ""  && cmbCustomerName.SelectedIndex != -1 && cmbProductName.SelectedIndex != -1 )
            {
                btnAddOrder.Enabled = true;
            }
            else
            {
                btnAddOrder.Enabled = false;
            }
        }

        private void txtOrderDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (txtItemCount.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cmbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            cmbCustomerName.Focus();
            cmbCustomerName.ValueMember = "Id";
            cmbCustomerName.DisplayMember = "C_and_S";
            cmbCustomerName.DataSource = blc.fillCmbCustomer();

            cmbProductName.ValueMember = "Id";
            cmbProductName.DisplayMember = "Title";
            cmbProductName.DataSource = blc.fillCmbP();

            dgvOrders.DataSource = blc.fillDgvO();
            dontShowId();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (addOrUpdate == "Add")
            {
                OrderItem oi = new OrderItem();
                oi.ListPrice =Convert.ToDecimal( txtPrice.Text);
                oi.ItemCount = Convert.ToInt16(txtItemCount.Text);
                oi.DiscountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
                oi.ProductId = (int)cmbProductName.SelectedValue;
                oi.OrderId = (int)cmbCustomerName.SelectedValue;
                MessageBox.Show(blc.addOrder(oi), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvOrders.DataSource = null;
                dgvOrders.DataSource = blc.fillDgvO();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtItemCount.Focus();
            }
            else
            {
                OrderItem oi = new OrderItem();
                oi.ListPrice = Convert.ToDecimal(txtPrice.Text);
                oi.ItemCount = Convert.ToInt16(txtItemCount.Text);
                oi.DiscountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
                oi.ProductId = (int)cmbProductName.SelectedValue;
                oi.OrderId = (int)cmbCustomerName.SelectedValue;
                MessageBox.Show(blc.updateOi(id, oi), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvOrders.DataSource = null;
                dgvOrders.DataSource = blc.fillDgvO();
                dontShowId();
                ClearTextBoxes(this.Controls);
                btnAddOrder.Text = "افزودن محصول";
                txtItemCount.Focus();
                addOrUpdate = "Add";
            }
        }
        public void dontShowId()
        {
            foreach (DataGridViewColumn i in dgvOrders.Columns)
            {
                switch (i.Name)
                {
                    case "Id":
                        {
                            i.Visible = false;
                            break;
                        }
                    case "OrderDate":
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
            DialogResult w = MessageBox.Show("را حذف کنید؟ " + productName + " آیا مطمعنید که میخواهید", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == w)
            {
                MessageBox.Show(blc.deleteO(id), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvOrders.DataSource = null;
                dgvOrders.DataSource = blc.fillDgvO();
                dontShowId();
                txtItemCount.Focus();
            }
        }                  
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = (int)(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
                productName = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void cmsEditItemTool_Click(object sender, EventArgs e)
        {
            addOrUpdate = "Update";
            OrderItem oi = new OrderItem();
            if (id != 0)
            {
                oi = blc.readOi(id);
                txtDiscountPercent.Text = oi.DiscountPercent.ToString();
                txtPrice.Text =  oi.ListPrice.ToString();
                txtItemCount.Text = oi.ItemCount.ToString();
                cmbCustomerName.SelectedValue = oi.OrderId;
                cmbProductName.SelectedValue = oi.ProductId;
                btnAddOrder.Text = "ویرایش";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOrders.DataSource = blc.searchOi(txtSearch.Text);
            dontShowId();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Orders Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bicycle Sales Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvOrders);
        }

        private void txtDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (txtDiscountPercent.Text.Length >= 6 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (txtPrice.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
