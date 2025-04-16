using ExampleApp.Context;
using ExampleProject;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            using (var context = new AppDbContext())
            {
                var cariList = context.Caris.Include(c => c.Orders)
                    .ThenInclude(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                    .Select(c => new
                    {
                        c.TCNo,
                        c.FullName,
                        c.Email,
                        c.Phone,
                        c.CreatedDate,
                        Products = string.Join(", ",
                            c.Orders
                             .SelectMany(o => o.OrderDetails)
                             .Select(od => od.Product.ProductName)
                             .Distinct()
                )
                    }).ToList();
                dataGridView2.DataSource = cariList;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var product = new Product
                    {
                        ProductName = txtAd.Text,
                        UnitPrice = nmrUnitPrice.Value,
                        Stock = (int)nmrStock.Value,
                        Barcode = lblBarcode.Text
                    };

                    if (string.IsNullOrWhiteSpace(txtAd.Text) || nmrUnitPrice.Value <= 0 || nmrStock.Value < 0)
                    {
                        MessageBox.Show("Lütfen geçerli ürün bilgilerini giriniz.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(lblBarcode.Text))
                    {
                        MessageBox.Show("Lütfen barkod oluşturun.");
                        return;
                    }

                    context.Products.Add(product);
                    context.SaveChanges();

                    MessageBox.Show("Ürün Eklendi");

                    ClearForm();

                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu. " + ex.Message);
            }
        }

        private Guid selectedProductId = Guid.Empty;

        private void ClearForm()
        {
            txtAd.Clear();
            nmrUnitPrice.Value = 0;
            nmrStock.Value = 0;
            lblBarcode.Text = string.Empty;
            selectedProductId = Guid.Empty;
        }

        private void LoadProducts()
        {
            using (var context = new AppDbContext())
            {
                var productList = context.Products.Select(p => new
                {
                    p.Id,
                    p.ProductName,
                    p.Barcode,
                    UnitPrice = p.UnitPrice.ToString("N2"),
                    p.Stock,
                    p.CreatedDate
                }).ToList();

                dataGridView1.DataSource = productList;
                dataGridView1.Columns["Id"].Visible = false;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtAd.Text = row.Cells["ProductName"].Value.ToString();
                lblBarcode.Text = row.Cells["Barcode"].Value.ToString();
                nmrStock.Value = Convert.ToInt32(row.Cells["Stock"].Value);
                nmrUnitPrice.Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                selectedProductId = (Guid)row.Cells["Id"].Value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == Guid.Empty)
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var product = context.Products.Find(selectedProductId);
                if (product != null)
                {
                    product.ProductName = txtAd.Text;
                    product.Barcode = lblBarcode.Text;
                    product.UnitPrice = nmrUnitPrice.Value;
                    product.Stock = (int)nmrStock.Value;
                    product.UpdatedDate = DateTime.UtcNow;

                    context.SaveChanges();

                    MessageBox.Show("Ürün başarıyla güncellendi.");

                    LoadProducts();
                    ClearForm();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedProductId == Guid.Empty)
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin.");
                return;
            }

            var result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    var product = context.Products.Find(selectedProductId);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();

                        MessageBox.Show("Ürün silindi.");

                        LoadProducts();
                        ClearForm();
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

