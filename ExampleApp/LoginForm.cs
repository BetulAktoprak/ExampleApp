using ExampleApp.Context;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        using (var context = new AppDbContext())
        {
            var user = context.AppUsers
                              .Include(u => u.Cari)
                              .FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                return;
            }

            if (user.Role == "Admin")
            {
                var adminForm = new AdminForm();
                adminForm.Show();
            }
            else
            {
                var userForm = new UserForm(user);
                userForm.Show();
            }

            this.Hide();
        }
    }
}
