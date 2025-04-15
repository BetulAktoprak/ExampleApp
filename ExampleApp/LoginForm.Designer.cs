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
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(btnLogin);
        panel1.Controls.Add(txtPassword);
        panel1.Controls.Add(txtUsername);
        panel1.Location = new Point(239, 123);
        panel1.Name = "panel1";
        panel1.Size = new Size(573, 233);
        panel1.TabIndex = 0;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(156, 119);
        label2.Name = "label2";
        label2.Size = new Size(33, 15);
        label2.TabIndex = 2;
        label2.Text = "Şifre:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(113, 73);
        label1.Name = "label1";
        label1.Size = new Size(76, 15);
        label1.TabIndex = 2;
        label1.Text = "Kullanıcı Adı:";
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(252, 166);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(111, 31);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Giriş Yap";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(215, 111);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(203, 23);
        txtPassword.TabIndex = 0;
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(215, 65);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(203, 23);
        txtUsername.TabIndex = 0;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1151, 637);
        Controls.Add(panel1);
        Name = "LoginForm";
        Text = "LoginForm";
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
}