namespace LogInForm
{
    partial class EmployeeDetails
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
            this.pnlShowDetails = new System.Windows.Forms.Panel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.lblRemoveText = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.lblLabelText = new System.Windows.Forms.Label();
            this.pnlShowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShowDetails
            // 
            this.pnlShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShowDetails.Controls.Add(this.dgvDetails);
            this.pnlShowDetails.Location = new System.Drawing.Point(12, 44);
            this.pnlShowDetails.Name = "pnlShowDetails";
            this.pnlShowDetails.Size = new System.Drawing.Size(826, 600);
            this.pnlShowDetails.TabIndex = 0;
            // 
            // dgvDetails
            // 
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.GridColor = System.Drawing.Color.Black;
            this.dgvDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(816, 590);
            this.dgvDetails.TabIndex = 0;
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeDetails.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeDetails.Location = new System.Drawing.Point(12, 7);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(289, 34);
            this.lblEmployeeDetails.TabIndex = 14;
            this.lblEmployeeDetails.Text = "EMPLOYEE DETAILS";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(742, 712);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(12, 712);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 34);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(349, 711);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemove.Location = new System.Drawing.Point(323, 667);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(221, 29);
            this.txtRemove.TabIndex = 19;
            this.txtRemove.TextChanged += new System.EventHandler(this.txtRemove_TextChanged);
            this.txtRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemove_KeyPress);
            // 
            // lblRemoveText
            // 
            this.lblRemoveText.AutoSize = true;
            this.lblRemoveText.ForeColor = System.Drawing.Color.White;
            this.lblRemoveText.Location = new System.Drawing.Point(320, 651);
            this.lblRemoveText.Name = "lblRemoveText";
            this.lblRemoveText.Size = new System.Drawing.Size(224, 13);
            this.lblRemoveText.TabIndex = 20;
            this.lblRemoveText.Text = "Please type the ID number and click [ENTER]";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtUpdate.Location = new System.Drawing.Point(323, 667);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(221, 29);
            this.txtUpdate.TabIndex = 21;
            this.txtUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdate_KeyPress);
            // 
            // lblLabelText
            // 
            this.lblLabelText.AutoSize = true;
            this.lblLabelText.ForeColor = System.Drawing.Color.White;
            this.lblLabelText.Location = new System.Drawing.Point(321, 698);
            this.lblLabelText.Name = "lblLabelText";
            this.lblLabelText.Size = new System.Drawing.Size(50, 13);
            this.lblLabelText.TabIndex = 20;
            this.lblLabelText.Text = "labelText";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 763);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.lblLabelText);
            this.Controls.Add(this.lblRemoveText);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEmployeeDetails);
            this.Controls.Add(this.pnlShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDetails";
            this.Text = "]";
            this.pnlShowDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label lblEmployeeDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label lblRemoveText;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label lblLabelText;
    }
}