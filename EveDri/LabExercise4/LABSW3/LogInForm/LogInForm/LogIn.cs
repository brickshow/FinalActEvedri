using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class LogIn : Form
    {
        clsUserAdmin _logIn;//Class for login information
        List<clsUserAdmin> logInValidation = new List<clsUserAdmin>();//List to store login Info
        public LogIn()
        {
            
            InitializeComponent();

            //Error Indicator
            lblIndicator.Hide();
            lblEmptyPass.Hide();
            lblEmptyUser.Hide();

            logInValidation.Add(new clsUserAdmin { User = "Administrator", UserID = 1,
                AdminUsername = "admin", AdminPassword = "admin1234", Role = "Administrator" });//Initializing a class object

            //Leave and Enter event in just two event handler
            EventHandler textBoxEnterHandler = (sender, e) => {
                if (sender is TextBox textBox)
                {
                    if (textBox.Text == textBox.Tag.ToString())
                    {
                        textBox.Clear();
                        textBox.ForeColor = SystemColors.ControlText;
                        if (textBox == txtboxUsername)
                        {
                            lblEmptyUser.Hide();
                            lblEmptyPass.Hide();
                            lblIndicator.Hide();
                        }
                    }
                }
            };

            EventHandler textBoxLeaveHandler = (sender, e) => {
                if (sender is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = textBox.Tag.ToString();
                        textBox.ForeColor = SystemColors.GrayText;
                        if (textBox == txtboxUsername)
                        {
                            lblEmptyUser.Show();
                        }
                    }
                }
            };

            txtboxUsername.Enter += textBoxEnterHandler;
            txtboxUsername.Leave += textBoxLeaveHandler;
            txtboxPassword.Enter += textBoxEnterHandler;
            txtboxPassword.Leave += textBoxLeaveHandler;

            // Set tag values for each TextBox
            txtboxUsername.Tag = "Username";
            txtboxPassword.Tag = "Password";

            //Lambda expression for show and hide password
            pboxPassworShow.MouseDown += (sender, e) =>
            {
                txtboxPassword.PasswordChar = '\0';
                pboxHidePassword.BringToFront();
            };
            pboxPassworShow.MouseUp += (sender, e) =>
            {
                pboxPassworShow.BringToFront();
                txtboxPassword.PasswordChar = '•';
            };

            this.KeyPreview = true;//Enable the key preview for the form
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Execute the enter events
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control actCtr = ActiveControl;
                if ((TextBox)sender != txtboxPassword)
                {
                    SelectNextControl(actCtr, true, true, true, true);
                }
                else logIn();
            }
        }

        //Log In method
        public void logIn()
        {
            bool correctinfo = (from Admin in logInValidation
                                where txtboxUsername.Text == Admin.AdminUsername 
                                && txtboxPassword.Text == Admin.AdminPassword select Admin).Any();//Log in ussing LINQ
            if (correctinfo)
            {
                Homepage homepage = new Homepage(this);//Call Out the homepage
                txtboxUsername.Focus();
                homepage.Show();
                this.Hide();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Do the log in Using button
            logIn();
        }

        private void LogIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the user used escape keys
            if (e.KeyChar == (char)Keys.Escape)
            {
                //Show a confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                //Check if the user confirm using OK button
                if (result == DialogResult.OK) this.Close(); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hide the indicator while the user is typing
        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {
            lblIndicator.Hide();
            lblEmptyPass.Hide();
            lblEmptyUser.Hide();
        }

        //Method to show this form
        public void thisShow()
        {
            txtboxUsername.ResetText(); txtboxUsername.ForeColor = Color.Gray;
            txtboxPassword.Text = "Password"; txtboxPassword.ForeColor = Color.Gray;
            this.Show();
        }
    }
}
