using System.Data;
using ExampleApp.Context;
using ExampleApp.Entities;
using ExampleProject;
using ExampleProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp
{
    public partial class OrderForm : Form
    {
        private readonly AppUser _currentUser;
        public OrderForm(AppUser user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadUserOrders();

            lblKdv.Text = "%18";
            dtpSevkTarihi.MinDate = DateTime.Today;
        }

        private void LoadUserOrders()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Where(o => o.CariId == _currentUser.CariId)
                    .SelectMany(o => o.OrderDetails.Select(od => new
                    {
                        FisNo = o.FisNo,
                        o.ShipmentDate,
                        o.CreatedDate,
                        UrunAdi = od.Product!.ProductName,
                        BirimFiyat = od.UnitPrice,
                        Adet = od.Quantity,
                        ToplamTutar = od.TotalAmount
                    }))
                    .ToList();

                dgvOrders.DataSource = orders;

                dgvOrders.Columns["FisNo"].HeaderText = "Fiş No";
                dgvOrders.Columns["ShipmentDate"].HeaderText = "Sevkiyat Tarihi";
                dgvOrders.Columns["CreatedDate"].HeaderText = "Oluşturulma Tarihi";
                dgvOrders.Columns["UrunAdi"].HeaderText = "Ürün Adı";
                dgvOrders.Columns["BirimFiyat"].HeaderText = "Birim Fiyat";
                dgvOrders.Columns["Adet"].HeaderText = "Adet";
                dgvOrders.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";
            }
        }

        private void LoadProducts()
        {
            using (var context = new AppDbContext())
            {

                var productList = context.Products
                    .Where(p => p.Stock > 0)
                    .ToList();
                cmbProducts.DataSource = productList;
                cmbProducts.DisplayMember = "ProductName";
                cmbProducts.ValueMember = "Id";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem == null || nmrAdet.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli ürün ve adet giriniz.");
                return;
            }

            var selectedProductId = Convert.ToInt32(cmbProducts.SelectedValue);
            int quantity = (int)nmrAdet.Value;

            using (var context = new AppDbContext())
            {
                var dbProduct = context.Products.FirstOrDefault(p => p.Id == selectedProductId);
                if (dbProduct == null)
                {
                    MessageBox.Show("Ürün bulunamadı.");
                    return;
                }

                if (dbProduct.Stock < quantity)
                {
                    MessageBox.Show("Yeterli stok yok.");
                    return;
                }

                var cari = context.Caris.FirstOrDefault(c => c.Id == _currentUser.CariId);
                if (cari == null)
                {
                    MessageBox.Show("Cari bilgisi bulunamadı.");
                    return;
                }

                const decimal kdvOrani = 0.18m;
                decimal kdv = dbProduct.UnitPrice * quantity * kdvOrani;
                decimal total = dbProduct.UnitPrice * quantity + kdv;

                lblKdv.Text = $"{kdv:C}";

                var orderDetail = new OrderDetail
                {
                    ProductId = dbProduct.Id,
                    Quantity = quantity,
                    UnitPrice = dbProduct.UnitPrice,
                    KDV = 18,
                    TotalAmount = total
                };

                var order = new Order
                {
                    FisNo = new Random().Next(1000, 9999),
                    ShipmentDate = dtpSevkTarihi.Value,
                    CariId = cari.Id,
                    OrderDetails = new List<OrderDetail> { orderDetail }
                };

                dbProduct.Stock -= quantity;

                context.Orders.Add(order);
                context.SaveChanges();

                MessageBox.Show("Sipariş başarıyla eklendi!");
                LoadUserOrders();
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProducts.SelectedItem is Product selectedProduct)
            {
                lblBarcode.Text = $"Barkod: {selectedProduct.Barcode}";
                lblPrice.Text = $"Fiyat:      {selectedProduct.UnitPrice:C}";
            }
        }
    }
}
