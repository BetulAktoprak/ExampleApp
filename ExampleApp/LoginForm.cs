using ExampleApp.Context;
using ExampleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp;
public partial class LoginForm : Form
{
    public static AppUser? LoggedInUser;

    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = context.AppUsers
                              .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    var adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (user.Role == "User")
                {
                    this.Hide();
                    var orderForm = new OrderForm(user);
                    orderForm.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                LoggedInUser = user;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        UserRegisterForm registerForm = new UserRegisterForm();

        this.Hide();
        var result = registerForm.ShowDialog();
        if (result == DialogResult.OK || result == DialogResult.Cancel)
        {
            this.Show();
        }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = true;
    }
}

