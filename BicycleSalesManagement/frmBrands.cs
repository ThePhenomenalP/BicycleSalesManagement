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
    public partial class frmBrands : Form
    {
        REZAEntities db = new REZAEntities();
        blClass blc = new blClass();
        int id;
        string brandName;
        string addOrUpdate = "Add";
        public frmBrands()
        {
            InitializeComponent();
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            if(txtTitle.Text != "")
            {
                btnAddBrand.Enabled = true;
            }
            else
            {
                btnAddBrand.Enabled = false;
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public void dontShowId()
        {
            foreach (DataGridViewColumn i in dgvBrand.Columns)
            {
                switch (i.Name)
                {
                    case "Id":
                        {
                            i.Visible = false;
                            break;
                        }
                    case "Products":
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
        private void frmBrands_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            dgvBrand.DataSource = blc.fillDgvB();
            dontShowId();
        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = (int)(dgvBrand.Rows[e.RowIndex].Cells[0].Value);
                brandName = dgvBrand.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            if (addOrUpdate == "Add")
            {
                Brand b = new Brand();
                b.Title = txtTitle.Text;             
                MessageBox.Show(blc.addBrand(b), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBrand.DataSource = null;
                dgvBrand.DataSource = blc.fillDgvB();
                dontShowId();
                ClearTextBoxes(this.Controls);
                txtTitle.Focus();
            }
            else
            {
                Brand b = new Brand();
                b.Title = txtTitle.Text;
                MessageBox.Show(blc.updateB(id, b), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBrand.DataSource = null;
                dgvBrand.DataSource = blc.fillDgvB();
                dontShowId();
                ClearTextBoxes(this.Controls);
                btnAddBrand.Text = "افزودن برند";
                addOrUpdate = "Add";
                txtTitle.Focus();
            }
        }

        private void cmsEditItem_Click(object sender, EventArgs e)
        {
            addOrUpdate = "Update";
            Brand b = new Brand();
            if (id != 0)
            {
                b = blc.readB(id);
                txtTitle.Text = b.Title;
                btnAddBrand.Text = "ویرایش";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult w = MessageBox.Show("را حذف کنید؟ " + brandName + " آیا مطمعنید که میخواهید برند", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == w)
                {
                    MessageBox.Show(blc.deleteB(id), " 😃 تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBrand.DataSource = null;
                    dgvBrand.DataSource = blc.fillDgvB();
                    dontShowId();
                    txtTitle.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvBrand.DataSource = blc.searchB(txtSearch.Text);
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Brand Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Bicycle Sales Management";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvBrand);
        }
    }
}
