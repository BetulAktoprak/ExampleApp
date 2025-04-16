using ExampleApp.Context;
using ExampleApp.Entities;

namespace ExampleApp;
public partial class UserRegisterForm : Form
{
    private Cari? userCari;
    public UserRegisterForm()
    {
        InitializeComponent();
    }

    private void UserRegisterForm_Load(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var user = LoginForm.LoggedInUser;

            if (user != null && user.CariId != null)
            {
                userCari = context.Caris.FirstOrDefault(c => c.Id == user.CariId);

                if (userCari != null)
                {
                    txtFullName.Text = userCari.FullName;
                    txtPhone.Text = userCari.Phone;
                    txtEmail.Text = userCari.Email;
                    txtVergiNo.Text = userCari.VergiNo.ToString();
                    txtVergiDairesi.Text = userCari.VergiDairesi;
                }
            }
        }
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

            if (!int.TryParse(txtTC.Text, out int tcNo) || !int.TryParse(txtVergiNo.Text, out int vergiNo))
            {
                MessageBox.Show("TC No ve Vergi No sayısal olmalıdır.");
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
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }

}
