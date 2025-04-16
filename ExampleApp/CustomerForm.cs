using System.Windows.Forms;
using ExampleApp.Context;
using ExampleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp;
public partial class CustomerForm : Form
{
    public CustomerForm()
    {
        InitializeComponent();
    }

    private void CustomerForm_Load(object sender, EventArgs e)
    {
        CustomerList();
    }

    private void CustomerList()
    {
        using (var context = new AppDbContext())
        {
            var cariList = context.Caris.Include(c => c.Orders!)
                .ThenInclude(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .Select(c => new
                {
                    c.Id,
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
            
            dgvCustomerList.DataSource = cariList;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {

            if (!int.TryParse(txtTC.Text, out int tcNo) || !int.TryParse(txtVergiNo.Text, out int vergiNo))
            {
                MessageBox.Show("TC No ve Vergi No sayısal olmalıdır.");
                return;
            }

            var newCari = new Cari
            {
                FullName = txtFullName.Text,
                TCNo = int.Parse(txtTC.Text),
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                VergiNo = int.Parse(txtVergiNo.Text),
                VergiDairesi = txtVergiDairesi.Text
            };

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.");
                return;
            }

            context.Caris.Add(newCari);
            context.SaveChanges();

            var newUser = new AppUser
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = "User",
                CariId = newCari.Id
            };

            context.AppUsers.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
            CustomerClear();
            CustomerList();
        }
    }

    private void CustomerClear()
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtFullName.Clear();
        txtPhone.Clear();
        txtEmail.Clear();
        txtTC.Clear();
        txtVergiNo.Clear();
        txtVergiDairesi.Clear();
    }

    private void dgvCustomerList_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Delete)
        {
            if (dgvCustomerList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCustomerList.SelectedRows[0];
                var customerId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var result = MessageBox.Show("Bu kullanıcıyı silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var context = new AppDbContext())
                    {
                        var customer = context.Caris.FirstOrDefault(c => c.Id == customerId);
                        if (customer != null)
                        {
                            context.Caris.Remove(customer);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Ürün silindi.");
                        CustomerList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }
    }
}
