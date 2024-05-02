using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            pnlItemDetails.Hide();
        }

        private void btnUnit1_Click(object sender, EventArgs e)
        {
            pnlItemDetails.Show();
        }
    }
}
