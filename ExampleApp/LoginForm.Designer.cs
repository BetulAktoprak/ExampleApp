namespace ExampleApp;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        btnRegister = new Button();
        label2 = new Label();
        label1 = new Label();
        btnLogin = new Button();
        txtPassword = new TextBox();
        txtUsername = new TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ControlLightLight;
        panel1.Controls.Add(btnRegister);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(btnLogin);
        panel1.Controls.Add(txtPassword);
        panel1.Controls.Add(txtUsername);
        panel1.Location = new Point(273, 164);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(655, 311);
        panel1.TabIndex = 0;
        // 
        // btnRegister
        // 
        btnRegister.BackColor = Color.DarkSeaGreen;
        btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRegister.Location = new Point(383, 38);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(94, 29);
        btnRegister.TabIndex = 3;
        btnRegister.Text = "Kayıt Ol";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(178, 159);
        label2.Name = "label2";
        label2.Size = new Size(42, 20);
        label2.TabIndex = 2;
        label2.Text = "Şifre:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(129, 97);
        label1.Name = "label1";
        label1.Size = new Size(95, 20);
        label1.TabIndex = 2;
        label1.Text = "Kullanıcı Adı:";
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.LightBlue;
        btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLogin.Location = new Point(350, 207);
        btnLogin.Margin = new Padding(3, 4, 3, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(127, 41);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Giriş Yap";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(246, 148);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(231, 27);
        txtPassword.TabIndex = 1;
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(246, 87);
        txtUsername.Margin = new Padding(3, 4, 3, 4);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(231, 27);
        txtUsername.TabIndex = 0;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientActiveCaption;
        ClientSize = new Size(1315, 849);
        Controls.Add(panel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "LoginForm";
        Text = "LoginForm";
        Load += LoginForm_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label2;
    private Label label1;
    private Button btnLogin;
    private TextBox txtPassword;
    private TextBox txtUsername;
    private Button btnRegister;
}