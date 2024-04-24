using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class EmployeeDetails : Form
    {
        Register register;
        public List<clsEmpInfo> updatedList = new List<clsEmpInfo>();

        public EmployeeDetails(Register reg)
        {
            InitializeComponent();
            register = reg;
            dgvDetails.ForeColor = Color.Black;          
            txtRemove.Hide();
            lblRemoveText.Hide();
            txtUpdate.Hide();       
            lblLabelText.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showAddEmployee();
            register.refresh();
        }

        //Get data to list employee
        public void getDatafromRegisterForm<T>(List<T> datasource)
        {
            dgvDetails.DataSource = datasource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblRemoveText.Show();
            txtRemove.Show();
            txtRemove.Focus();
            txtUpdate.Hide() ;
            lblLabelText.Show();
            lblLabelText.Text = "Delete";
        }

        //Show indicator
        private void txtRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if Enter key is pressed
            {
                if (int.TryParse(txtRemove.Text, out int removedID)) // Try to parse the text to integer
                {
                    if (string.IsNullOrWhiteSpace(txtRemove.Text))
                    {
                        lblRemoveText.ForeColor = Color.Red;
                    }
                    else
                    {
                        // Check if the removedID exists in the datasource
                        var employeeToRemove = (from emp in register.listEmployeeData
                                                where emp.EmployeeID == removedID
                                                select emp).FirstOrDefault();

                        if (employeeToRemove == null)
                        {
                            MessageBox.Show("Employee with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register.listEmployeeData.Count == 0)
                        {
                            MessageBox.Show("Employee list is empty.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            var filteredID = (from ID in register.listEmployeeData
                                              where ID.EmployeeID != removedID
                                              select ID).ToList();

                            DialogResult remove = MessageBox.Show("Are you sure you want to remove this employee?", "Continue?", MessageBoxButtons.OKCancel
                                , MessageBoxIcon.Question);
                            if (remove == DialogResult.OK)
                            {
                                register.listEmployeeData = filteredID.ToList();
                                dgvDetails.DataSource = register.listEmployeeData;
                                txtRemove.Clear();
                            }
                        } 
                    }
                }
                else
                {
                   lblRemoveText.ForeColor= Color.Red;
                }
            }
        }

        //Change the font color
        private void txtRemove_TextChanged(object sender, EventArgs e)
        {
            lblRemoveText.ForeColor = Color.White;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblRemoveText.Show();
            txtRemove.Hide();
            txtUpdate.Focus();
            txtUpdate.Show();
            lblLabelText.Show();
            lblLabelText.Text = "Update";
        }

        private void txtUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if Enter key is pressed
            {
                if (int.TryParse(txtUpdate.Text, out int removedID)) // Try to parse the text to integer
                {
                    if (string.IsNullOrWhiteSpace(txtUpdate.Text))
                    {
                        lblRemoveText.ForeColor = Color.Red;
                    }
                    else
                    {
                        // Check if the removedID exists in the datasource
                        var employeeToRemove = (from emp in register.listEmployeeData
                                                where emp.EmployeeID == removedID
                                                select emp).FirstOrDefault();

                        if (employeeToRemove == null)
                        {
                            MessageBox.Show("Employee with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register.listEmployeeData.Count == 0)
                        {
                            MessageBox.Show("Employee list is empty.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            var filteredID = (from ID in register.listEmployeeData
                                              where ID.EmployeeID == removedID
                                              select ID).ToList();

                            updatedList = filteredID;
                            register.updateTheData(updatedList[0]);
                        }
                    }
                }
                else
                {
                    lblRemoveText.ForeColor = Color.Red;
                }
            }
        }
    }
}
