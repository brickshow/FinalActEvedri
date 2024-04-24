namespace LogInForm
{
    partial class InventoryManagement
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
            this.pnlDisplayInvemtory = new System.Windows.Forms.Panel();
            this.dataGridViewProductInv = new System.Windows.Forms.DataGridView();
            this.clmBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDisplayInvemtory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDisplayInvemtory
            // 
            this.pnlDisplayInvemtory.BackColor = System.Drawing.Color.Black;
            this.pnlDisplayInvemtory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayInvemtory.Controls.Add(this.dataGridViewProductInv);
            this.pnlDisplayInvemtory.Location = new System.Drawing.Point(3, 3);
            this.pnlDisplayInvemtory.Name = "pnlDisplayInvemtory";
            this.pnlDisplayInvemtory.Size = new System.Drawing.Size(978, 657);
            this.pnlDisplayInvemtory.TabIndex = 4;
            // 
            // dataGridViewProductInv
            // 
            this.dataGridViewProductInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBrandName,
            this.clmSerialNum,
            this.clmQuantity,
            this.clmStatus,
            this.clmCategory});
            this.dataGridViewProductInv.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewProductInv.Name = "dataGridViewProductInv";
            this.dataGridViewProductInv.Size = new System.Drawing.Size(961, 640);
            this.dataGridViewProductInv.TabIndex = 0;
            // 
            // clmBrandName
            // 
            this.clmBrandName.HeaderText = "Brand Name";
            this.clmBrandName.Name = "clmBrandName";
            // 
            // clmSerialNum
            // 
            this.clmSerialNum.HeaderText = "Serial Number";
            this.clmSerialNum.Name = "clmSerialNum";
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Category";
            this.clmCategory.Name = "clmCategory";
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(985, 664);
            this.Controls.Add(this.pnlDisplayInvemtory);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.pnlDisplayInvemtory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayInvemtory;
        private System.Windows.Forms.DataGridView dataGridViewProductInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategory;
    }
}