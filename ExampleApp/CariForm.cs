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
using ExampleApp.Entities;

namespace ExampleApp
{
    public partial class CariForm : Form
    {
        public CariForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var cari = new Cari
                {
                    Name = txtCariAd.Text
                };

                context.Caris.Add(cari);
                context.SaveChanges();
                MessageBox.Show("Cari eklendi!");
                txtCariAd.Clear();
            }
        }
    }
}
