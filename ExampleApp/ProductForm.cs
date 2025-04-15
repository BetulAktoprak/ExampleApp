using ExampleApp.Context;
using ExampleProject;

namespace ExampleApp
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                dataGridView1.DataSource = context.Products.Select(p => new
                {
                    p.Metarial,
                    p.Barcode,
                    p.UnitPrice,
                    p.Stock,
                    p.CreatedDate
                }).ToList();
            }
            
        }

        private string CreateBarcode()
        {
            return "Logo" + Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = CreateBarcode();
            lblBarcode.Text = barcode;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (var context = new AppDbContext())
            {
                var product = new Product
                {
                    Metarial = txtMalzeme.Text,
                    UnitPrice = nmrUnitPrice.Value,
                    Stock = (int)nmrStock.Value,
                    Barcode = lblBarcode.Text
                };
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Ürün Eklendi");

                txtMalzeme.Clear();

            }
        }

        
    }
}
