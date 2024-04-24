namespace LogInForm
{
    partial class ProductManagement
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
            this.pnlDisplayProduct = new System.Windows.Forms.Panel();
            this.lblProductList = new System.Windows.Forms.Label();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.gboxProductList = new System.Windows.Forms.GroupBox();
            this.pnlDisplayProduct.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayProduct
            // 
            this.pnlDisplayProduct.BackColor = System.Drawing.Color.Black;
            this.pnlDisplayProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayProduct.Controls.Add(this.gboxProductList);
            this.pnlDisplayProduct.Controls.Add(this.lblProductList);
            this.pnlDisplayProduct.Location = new System.Drawing.Point(290, 7);
            this.pnlDisplayProduct.Name = "pnlDisplayProduct";
            this.pnlDisplayProduct.Size = new System.Drawing.Size(689, 651);
            this.pnlDisplayProduct.TabIndex = 5;
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.BackColor = System.Drawing.Color.Transparent;
            this.lblProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.ForeColor = System.Drawing.Color.White;
            this.lblProductList.Location = new System.Drawing.Point(12, 10);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(222, 34);
            this.lblProductList.TabIndex = 13;
            this.lblProductList.Text = "PRODUCT LIST";
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddEmployee.Controls.Add(this.cboxCategory);
            this.pnlAddEmployee.Controls.Add(this.txtQuantity);
            this.pnlAddEmployee.Controls.Add(this.btnRegister);
            this.pnlAddEmployee.Controls.Add(this.txtPrice);
            this.pnlAddEmployee.Controls.Add(this.txtSerialNum);
            this.pnlAddEmployee.Controls.Add(this.txtBrandName);
            this.pnlAddEmployee.Controls.Add(this.lblAddProduct);
            this.pnlAddEmployee.Location = new System.Drawing.Point(6, 7);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(278, 651);
            this.pnlAddEmployee.TabIndex = 6;
            // 
            // cboxCategory
            // 
            this.cboxCategory.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategory.ForeColor = System.Drawing.Color.Gray;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Items.AddRange(new object[] {
            "Monitor",
            "Keyboard",
            "Mouse",
            "System Unit",
            "Avr",
            "Ram",
            "GPU",
            "SSD",
            "HDD"});
            this.cboxCategory.Location = new System.Drawing.Point(17, 275);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(235, 29);
            this.cboxCategory.TabIndex = 14;
            this.cboxCategory.Text = "Category";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantity.Location = new System.Drawing.Point(136, 224);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(117, 29);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "Quantity";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(44, 580);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(181, 35);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "ADD PRODUCT";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtPrice.Location = new System.Drawing.Point(18, 224);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(113, 29);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "Price";
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNum.ForeColor = System.Drawing.Color.Gray;
            this.txtSerialNum.Location = new System.Drawing.Point(17, 170);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(236, 29);
            this.txtSerialNum.TabIndex = 2;
            this.txtSerialNum.Text = "Serial Number";
            // 
            // txtBrandName
            // 
            this.txtBrandName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrandName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.ForeColor = System.Drawing.Color.Gray;
            this.txtBrandName.Location = new System.Drawing.Point(18, 115);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(235, 29);
            this.txtBrandName.TabIndex = 0;
            this.txtBrandName.Text = "Brand Name";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddProduct.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.ForeColor = System.Drawing.Color.White;
            this.lblAddProduct.Location = new System.Drawing.Point(23, 10);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(220, 34);
            this.lblAddProduct.TabIndex = 1;
            this.lblAddProduct.Text = "ADD PRODUCT";
            // 
            // gboxProductList
            // 
            this.gboxProductList.BackColor = System.Drawing.Color.Black;
            this.gboxProductList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxProductList.ForeColor = System.Drawing.Color.White;
            this.gboxProductList.Location = new System.Drawing.Point(12, 52);
            this.gboxProductList.Name = "gboxProductList";
            this.gboxProductList.Size = new System.Drawing.Size(661, 582);
            this.gboxProductList.TabIndex = 15;
            this.gboxProductList.TabStop = false;
            this.gboxProductList.Text = "Product";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(985, 664);
            this.Controls.Add(this.pnlDisplayProduct);
            this.Controls.Add(this.pnlAddEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.pnlDisplayProduct.ResumeLayout(false);
            this.pnlDisplayProduct.PerformLayout();
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayProduct;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSerialNum;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.GroupBox gboxProductList;
    }
}