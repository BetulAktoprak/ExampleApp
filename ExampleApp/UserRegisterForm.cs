using ExampleApp.Context;
using ExampleApp.Entities;

namespace ExampleApp;
public partial class UserRegisterForm : Form
{
    public UserRegisterForm()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
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
                UserName = txtUsername.Text,
                Password = txtPassword.Text, 
                Role = "User",
                CariId = newCari.Id 
            };

            context.AppUsers.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Kullanıcı başarıyla kaydedildi!");
            this.Close(); 
        }
    }
}
