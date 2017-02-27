namespace groupProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.comboProdId = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProdDelete = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.dTPkrPkgEnd = new System.Windows.Forms.DateTimePicker();
            this.dTPkrPkgStart = new System.Windows.Forms.DateTimePicker();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboPackageId = new System.Windows.Forms.ComboBox();
            this.btnSvPkg = new System.Windows.Forms.Button();
            this.txtBoxAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtBoxBasePrice = new System.Windows.Forms.TextBox();
            this.txtBoxPkgDesc = new System.Windows.Forms.TextBox();
            this.txtBoxPkgName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeletePS = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.cboProductsSupplierrId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProId = new System.Windows.Forms.Label();
            this.lblPrDSId = new System.Windows.Forms.Label();
            this.lblPrID = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.lblNewSupId = new System.Windows.Forms.Label();
            this.txtNewSupId = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSupQuit = new System.Windows.Forms.Button();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupId = new System.Windows.Forms.Label();
            this.comboSupId = new System.Windows.Forms.ComboBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.btnSupDelete = new System.Windows.Forms.Button();
            this.btnSupUpdate = new System.Windows.Forms.Button();
            this.btnSupAdd = new System.Windows.Forms.Button();
            this.dataGridViewSup = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstPackageInfo = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAddPackProdSup = new System.Windows.Forms.Button();
            this.dataGridPackProdSup = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPSPPS = new System.Windows.Forms.ComboBox();
            this.cboPkgPPS = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSup)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPackProdSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.DarkRed;
            this.tabProducts.Controls.Add(this.pictureBox1);
            this.tabProducts.Controls.Add(this.btnQuit);
            this.tabProducts.Controls.Add(this.lblProductName);
            this.tabProducts.Controls.Add(this.lblProductId);
            this.tabProducts.Controls.Add(this.comboProdId);
            this.tabProducts.Controls.Add(this.txtProductName);
            this.tabProducts.Controls.Add(this.txtProdDelete);
            this.tabProducts.Controls.Add(this.btnUpdateProd);
            this.tabProducts.Controls.Add(this.btnAddProd);
            this.tabProducts.Controls.Add(this.dataGridProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 28);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1301, 460);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Silver;
            this.btnQuit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(241, 173);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(121, 28);
            this.btnQuit.TabIndex = 20;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Silver;
            this.lblProductName.Location = new System.Drawing.Point(109, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(126, 19);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.Silver;
            this.lblProductId.Location = new System.Drawing.Point(127, 9);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(108, 19);
            this.lblProductId.TabIndex = 18;
            this.lblProductId.Text = "Product Id:";
            // 
            // comboProdId
            // 
            this.comboProdId.BackColor = System.Drawing.Color.Silver;
            this.comboProdId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProdId.ForeColor = System.Drawing.Color.Black;
            this.comboProdId.FormattingEnabled = true;
            this.comboProdId.Location = new System.Drawing.Point(241, 6);
            this.comboProdId.Name = "comboProdId";
            this.comboProdId.Size = new System.Drawing.Size(121, 27);
            this.comboProdId.TabIndex = 17;
            this.comboProdId.SelectedIndexChanged += new System.EventHandler(this.comboProdId_SelectedIndexChanged_1);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Silver;
            this.txtProductName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(241, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 26);
            this.txtProductName.TabIndex = 21;
            this.txtProductName.Tag = "Product Name";
            // 
            // txtProdDelete
            // 
            this.txtProdDelete.BackColor = System.Drawing.Color.Silver;
            this.txtProdDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDelete.ForeColor = System.Drawing.Color.Black;
            this.txtProdDelete.Location = new System.Drawing.Point(241, 139);
            this.txtProdDelete.Name = "txtProdDelete";
            this.txtProdDelete.Size = new System.Drawing.Size(121, 28);
            this.txtProdDelete.TabIndex = 15;
            this.txtProdDelete.Text = "Delete";
            this.txtProdDelete.UseVisualStyleBackColor = false;
            this.txtProdDelete.Click += new System.EventHandler(this.txtProdDelete_Click_1);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateProd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProd.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProd.Location = new System.Drawing.Point(241, 105);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(121, 28);
            this.btnUpdateProd.TabIndex = 14;
            this.btnUpdateProd.Text = "Update";
            this.btnUpdateProd.UseVisualStyleBackColor = false;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click_1);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Silver;
            this.btnAddProd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.Color.Black;
            this.btnAddProd.Location = new System.Drawing.Point(241, 71);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(121, 28);
            this.btnAddProd.TabIndex = 13;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click_1);
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridProduct.Location = new System.Drawing.Point(368, 6);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.Size = new System.Drawing.Size(842, 195);
            this.dataGridProduct.TabIndex = 12;
            // 
            // tabPackages
            // 
            this.tabPackages.BackColor = System.Drawing.Color.DarkRed;
            this.tabPackages.Controls.Add(this.pictureBox2);
            this.tabPackages.Controls.Add(this.lblDest);
            this.tabPackages.Controls.Add(this.dTPkrPkgEnd);
            this.tabPackages.Controls.Add(this.dTPkrPkgStart);
            this.tabPackages.Controls.Add(this.btnAddPkg);
            this.tabPackages.Controls.Add(this.dataGridView1);
            this.tabPackages.Controls.Add(this.cboPackageId);
            this.tabPackages.Controls.Add(this.btnSvPkg);
            this.tabPackages.Controls.Add(this.txtBoxAgencyCommission);
            this.tabPackages.Controls.Add(this.txtBoxBasePrice);
            this.tabPackages.Controls.Add(this.txtBoxPkgDesc);
            this.tabPackages.Controls.Add(this.txtBoxPkgName);
            this.tabPackages.Controls.Add(this.label8);
            this.tabPackages.Controls.Add(this.label7);
            this.tabPackages.Controls.Add(this.label6);
            this.tabPackages.Controls.Add(this.label5);
            this.tabPackages.Controls.Add(this.label4);
            this.tabPackages.Controls.Add(this.label3);
            this.tabPackages.Controls.Add(this.lbl);
            this.tabPackages.Location = new System.Drawing.Point(4, 28);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(1301, 460);
            this.tabPackages.TabIndex = 0;
            this.tabPackages.Text = "Packages";
            this.tabPackages.Click += new System.EventHandler(this.tabPackages_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.ForeColor = System.Drawing.Color.Silver;
            this.lblDest.Location = new System.Drawing.Point(355, 137);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(117, 19);
            this.lblDest.TabIndex = 30;
            this.lblDest.Text = "Destination:";
            // 
            // dTPkrPkgEnd
            // 
            this.dTPkrPkgEnd.Location = new System.Drawing.Point(478, 102);
            this.dTPkrPkgEnd.Name = "dTPkrPkgEnd";
            this.dTPkrPkgEnd.Size = new System.Drawing.Size(318, 26);
            this.dTPkrPkgEnd.TabIndex = 27;
            // 
            // dTPkrPkgStart
            // 
            this.dTPkrPkgStart.Location = new System.Drawing.Point(478, 70);
            this.dTPkrPkgStart.Name = "dTPkrPkgStart";
            this.dTPkrPkgStart.Size = new System.Drawing.Size(318, 26);
            this.dTPkrPkgStart.TabIndex = 26;
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.BackColor = System.Drawing.Color.Silver;
            this.btnAddPkg.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPkg.Location = new System.Drawing.Point(70, 101);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(236, 26);
            this.btnAddPkg.TabIndex = 21;
            this.btnAddPkg.Text = "Add new package";
            this.btnAddPkg.UseVisualStyleBackColor = false;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(6, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1226, 158);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cboPackageId
            // 
            this.cboPackageId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackageId.FormattingEnabled = true;
            this.cboPackageId.Location = new System.Drawing.Point(478, 6);
            this.cboPackageId.Name = "cboPackageId";
            this.cboPackageId.Size = new System.Drawing.Size(318, 27);
            this.cboPackageId.TabIndex = 18;
            this.cboPackageId.SelectedIndexChanged += new System.EventHandler(this.packageLoad);
            this.cboPackageId.SelectedValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // btnSvPkg
            // 
            this.btnSvPkg.BackColor = System.Drawing.Color.Silver;
            this.btnSvPkg.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSvPkg.Location = new System.Drawing.Point(70, 133);
            this.btnSvPkg.Name = "btnSvPkg";
            this.btnSvPkg.Size = new System.Drawing.Size(236, 26);
            this.btnSvPkg.TabIndex = 17;
            this.btnSvPkg.Text = "Save and Update Packages";
            this.btnSvPkg.UseVisualStyleBackColor = false;
            this.btnSvPkg.Click += new System.EventHandler(this.btnSvPkg_Click);
            // 
            // txtBoxAgencyCommission
            // 
            this.txtBoxAgencyCommission.BackColor = System.Drawing.Color.Silver;
            this.txtBoxAgencyCommission.Location = new System.Drawing.Point(478, 198);
            this.txtBoxAgencyCommission.Name = "txtBoxAgencyCommission";
            this.txtBoxAgencyCommission.Size = new System.Drawing.Size(318, 26);
            this.txtBoxAgencyCommission.TabIndex = 15;
            this.txtBoxAgencyCommission.Tag = "Agency Com";
            // 
            // txtBoxBasePrice
            // 
            this.txtBoxBasePrice.BackColor = System.Drawing.Color.Silver;
            this.txtBoxBasePrice.Location = new System.Drawing.Point(478, 166);
            this.txtBoxBasePrice.Name = "txtBoxBasePrice";
            this.txtBoxBasePrice.Size = new System.Drawing.Size(318, 26);
            this.txtBoxBasePrice.TabIndex = 14;
            this.txtBoxBasePrice.Tag = "Base Price";
            // 
            // txtBoxPkgDesc
            // 
            this.txtBoxPkgDesc.BackColor = System.Drawing.Color.Silver;
            this.txtBoxPkgDesc.Location = new System.Drawing.Point(478, 134);
            this.txtBoxPkgDesc.Name = "txtBoxPkgDesc";
            this.txtBoxPkgDesc.Size = new System.Drawing.Size(318, 26);
            this.txtBoxPkgDesc.TabIndex = 13;
            this.txtBoxPkgDesc.Tag = "Destination";
            // 
            // txtBoxPkgName
            // 
            this.txtBoxPkgName.BackColor = System.Drawing.Color.Silver;
            this.txtBoxPkgName.Location = new System.Drawing.Point(478, 38);
            this.txtBoxPkgName.Name = "txtBoxPkgName";
            this.txtBoxPkgName.Size = new System.Drawing.Size(318, 26);
            this.txtBoxPkgName.TabIndex = 10;
            this.txtBoxPkgName.Tag = "Package Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(363, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Base Price:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(382, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(364, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Agency Com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(364, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(346, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Package Name:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(373, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 19);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "PackageId:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPackages);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabSuppliers);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1309, 492);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "Product Name";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage1.Controls.Add(this.btnDeletePS);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lstOutput);
            this.tabPage1.Controls.Add(this.cboProductsSupplierrId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblProId);
            this.tabPage1.Controls.Add(this.lblPrDSId);
            this.tabPage1.Controls.Add(this.lblPrID);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1301, 460);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Products_Suppliers";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDeletePS
            // 
            this.btnDeletePS.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePS.Location = new System.Drawing.Point(316, 105);
            this.btnDeletePS.Name = "btnDeletePS";
            this.btnDeletePS.Size = new System.Drawing.Size(138, 27);
            this.btnDeletePS.TabIndex = 24;
            this.btnDeletePS.Text = "Delete";
            this.btnDeletePS.UseVisualStyleBackColor = false;
            this.btnDeletePS.Click += new System.EventHandler(this.btnDeletePS_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Silver;
            this.btnModify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(316, 39);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(138, 27);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(316, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.BackColor = System.Drawing.Color.Silver;
            this.lstOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 19;
            this.lstOutput.Location = new System.Drawing.Point(316, 134);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(314, 59);
            this.lstOutput.TabIndex = 15;
            // 
            // cboProductsSupplierrId
            // 
            this.cboProductsSupplierrId.BackColor = System.Drawing.Color.Silver;
            this.cboProductsSupplierrId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductsSupplierrId.FormattingEnabled = true;
            this.cboProductsSupplierrId.Location = new System.Drawing.Point(316, 6);
            this.cboProductsSupplierrId.Name = "cboProductsSupplierrId";
            this.cboProductsSupplierrId.Size = new System.Drawing.Size(138, 27);
            this.cboProductsSupplierrId.TabIndex = 14;
            this.cboProductsSupplierrId.SelectedIndexChanged += new System.EventHandler(this.cboProductsSupplierrId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(139, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supplier Name, Id:";
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProId.ForeColor = System.Drawing.Color.Silver;
            this.lblProId.Location = new System.Drawing.Point(139, 153);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(171, 19);
            this.lblProId.TabIndex = 12;
            this.lblProId.Text = "Products Name, Id:";
            // 
            // lblPrDSId
            // 
            this.lblPrDSId.AutoSize = true;
            this.lblPrDSId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrDSId.ForeColor = System.Drawing.Color.Silver;
            this.lblPrDSId.Location = new System.Drawing.Point(112, 134);
            this.lblPrDSId.Name = "lblPrDSId";
            this.lblPrDSId.Size = new System.Drawing.Size(198, 19);
            this.lblPrDSId.TabIndex = 11;
            this.lblPrDSId.Text = "Products Supplier Id:";
            // 
            // lblPrID
            // 
            this.lblPrID.AutoSize = true;
            this.lblPrID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrID.ForeColor = System.Drawing.Color.Silver;
            this.lblPrID.Location = new System.Drawing.Point(112, 9);
            this.lblPrID.Name = "lblPrID";
            this.lblPrID.Size = new System.Drawing.Size(198, 19);
            this.lblPrID.TabIndex = 10;
            this.lblPrID.Text = "Products Supplier Id:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BackColor = System.Drawing.Color.DarkRed;
            this.tabSuppliers.Controls.Add(this.lblNewSupId);
            this.tabSuppliers.Controls.Add(this.txtNewSupId);
            this.tabSuppliers.Controls.Add(this.pictureBox4);
            this.tabSuppliers.Controls.Add(this.btnSupQuit);
            this.tabSuppliers.Controls.Add(this.lblSupName);
            this.tabSuppliers.Controls.Add(this.lblSupId);
            this.tabSuppliers.Controls.Add(this.comboSupId);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.btnSupDelete);
            this.tabSuppliers.Controls.Add(this.btnSupUpdate);
            this.tabSuppliers.Controls.Add(this.btnSupAdd);
            this.tabSuppliers.Controls.Add(this.dataGridViewSup);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 28);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1301, 460);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            // 
            // lblNewSupId
            // 
            this.lblNewSupId.AutoSize = true;
            this.lblNewSupId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSupId.ForeColor = System.Drawing.Color.Silver;
            this.lblNewSupId.Location = new System.Drawing.Point(112, 42);
            this.lblNewSupId.Name = "lblNewSupId";
            this.lblNewSupId.Size = new System.Drawing.Size(153, 19);
            this.lblNewSupId.TabIndex = 33;
            this.lblNewSupId.Text = "New Supplier Id:";
            // 
            // txtNewSupId
            // 
            this.txtNewSupId.BackColor = System.Drawing.Color.Silver;
            this.txtNewSupId.Location = new System.Drawing.Point(272, 39);
            this.txtNewSupId.Name = "txtNewSupId";
            this.txtNewSupId.Size = new System.Drawing.Size(121, 26);
            this.txtNewSupId.TabIndex = 32;
            this.txtNewSupId.Tag = "Supplier Id";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 77);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // btnSupQuit
            // 
            this.btnSupQuit.BackColor = System.Drawing.Color.Silver;
            this.btnSupQuit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupQuit.Location = new System.Drawing.Point(272, 204);
            this.btnSupQuit.Name = "btnSupQuit";
            this.btnSupQuit.Size = new System.Drawing.Size(121, 28);
            this.btnSupQuit.TabIndex = 29;
            this.btnSupQuit.Text = "Quit";
            this.btnSupQuit.UseVisualStyleBackColor = false;
            this.btnSupQuit.Click += new System.EventHandler(this.btnSupQuit_Click);
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.ForeColor = System.Drawing.Color.Silver;
            this.lblSupName.Location = new System.Drawing.Point(131, 74);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(135, 19);
            this.lblSupName.TabIndex = 28;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // lblSupId
            // 
            this.lblSupId.AutoSize = true;
            this.lblSupId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupId.ForeColor = System.Drawing.Color.Silver;
            this.lblSupId.Location = new System.Drawing.Point(149, 9);
            this.lblSupId.Name = "lblSupId";
            this.lblSupId.Size = new System.Drawing.Size(117, 19);
            this.lblSupId.TabIndex = 27;
            this.lblSupId.Text = "Supplier Id:";
            // 
            // comboSupId
            // 
            this.comboSupId.BackColor = System.Drawing.Color.Silver;
            this.comboSupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSupId.FormattingEnabled = true;
            this.comboSupId.Location = new System.Drawing.Point(272, 6);
            this.comboSupId.Name = "comboSupId";
            this.comboSupId.Size = new System.Drawing.Size(121, 27);
            this.comboSupId.TabIndex = 26;
            this.comboSupId.SelectedIndexChanged += new System.EventHandler(this.comboSupId_SelectedIndexChanged);
            // 
            // txtSupName
            // 
            this.txtSupName.BackColor = System.Drawing.Color.Silver;
            this.txtSupName.Location = new System.Drawing.Point(272, 71);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(121, 26);
            this.txtSupName.TabIndex = 30;
            this.txtSupName.Tag = "Supplier Name";
            // 
            // btnSupDelete
            // 
            this.btnSupDelete.BackColor = System.Drawing.Color.Silver;
            this.btnSupDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupDelete.Location = new System.Drawing.Point(272, 170);
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.Size = new System.Drawing.Size(121, 28);
            this.btnSupDelete.TabIndex = 25;
            this.btnSupDelete.Text = "Delete";
            this.btnSupDelete.UseVisualStyleBackColor = false;
            this.btnSupDelete.Click += new System.EventHandler(this.btnSupDelete_Click);
            // 
            // btnSupUpdate
            // 
            this.btnSupUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnSupUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupUpdate.Location = new System.Drawing.Point(272, 136);
            this.btnSupUpdate.Name = "btnSupUpdate";
            this.btnSupUpdate.Size = new System.Drawing.Size(121, 28);
            this.btnSupUpdate.TabIndex = 24;
            this.btnSupUpdate.Text = "Update";
            this.btnSupUpdate.UseVisualStyleBackColor = false;
            this.btnSupUpdate.Click += new System.EventHandler(this.btnSupUpdate_Click);
            // 
            // btnSupAdd
            // 
            this.btnSupAdd.BackColor = System.Drawing.Color.Silver;
            this.btnSupAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupAdd.Location = new System.Drawing.Point(272, 102);
            this.btnSupAdd.Name = "btnSupAdd";
            this.btnSupAdd.Size = new System.Drawing.Size(121, 28);
            this.btnSupAdd.TabIndex = 23;
            this.btnSupAdd.Text = "Add";
            this.btnSupAdd.UseVisualStyleBackColor = false;
            this.btnSupAdd.Click += new System.EventHandler(this.btnSupAdd_Click);
            // 
            // dataGridViewSup
            // 
            this.dataGridViewSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSup.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSup.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewSup.Location = new System.Drawing.Point(399, 6);
            this.dataGridViewSup.Name = "dataGridViewSup";
            this.dataGridViewSup.Size = new System.Drawing.Size(744, 419);
            this.dataGridViewSup.TabIndex = 22;
            this.dataGridViewSup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSup_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkRed;
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.lstPackageInfo);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cboSupplierName);
            this.tabPage3.Controls.Add(this.cboProductName);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.btnAddPackProdSup);
            this.tabPage3.Controls.Add(this.dataGridPackProdSup);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cboPSPPS);
            this.tabPage3.Controls.Add(this.cboPkgPPS);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1301, 460);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Packages_Products_Suppliers";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstPackageInfo
            // 
            this.lstPackageInfo.BackColor = System.Drawing.Color.Silver;
            this.lstPackageInfo.FormattingEnabled = true;
            this.lstPackageInfo.ItemHeight = 19;
            this.lstPackageInfo.Location = new System.Drawing.Point(113, 327);
            this.lstPackageInfo.Name = "lstPackageInfo";
            this.lstPackageInfo.Size = new System.Drawing.Size(921, 80);
            this.lstPackageInfo.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(181, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(181, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Supplier Id:";
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.BackColor = System.Drawing.Color.Silver;
            this.cboSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(304, 72);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(121, 27);
            this.cboSupplierName.TabIndex = 25;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // cboProductName
            // 
            this.cboProductName.BackColor = System.Drawing.Color.Silver;
            this.cboProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(304, 39);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(121, 27);
            this.cboProductName.TabIndex = 24;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 77);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // btnAddPackProdSup
            // 
            this.btnAddPackProdSup.BackColor = System.Drawing.Color.Silver;
            this.btnAddPackProdSup.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackProdSup.ForeColor = System.Drawing.Color.Black;
            this.btnAddPackProdSup.Location = new System.Drawing.Point(112, 225);
            this.btnAddPackProdSup.Name = "btnAddPackProdSup";
            this.btnAddPackProdSup.Size = new System.Drawing.Size(276, 27);
            this.btnAddPackProdSup.TabIndex = 6;
            this.btnAddPackProdSup.Text = "Add";
            this.btnAddPackProdSup.UseVisualStyleBackColor = false;
            this.btnAddPackProdSup.Click += new System.EventHandler(this.btnAddPackProdSup_Click);
            // 
            // dataGridPackProdSup
            // 
            this.dataGridPackProdSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPackProdSup.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridPackProdSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPackProdSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPackProdSup.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridPackProdSup.Location = new System.Drawing.Point(431, 6);
            this.dataGridPackProdSup.Name = "dataGridPackProdSup";
            this.dataGridPackProdSup.Size = new System.Drawing.Size(603, 315);
            this.dataGridPackProdSup.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(109, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Product Supplier Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(190, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Package Id:";
            // 
            // cboPSPPS
            // 
            this.cboPSPPS.BackColor = System.Drawing.Color.Silver;
            this.cboPSPPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPSPPS.FormattingEnabled = true;
            this.cboPSPPS.Location = new System.Drawing.Point(304, 105);
            this.cboPSPPS.Name = "cboPSPPS";
            this.cboPSPPS.Size = new System.Drawing.Size(121, 27);
            this.cboPSPPS.TabIndex = 1;
            // 
            // cboPkgPPS
            // 
            this.cboPkgPPS.BackColor = System.Drawing.Color.Silver;
            this.cboPkgPPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPkgPPS.FormattingEnabled = true;
            this.cboPkgPPS.Location = new System.Drawing.Point(304, 6);
            this.cboPkgPPS.Name = "cboPkgPPS";
            this.cboPkgPPS.Size = new System.Drawing.Size(121, 27);
            this.cboPkgPPS.TabIndex = 0;
            this.cboPkgPPS.SelectedIndexChanged += new System.EventHandler(this.cboPkgPPS_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 635);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSup)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPackProdSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.Button btnSvPkg;
        private System.Windows.Forms.TextBox txtBoxAgencyCommission;
        private System.Windows.Forms.TextBox txtBoxBasePrice;
        private System.Windows.Forms.TextBox txtBoxPkgDesc;
        private System.Windows.Forms.TextBox txtBoxPkgName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboPackageId;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.DateTimePicker dTPkrPkgEnd;
        private System.Windows.Forms.DateTimePicker dTPkrPkgStart;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox comboProdId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button txtProdDelete;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button btnSupQuit;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupId;
        private System.Windows.Forms.ComboBox comboSupId;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Button btnSupDelete;
        private System.Windows.Forms.Button btnSupUpdate;
        private System.Windows.Forms.Button btnSupAdd;
        private System.Windows.Forms.DataGridView dataGridViewSup;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.ComboBox cboProductsSupplierrId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.Label lblPrDSId;
        private System.Windows.Forms.Label lblPrID;
        private System.Windows.Forms.ComboBox cboPSPPS;
        private System.Windows.Forms.ComboBox cboPkgPPS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridPackProdSup;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAddPackProdSup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboSupplierName;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstPackageInfo;
        private System.Windows.Forms.Label lblNewSupId;
        private System.Windows.Forms.TextBox txtNewSupId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeletePS;
    }
}

