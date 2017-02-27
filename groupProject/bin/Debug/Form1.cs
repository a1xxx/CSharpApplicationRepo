using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

// * Organization of form 1 completed by: Justin
// * Color and design completed by: Justin

namespace groupProject
{

    public partial class Form1 : Form
    {
        //*******************************************************************
        //*                                                                 *
        //*                             SHARED                              *
        //*                                                                 *
        //*******************************************************************

        // ***********
        // * STEP 0A *
        // ***********

        // Mikes list of packages
        private List<package> packages = null;
        private List<package> packages2 = null;
        // Jutins list of products
        private List<Product> products = null;
        Product product = new Product();
        Product prodold = new Product();

        // Alexs list of Products Suppliers
        public ProductsSuppliers productsupplier;
        ProductsSuppliers SelectedPS = new ProductsSuppliers();

        // Ayi list of suppliers
        private List<Supplier> suppliers = null;
        Supplier supplier = new Supplier();
        Supplier supold = new Supplier();

        // ***********
        // * STEP 0B *
        // ***********

        public Form1()
        {
            // Shared by all group members
            InitializeComponent();
            tabselection();       
        }

        // ***********
        // * STEP 0C *
        // ***********

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Mike
            tabselection();

            // Justin
            List<Product> products = ProductDB.GetProducts();
            comboProdId.DataSource = products;
            comboProdId.DisplayMember = "ProductId";

            // Ayi
            List<Supplier> suppliers = SupplierDB.GetSuppliers();
            comboSupId.DataSource = suppliers;
            comboSupId.DisplayMember = "SupplierId";
        }




        private void ClearControls()
        {
            // Justins Products
            comboProdId.Text = "";
            txtProductName.Text = "";
            comboProdId.Select();

            // Ayis Suppliers
            comboSupId.Text = "";
            txtSupName.Text = "";
            comboSupId.Select();
        }



        //*******************************************************************
        //*                                                                 *
        //*                             MIKE                                *
        //*                                                                 *
        //*******************************************************************



        // STEP 1
        private void tabselection()
        {
            if (tabControl.SelectedIndex == 0)
            {
                if (cboPackageId.SelectedValue == null)
                { GetPackages();
                    int ID1 = Convert.ToInt32(cboPackageId.SelectedValue);

                    load_table();
                }
            }

            if (tabControl.SelectedIndex == 2)
            {
                this.GetProductsSuppliers();
            }
            if (tabControl.SelectedIndex == 4)
            {
                
                cboProductName.DataSource = ProductDB.GetProducts();
                cboProductName.DisplayMember = "ProdName";
                cboProductName.ValueMember = "ProductId";


                dataGridPackProdSup.DataSource = Packages_Products_SuppliersDB.GetPackages_Products_Supplierss();
                
            }
            if (tabControl.SelectedIndex == 5)
            {
               
               GetPackages();
            }
        }      



        // STEP 2
        public void GetPackages()
        {
            try
            {
                packages = PackagesDB.GetPackages();
                cboPackageId.DataSource = packages;
                cboPackageId.DisplayMember = "PackageId";
                cboPackageId.ValueMember = "PackageId";
                packages2 = PackagesDB.GetPackages();
                cboPkgPPS.DataSource = packages2;
                cboPkgPPS.DisplayMember = "PackageId";
                cboPkgPPS.ValueMember = "PackageId";
                List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
                productssupplierid = ProductSupplierIdDB.GetProductsSupplierId();
                cboPSPPS.DataSource = productssupplierid;
                cboPSPPS.DisplayMember = "ProductSupplierId";
                cboPSPPS.ValueMember = "ProductSupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // STEP 3
     
       



        // STEP 4
        public void GetPackage(int PackageId)
        {
            try
            {
                package pkg  = PackagesDB.GetPackage(PackageId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }



        // STEP 5
        public void load_table()
        {
            try
            {
                List<package> packageS = new List<package>();
                packageS = PackagesDB.GetPackages();
                
                    var source = new BindingSource(packages, null);

                    dataGridView1.DataSource = source;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // STEP 6
        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            package pkg = new package();
            if (Validator.IsPresent(txtBoxPkgName) && Validator.IsPresent(txtBoxPkgDesc) &&
                 Validator.IsPresent(txtBoxBasePrice) && Validator.IsPresent(txtBoxAgencyCommission)&&
                 //Validator.IsDecimal(txtBoxBasePrice)&& Validator.IsDecimal(txtBoxAgencyCommission)&&
                 Validator.CompareValues(txtBoxAgencyCommission, txtBoxBasePrice)&& Validator.CompareDates(dTPkrPkgStart.Value, dTPkrPkgEnd.Value));
            {
                int add;
                pkg.PkgName = txtBoxPkgName.Text.ToString();
                pkg.PkgStartDate = Convert.ToString(dTPkrPkgStart.Value);
                pkg.PkgEndDate = Convert.ToString(dTPkrPkgEnd.Value);
                pkg.PkgDesc = txtBoxPkgDesc.Text.ToString();
                pkg.PkgBasePrice = txtBoxBasePrice.Text;
                pkg.PkgAgencyCommission = txtBoxAgencyCommission.Text;
               

                add = PackagesDB.AddPackage(pkg);

                List<package> packageS = new List<package>();
                packageS = PackagesDB.GetPackages();               

                dataGridView1.DataSource = packageS;

                MessageBox.Show("Package was added!");
            }
        }



        // STEP 7
        private void btnSvPkg_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtBoxPkgName) && Validator.IsPresent(txtBoxPkgDesc) &&
                 Validator.IsPresent(txtBoxBasePrice) && Validator.IsPresent(txtBoxAgencyCommission) &&
                // Validator.IsDecimal(txtBoxBasePrice) && Validator.IsDecimal(txtBoxAgencyCommission) &&
                 Validator.CompareValues(txtBoxAgencyCommission, txtBoxBasePrice) && Validator.CompareDates(dTPkrPkgStart.Value, dTPkrPkgEnd.Value))
            {
                int oldId = Convert.ToInt32(cboPackageId.SelectedValue.ToString());

                package oldpkg = PackagesDB.GetPackage(oldId);
                package newpkg = new package();

                bool update;

                int newID = Convert.ToInt32(cboPackageId.SelectedValue.ToString());
                newpkg.PackageId = newID;

                string name = txtBoxPkgName.Text.ToString();
                newpkg.PkgName = name;

                DateTime start = Convert.ToDateTime(dTPkrPkgStart.Value.ToString());
                newpkg.PkgStartDate = Convert.ToString(start);

                DateTime end = Convert.ToDateTime(dTPkrPkgEnd.Value.ToString());
                newpkg.PkgEndDate = Convert.ToString(end);

                string desc = txtBoxPkgDesc.Text.ToString();
                newpkg.PkgDesc = desc;

                decimal basePrice = decimal.Parse(txtBoxBasePrice.Text.ToString(), NumberStyles.Currency);                 
                newpkg.PkgBasePrice = Convert.ToString(basePrice);

                decimal commission = decimal.Parse(txtBoxAgencyCommission.Text.ToString(), NumberStyles.Currency);
                newpkg.PkgAgencyCommission = Convert.ToString(commission);




                update = PackagesDB.UpdatePackage(oldpkg, newpkg);
                this.GetPackage(newID);
                this.tabselection();
                List<package> packageS = new List<package>();
                packageS = PackagesDB.GetPackages();

                

                dataGridView1.DataSource = packageS;

                MessageBox.Show("Package was updated!");
            }
        }



        //*******************************************************************
        //*                                                                 *
        //*                             JUSTIN                              *
        //*                                                                 *
        //*******************************************************************



        // STEP 1
        private void DisplayProduct()
        {
            comboProdId.Text = product.ProductId.ToString();
            txtProductName.Text = product.ProdName.ToString();
        }



        // STEP 2
        public void GetProduct(int productId)
        {
            Product products = ProductDB.GetProduct(productId);
        }



        // STEP 3
        public void GetProducts()
        {
            try
            {
                products = ProductDB.GetProducts();
                comboProdId.DataSource = products;
                comboProdId.DisplayMember = "ProductId";
                comboProdId.ValueMember = "ProductId";
            }
            //catch any database exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // STEP 4
        // ******************************************
        // * ADD BUTTON                             *
        // ******************************************
        private void btnAddProd_Click_1(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName))
            {
                Product prod = new Product();

                prod.ProdName = txtProductName.Text.ToString();

                ProductDB.AddProduct(prod);
                MessageBox.Show(prod.ProdName.ToString() + " has been successfully added to the database.");

                products = ProductDB.GetProducts();
                comboProdId.DataSource = products;
                comboProdId.DisplayMember = "ProductId";
                comboProdId.ValueMember = "ProductId";
                // comboProdId.SelectedValue = prod.ProdName;
                MessageBox.Show("Product was added!");
            }

        }



        // STEP 5
        // ******************************************
        // * UPDATE BUTTON                          *
        // ******************************************
        private void btnUpdateProd_Click_1(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtProductName))
            {
                Product prodnew = new Product();
                //dataGridProduct

                prodnew.ProdName = txtProductName.Text.ToString();

                ProductDB.UpdateProduct(prodold, prodnew);

                MessageBox.Show(prodold.ProdName.ToString() + " has been successfully updated in the database.");

                products = ProductDB.GetProducts();
                comboProdId.DataSource = products;
                comboProdId.DisplayMember = "ProductId";
                comboProdId.ValueMember = "ProductId";
            }
        }



        // STEP 6
        // ******************************************
        // * DELETE BUTTON                          *
        // ******************************************
        private void txtProdDelete_Click_1(object sender, EventArgs e)
        {
            Product prod = new Product();

            prod.ProdName = txtProductName.Text.ToString();
            

            ProductDB.DeleteProduct(prod);
            //MessageBox.Show(prod.ProdName.ToString() + " has been successfully deleted from the database.");
            products = ProductDB.GetProducts();
            comboProdId.DataSource = products;
            comboProdId.DisplayMember = "ProductId";
            comboProdId.ValueMember = "ProductId";
        }



        // STEP 7
        // ******************************************
        // * PRODUCT ID COMBO BOX                   *
        // ******************************************
        private void comboProdId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            List<Product> prods = new List<Product>();
            Product prod = (Product)comboProdId.SelectedItem;
            prods.Add(prod);
            dataGridProduct.DataSource = prods;

            List<Product> products = ProductDB.GetProducts();

            txtProductName.Text = products[Convert.ToInt32(comboProdId.SelectedIndex)].ProdName;

            prodold.ProdName = txtProductName.Text.ToString();
           

        }



        // STEP 8
        // ******************************************
        // * GET PRODUCT BUTTON                     *
        // ******************************************
        private void btnGetProd_Click(object sender, EventArgs e)
        {
            List<Product> products = ProductDB.GetProducts();

            txtProductName.Text = products[Convert.ToInt32(comboProdId.SelectedIndex)].ProdName;
        }



        // STEP 9
        // ******************************************
        // * QUIT BUTTON                            *
        // ******************************************
        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }



        //*******************************************************************
        //*                                                                 *
        //*                             ALEX                                *
        //*                                                                 *
        //*******************************************************************

        
        
        // STEP 1
        public void GetProductsSuppliers()
        {
            List<ProductsSuppliers> productssupplierid = new List<ProductsSuppliers>();
            try
            {
                productssupplierid = ProductSupplierIdDB.GetProductsSupplierId();
                cboProductsSupplierrId.DataSource = productssupplierid;
                cboProductsSupplierrId.DisplayMember = "ProductSupplierId";
                cboProductsSupplierrId.ValueMember = "ProductSupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // STEP 2
        private void DisplayPS(ProductsSuppliers displayPs)
        {
            if (displayPs.ProductSupplierId != 0)
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add(displayPs.ProductSupplierId);
                lstOutput.Items.Add(displayPs.ProdName+"," + "\t" + "\t" + displayPs.ProductId);
                lstOutput.Items.Add(displayPs.SupName+"," + "\t"+displayPs.SupplierId);
            }
        }



        //*******************************************************************
        //*                                                                 *
        //*                             AYI                                 *
        //*                                                                 *
        //*******************************************************************



        // STEP 1
        private void DisplaySupplier()
        {
            comboSupId.Text = supplier.SupplierId.ToString();
            txtSupName.Text = supplier.SupName.ToString();
        }



        // STEP 2
        public void GetSupplier(int supplierId)
        {
            Supplier suppliers = SupplierDB.GetSupplier(supplierId);
        }



        // STEP 3
        public void GetSuppliers()
        {
            try
            {
                //fill list with database suppliers and populate combobox with the value
                suppliers = SupplierDB.GetSuppliers();
                comboSupId.DataSource = suppliers;
                comboSupId.DisplayMember = "SupName";
                comboSupId.ValueMember = "SupplierId";
            }
            //catch any database exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // STEP 4
        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            if (Validator.IsPresent(txtNewSupId) && Validator.IsInteger(txtNewSupId)&& Validator.IsPresent(txtSupName))
            {
                sup.SupplierId = Convert.ToInt32(txtNewSupId.Text);
                sup.SupName = txtSupName.Text.ToString();

                SupplierDB.AddSupplier(sup);
                MessageBox.Show(sup.SupName.ToString() + " has been successfully added to the database.");
                List<Supplier> suppliers = SupplierDB.GetSuppliers();
                comboSupId.DataSource = suppliers;
                comboSupId.DisplayMember = "SupplierId";

            }
            else
            {
                
            }
        }



        // STEP 5
        private void btnSupUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupName))
            {

                Supplier supnew = new Supplier();

                supold = (Supplier)comboSupId.SelectedItem;
                supnew.SupName = txtSupName.Text.ToString();

                SupplierDB.UpdateSupplier(supold, supnew);

                MessageBox.Show(supold.SupName.ToString() + " has been successfully updated in the database.");
                List<Supplier> suppliers = SupplierDB.GetSuppliers();
                comboSupId.DataSource = suppliers;
                comboSupId.DisplayMember = "SupplierId";
            }
        }



        // STEP 6
        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();

            
            sup =(Supplier)comboSupId.SelectedValue;


            SupplierDB.DeleteSupplier(sup);
            //MessageBox.Show(sup.SupName.ToString() + " has been successfully deleted from the database.");
            List<Supplier> suppliers = SupplierDB.GetSuppliers();
            comboSupId.DataSource = suppliers;
            comboSupId.DisplayMember = "SupplierId";
        }



        // STEP 7
        private void comboSupId_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Supplier> sups = new List<Supplier>();
            sups = SupplierDB.GetSuppliers();
            Supplier sup = (Supplier)comboSupId.SelectedItem;
            //sups.Add(sup);
            dataGridViewSup.DataSource = sups;

            List<Supplier> suppliers = SupplierDB.GetSuppliers();

            txtSupName.Text = suppliers[Convert.ToInt32(comboSupId.SelectedIndex)].SupName;
          
            supold.SupName = txtSupName.Text.ToString();

        }



        // STEP 8
        private void btnSupQuit_Click(object sender, EventArgs e)
        {
            Close();
        }



        //*******************************************************************
        //*                                                                 *
        //*                     JUSTIN ALEX MIKE AYI                        *
        //*                                                                 *
        //*******************************************************************

        
        // STEP 1
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProductsSuppliers addProductSupplierForm = new frmAddModifyProductsSuppliers();
            addProductSupplierForm.addProductsSuppler = true;
            DialogResult result = addProductSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                productsupplier = addProductSupplierForm.productsupplier;
                this.GetProductsSuppliers();
                cboProductsSupplierrId.SelectedValue = productsupplier.ProductSupplierId;
                MessageBox.Show("New Products Suppliers were added");

            }
        }



        // STEP 2
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyProductsSuppliers modifyProductSupplierForm = new frmAddModifyProductsSuppliers();
            productsupplier = SelectedPS;
            modifyProductSupplierForm.addProductsSuppler = false;
            modifyProductSupplierForm.productsupplier = productsupplier;
            DialogResult result = modifyProductSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.GetProductsSuppliers();
                cboProductsSupplierrId.SelectedValue = productsupplier.ProductSupplierId;
            }
            else if (result == DialogResult.Retry)
            {
                this.GetProductsSuppliers();
                cboProductsSupplierrId.SelectedValue = productsupplier.ProductSupplierId;
            }
            MessageBox.Show("Products Suppliers was updated");
        }



        // STEP 3
        private void cboProductsSupplierrId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pid = 0;
            try
            {
                pid = Convert.ToInt32(cboProductsSupplierrId.SelectedValue);
            }
            catch { }
            SelectedPS = ProductSupplierIdDB.GetSelected(pid);
            this.DisplayPS(SelectedPS);
        }



        // STEP 4
        private void btnAddPackProdSup_Click(object sender, EventArgs e)
        {
            int pkgID = Convert.ToInt32(cboPkgPPS.SelectedValue);
            int pkgPS = Convert.ToInt32(cboPSPPS.SelectedValue);
            Packages_Products_SuppliersDB.AddProductSupplier(pkgID, pkgPS);
            dataGridPackProdSup.DataSource = Packages_Products_SuppliersDB.GetPackages_Products_Supplierss();
            MessageBox.Show("You have added new Product to the Package!");

        }



        // Accidental Clicks
        private void label1_Click(object sender, EventArgs e)
        {
            // EMPTY
        }
        private void tabProducts_Click(object sender, EventArgs e)
        {
            // EMPTY
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // EMPTY
        }

        private void cboPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // EMPTY
        }

        private void packageLoad(object sender, EventArgs e)
        {
            int ID = (cboPackageId.SelectedIndex);
            ID = ID + 1;
            package pkg3 = PackagesDB.GetPackage(ID);

            txtBoxPkgName.Text = pkg3.PkgName;
            dTPkrPkgStart.Value = Convert.ToDateTime(pkg3.PkgStartDate);
            dTPkrPkgEnd.Value = Convert.ToDateTime(pkg3.PkgEndDate);
            txtBoxPkgDesc.Text = pkg3.PkgDesc;
            txtBoxBasePrice.Text = pkg3.PkgBasePrice;
            txtBoxAgencyCommission.Text = pkg3.PkgAgencyCommission;
         

           // int PackageId = Convert.ToInt32(cboPackageId.SelectedValue.ToString());
            this.GetPackage(ID);
            this.load_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Alex
        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedprodid = Convert.ToInt32(cboProductName.SelectedIndex);
            selectedprodid = selectedprodid + 1;
            cboSupplierName.DataSource = ProductSupplierIdDB.GetSupplierName(selectedprodid);
            cboSupplierName.DisplayMember = "SupName";
            cboSupplierName.ValueMember = "SupplierId";
            int? selectedsupplier = (int?)cboSupplierName.SelectedValue;
            if (selectedsupplier != null)
            {
                cboPSPPS.DataSource = ProductSupplierIdDB.GetProductSupplierId2Inputs(selectedprodid, selectedsupplier);
            }
            else MessageBox.Show("This selection does not have existing suplliers, add a supplier first");


            //cboPSPPS.DataSource=ProductSupplierIdDB.Get

        }

        private void cboProductName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //Alex
        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplierName.SelectedIndex != 0)
            {
                int selectedprodid = Convert.ToInt32(cboProductName.SelectedIndex);
                selectedprodid = selectedprodid + 1;

                int sup = (int)cboSupplierName.SelectedValue;
                //int selectedsupplier = sup.SupplierId;
                cboPSPPS.DataSource = ProductSupplierIdDB.GetProductSupplierId2Inputs(selectedprodid, sup);
                cboPSPPS.ValueMember = "ProductSupplierId";
                cboPSPPS.DisplayMember = "ProductSupplierId";
            }
        }

        private void cboPkgPPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPkgPPS.SelectedIndex != 0)
            {
                int pacnum = (int)cboPkgPPS.SelectedValue;
                package coco = new package();
                coco = PackagesDB.GetPackage(pacnum);
                lstPackageInfo.Items.Clear();
                lstPackageInfo.Items.Add(coco.PackageId + " " + coco.PkgName + " " + coco.PkgDesc + " " + coco.PkgBasePrice + " " + coco.PkgAgencyCommission);
            }
            else
            {
                package coco = new package();
                coco = PackagesDB.GetPackage(1);
                lstPackageInfo.Items.Clear();
                lstPackageInfo.Items.Add(coco.PackageId + " " + coco.PkgName + " " + coco.PkgDesc + " " + coco.PkgBasePrice + " " + coco.PkgAgencyCommission);
            }
        }

        private void dataGridViewSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPackages_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductsSuppliers pps = new ProductsSuppliers();
            package psup = new package();
            psup.PackageId = ((package)cboPkgPPS.SelectedItem).PackageId; 
            pps.ProductSupplierId = ((ProductsSuppliers)cboPSPPS.SelectedItem).ProductSupplierId;


            bool logic= Packages_Products_SuppliersDB.Delete(psup, pps);            
            dataGridPackProdSup.DataSource = Packages_Products_SuppliersDB.GetPackages_Products_Supplierss();
            
            if (logic == true)
            {
                MessageBox.Show("You have Deleted Product from the package Package!");
            }
            else
            {
                MessageBox.Show("The selected product does not exists in the selected package");
                dataGridPackProdSup.Rows[3].Selected = true;
            }
        }

        private void btnDeletePS_Click(object sender, EventArgs e)
        {
            int ps;
            ps = ((int)cboProductsSupplierrId.SelectedValue);          

            bool logic = ProductSupplierIdDB.Delete(ps);
            this.GetProductsSuppliers();


            if (logic == true)
            {
                MessageBox.Show("You have Deleted Products Suplliers combination!");
            }
            else
            {                
                MessageBox.Show("Delete product from pachages first!");
            }
        }

        private void btnDeletePack_Click(object sender, EventArgs e)
        {
            int ps;
            ps = ((int)cboPackageId.SelectedValue);

            bool logic = PackagesDB.Delete(ps);
            List<package> packageS = new List<package>();
            packageS = PackagesDB.GetPackages();

            dataGridView1.DataSource = packageS;
            cboPackageId.SelectedIndex = 0;

            if (logic == true)
            {
                MessageBox.Show("You have Deleted the Package !");
            }
            else
            {
                MessageBox.Show("Delete Package from Products Packages table first!");
            }
        }
    }
}
