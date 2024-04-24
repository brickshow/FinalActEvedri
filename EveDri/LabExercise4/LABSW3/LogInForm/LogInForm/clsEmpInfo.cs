using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm 
{
    public class clsEmpInfo
    {
        
        //Initialize variable
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string CivilStatus { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        //Account Info
        public string Role { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        //Method to store data
    }
}