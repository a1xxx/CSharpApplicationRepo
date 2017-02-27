namespace groupProject
{
    partial class frmAddModifyProductsSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddModifyProductsSuppliers));
            this.txtProdSupId = new System.Windows.Forms.TextBox();
            this.lblPrDSId = new System.Windows.Forms.Label();
            this.lblProId = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboSupId = new System.Windows.Forms.ComboBox();
            this.cboProdId = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdSupId
            // 
            this.txtProdSupId.BackColor = System.Drawing.Color.Silver;
            this.txtProdSupId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSupId.Location = new System.Drawing.Point(322, 12);
            this.txtProdSupId.Name = "txtProdSupId";
            this.txtProdSupId.Size = new System.Drawing.Size(121, 26);
            this.txtProdSupId.TabIndex = 0;
            // 
            // lblPrDSId
            // 
            this.lblPrDSId.AutoSize = true;
            this.lblPrDSId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrDSId.ForeColor = System.Drawing.Color.Silver;
            this.lblPrDSId.Location = new System.Drawing.Point(118, 15);
            this.lblPrDSId.Name = "lblPrDSId";
            this.lblPrDSId.Size = new System.Drawing.Size(198, 19);
            this.lblPrDSId.TabIndex = 6;
            this.lblPrDSId.Text = "Products Supplier Id:";
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProId.ForeColor = System.Drawing.Color.Silver;
            this.lblProId.Location = new System.Drawing.Point(236, 47);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(72, 19);
            this.lblProId.TabIndex = 7;
            this.lblProId.Text = "Product";
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupID.ForeColor = System.Drawing.Color.Silver;
            this.lblSupID.Location = new System.Drawing.Point(236, 80);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(81, 19);
            this.lblSupID.TabIndex = 8;
            this.lblSupID.Text = "Supplier";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Silver;
            this.btnAccept.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(261, 165);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 26);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(355, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cboSupId
            // 
            this.cboSupId.BackColor = System.Drawing.Color.Silver;
            this.cboSupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupId.FormattingEnabled = true;
            this.cboSupId.Location = new System.Drawing.Point(322, 77);
            this.cboSupId.Name = "cboSupId";
            this.cboSupId.Size = new System.Drawing.Size(248, 27);
            this.cboSupId.TabIndex = 11;
            // 
            // cboProdId
            // 
            this.cboProdId.BackColor = System.Drawing.Color.Silver;
            this.cboProdId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProdId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdId.FormattingEnabled = true;
            this.cboProdId.Location = new System.Drawing.Point(322, 44);
            this.cboProdId.Name = "cboProdId";
            this.cboProdId.Size = new System.Drawing.Size(248, 27);
            this.cboProdId.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // frmAddModifyProductsSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(597, 207);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cboProdId);
            this.Controls.Add(this.cboSupId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblSupID);
            this.Controls.Add(this.lblProId);
            this.Controls.Add(this.lblPrDSId);
            this.Controls.Add(this.txtProdSupId);
            this.Name = "frmAddModifyProductsSuppliers";
            this.Text = "frmAddModifyProductsSupplierId";
            this.Load += new System.EventHandler(this.frmAddModifyProductsSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProdSupId;
        private System.Windows.Forms.Label lblPrDSId;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSupId;
        private System.Windows.Forms.ComboBox cboProdId;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}