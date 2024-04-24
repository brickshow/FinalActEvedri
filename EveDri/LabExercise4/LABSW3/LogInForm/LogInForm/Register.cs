using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Register : Form
    {
        
        public List<clsEmpInfo> listEmployeeData = new List<clsEmpInfo>();

        LogIn logIn;

        //Call out the Details form
        EmployeeDetails employeeDetails; 
        public Register()
        {
            InitializeComponent();
            employeeDetails = new EmployeeDetails(this);
            logIn = new LogIn();
        }

        //Temporary list
        List<string> namelist = new List<string>();
        List<clsEmpInfo> search = new List<clsEmpInfo>();


        //ID num
        int idnum = 12345;
        //Add data
        public void addData()
        {
            // Retrieve user input from text boxes
            string firstName = txtFirstName.Text;
            string middleName = txtMidInitial.Text;
            string lastName = txtLastName.Text;
            string birthDate = dtpBirthdate.Value.ToString("MMMM dd, yyyy");
            string nationality = txtNationality.Text;
            string gender = txtGender.Text;
            int age = tempAge;
            int employeeID = idnum;
            string username = txtUsername.Text;
            string pass = txtPass.Text;
            string Contact = txtContactNumber.Text;
            string add = txtAddress.Text;

            //Display the user choices
            string civilStat = "";
            string status = "";
            string role = _roles;

            if (rbtnMarried.Checked) civilStat = rbtnMarried.Text;
            else if (rbtnSeparated.Checked) civilStat = rbtnSeparated.Text;
            else if (rbtnSingle.Checked) civilStat = rbtnSingle.Text;
            else if (rbtnWidowed.Checked) civilStat = rbtnWidowed.Text;

            //Display staus

            if (rbtnActive.Checked) status = rbtnActive.Text;
            else if (rbtnInactive.Checked) status = rbtnInactive.Text;

            //Display role
            if (rbtnStaff.Checked) role = rbtnStaff.Text;
            else if (rbtnHr.Checked) role = rbtnHr.Text;


            //Validate Textbox
            if (txtFirstName.Text == "" || txtLastName.Text == "" 
                || txtBirthdate.Text =="" || txtNationality.Text == "" 
                || txtGender.Text ==" " || txtContactNumber.Text == ""
                || txtAddress.Text == "" || txtUsername.Text == ""
                || txtPass.Text == "" || rbtnMarried.Checked == false && rbtnSeparated.Checked ==false
                && rbtnSingle.Checked == false && rbtnWidowed.Checked == false
                || rbtnStaff.Checked == false && rbtnHr.Checked == false
                || rbtnActive.Checked == false && rbtnInactive.Checked == false)
            {
                MessageBox.Show("Please complete your information", "Warning",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                idnum++;
                listEmployeeData.Add(new clsEmpInfo
                {
                    Firstname = firstName,
                    Middlename = middleName,
                    Lastname = lastName,
                    BirthDate = birthDate,
                    Nationality = nationality,
                    Gender = gender,
                    ContactNumber = Contact,
                    Address = add,
                    Username = username,
                    Password = pass,
                    CivilStatus = civilStat,
                    Role = role,
                    Status = status,
                    EmployeeID = employeeID
                }) ;
                ClearTextBoxes(this);
            }

            //Filter the Names
            namelist = (from person in listEmployeeData 
                        where person.Firstname != null && person.Middlename != null && person.Lastname != null 
                        select person.Firstname + " " + person.Middlename + " " + person.Lastname).ToList();

            listBoxNames.DataSource = namelist;


            //var ID = listEmployeeData.Select(empID => empID.EmployeeID);

            var ID = (from person in listEmployeeData
                      select person.EmployeeID).ToList();

            listBoxID.DataSource = ID.ToList();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        //Next Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            addData();
        }

        //Clear the textbox
        private void ClearTextBoxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl.HasChildren)
                {
                    ClearTextBoxes(ctrl); // Recursively clear textboxes in child controls
                }
            }

            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is RadioButton)
                {
                    ((RadioButton)ctrl).Checked = false;
                }
            }
        }


        int tempAge;
        //Display the date
        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime currDate = DateTime.Now;
            var selectedDate = dtpBirthdate.Value;
            txtBirthdate.Text = dtpBirthdate.Value.ToString("MMMM dd, yyyy");
        

            if (dtpBirthdate.Value > DateTime.Today)
            {
                lblBdate.Text = "Date must be less than the current date";
                lblBdate.ForeColor = Color.Red;
            }
            else
            {
               tempAge = (DateTime.Now.Year - dtpBirthdate.Value.Year);
                
                if (currDate.Month < selectedDate.Month || (currDate.Month == selectedDate.Month
                    && currDate.Day < selectedDate.Day))
                {
                    tempAge--;
                }
                lblBdate.Text = "Brithdate*";
                lblBdate.ForeColor = Color.White;
                txtAge.Text = tempAge.ToString();
            }
        }
        string _roles;
        private void rbtnStaff_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnHr.Checked == true)
            {
                _roles = rbtnHr.Text;
            }
            else if (rbtnStaff.Checked == true)
            {
                _roles = rbtnStaff.Text;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((TextBox)sender == txtContactNumber)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.') e.Handled = true;
            }

            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter)
            {
                 Control actCtr = ActiveControl;
                if ((TextBox)sender != txtGender)
                {
                    SelectNextControl(actCtr, true, true, true, true);
                }
                else
                {
                    MessageBox.Show("Please complete your information", "Warning", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            
        }

        public void searchEmp()
        {
            //Note finished yet
            search = (from emp in listEmployeeData
                          where emp.Firstname.ToLower().Contains(txtSearch.Text.ToLower()) ||
                          emp.Lastname.ToLower().Contains(txtSearch.Text.ToLower())
                          select emp).ToList();

            if (txtSearch.Text == "")
            {
                listBoxNames.DataSource = namelist;
            }
            else
            {

                listBoxNames.DataSource = null;
                listBoxNames.DataSource = search.Select(emp => emp.Firstname + " " + emp.Middlename + " " + emp.Lastname).ToList();


                var searchID = search.Select(emp => emp.EmployeeID).ToList();
                listBoxID.DataSource = null;
                listBoxID.DataSource = searchID;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEmp();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchEmp();
        }
        //Display the details of all employees
        private void btnViewAllEmp_Click(object sender, EventArgs e)
        {
            pnlReg.Show();
            pnlDisplayEmployee.Hide();
            pnlAddEmployee.Hide();
            employeeDetails.TopLevel = false;
            pnlReg.Controls.Add(employeeDetails);
            employeeDetails.Dock = DockStyle.Fill;
            employeeDetails.Show();
            PassListDataToEmployeeDetails();
        }

        public void showAddEmployee()
        {
            pnlReg.Hide();
            pnlDisplayEmployee.Show();
            pnlAddEmployee.Show();
        }
        //Passing data
        private void PassListDataToEmployeeDetails()
        {
            employeeDetails.getDatafromRegisterForm(listEmployeeData);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //refresh the data
        public void refresh()
        {
            listBoxNames.DataSource = (from person in listEmployeeData
                                       where person.Firstname != null && person.Middlename != null && person.Lastname != null
                                       select person.Firstname + " " + person.Middlename + " " + person.Lastname).ToList();

            listBoxID.DataSource = (from person in listEmployeeData
                                    select person.EmployeeID).ToList();
        }

        //U[adte the data
        public void updateTheData(clsEmpInfo staffInfo)
        {
            pnlReg.Hide();
            pnlDisplayEmployee.Show();
            pnlAddEmployee.Show();
            btnRegister.Text = "UPDATE";
            if (employeeDetails.updatedList.Count > 0 && employeeDetails.updatedList.Contains(staffInfo))
            {
                // Assuming these textboxes are where you want to display staff information
                txtFirstName.Text = staffInfo.Firstname;
                txtMidInitial.Text = staffInfo.Middlename;
                txtLastName.Text = staffInfo.Lastname;
                dtpBirthdate.Value = DateTime.ParseExact(staffInfo.BirthDate, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
                txtNationality.Text = staffInfo.Nationality;
                txtGender.Text = staffInfo.Gender;
                txtContactNumber.Text = staffInfo.ContactNumber.ToString();
                txtAddress.Text = staffInfo.Address;
                txtUsername.Text = staffInfo.Username;
                txtPass.Text = staffInfo.Password;
            }
            else
            {
                MessageBox.Show("Unable to update employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //jsdfhidf
        }
    }
}

