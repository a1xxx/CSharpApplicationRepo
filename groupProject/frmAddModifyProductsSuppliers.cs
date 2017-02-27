using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupProject
{
    public partial class frmAddModifyProductsSuppliers : Form
    {
        public frmAddModifyProductsSuppliers()
        {
            InitializeComponent();
        }
        public bool addProductsSuppler;
        public ProductsSuppliers productsupplier;

        private void frmAddModifyProductsSuppliers_Load(object sender, EventArgs e)
        {
            //this.LoadComboBox() - need database lauout to see how they are connected
            if (addProductsSuppler)
            {
                txtProdSupId.Visible = false;
                lblPrDSId.Visible = false;
                this.Text = "Add Products Supplier";
                this.DisplayComboBoxes();

            }
            else
            {
                txtProdSupId.Visible = true;
                txtProdSupId.Enabled = false;
                lblPrDSId.Visible = true;
                this.Text = "Modify Products Supplier";
                this.DisplayComboBoxes();
                txtProdSupId.Text = productsupplier.ProductSupplierId.ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(cboProdId)
            && Validator.IsPresent(cboSupId))
            {
                if (addProductsSuppler)
                {
                    productsupplier = new ProductsSuppliers();
                    this.PutProductSupplierData(productsupplier);
                    try
                    {
                        productsupplier.ProductSupplierId = ProductSupplierIdDB.AddProductSupplier(productsupplier);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

                else
                {
                    ProductsSuppliers newProductSupplier = new ProductsSuppliers();
                    newProductSupplier.ProductSupplierId = productsupplier.ProductSupplierId;
                    this.PutProductSupplierData(newProductSupplier);

                    try
                    {
                        if (!ProductSupplierIdDB.UpdateProductSupplier(productsupplier, newProductSupplier))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that Product Supplier.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            productsupplier = newProductSupplier;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }

                }
            }
        }
        private void PutProductSupplierData(ProductsSuppliers productsupplier)
        {
            productsupplier.ProductId = (int)cboProdId.SelectedValue;
            productsupplier.SupplierId =(int)cboSupId.SelectedValue;
        }
        private void DisplayComboBoxes()
        {
            List<ProductsSuppliers> prodid= new List<ProductsSuppliers>();
            List<ProductsSuppliers> supid = new List<ProductsSuppliers>();
            try
            {
                prodid = ProductSupplierIdDB.GetUniqueProSupId("p");
                supid = ProductSupplierIdDB.GetUniqueProSupId("s");

                cboProdId.DataSource = prodid;
                cboProdId.DisplayMember = "ProdName";
                cboProdId.ValueMember = "ProductId";
                cboSupId.DataSource = supid;
                cboSupId.DisplayMember = "SupName";
                cboSupId.ValueMember = "SupplierId";
                if (!addProductsSuppler)
                {
                    cboProdId.SelectedValue = productsupplier.ProductId;
                    cboSupId.SelectedValue = productsupplier.SupplierId;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
