using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleApp.Context;

namespace ExampleApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           var customerForm = new CustomerForm();
            customerForm.ShowDialog();
            
        }
    }
}
