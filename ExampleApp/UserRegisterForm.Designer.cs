namespace ExampleApp;

partial class UserRegisterForm
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
        label1 = new Label();
        txtTC = new TextBox();
        label2 = new Label();
        txtEmail = new TextBox();
        label3 = new Label();
        txtFullName = new TextBox();
        label4 = new Label();
        txtUsername = new TextBox();
        label5 = new Label();
        txtVergiNo = new TextBox();
        label6 = new Label();
        label7 = new Label();
        txtVergiDairesi = new TextBox();
        txtPhone = new TextBox();
        btnSave = new Button();
        txtPassword = new TextBox();
        label8 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(155, 73);
        label1.Name = "label1";
        label1.Size = new Size(25, 20);
        label1.TabIndex = 0;
        label1.Text = "TC";
        // 
        // txtTC
        // 
        txtTC.Location = new Point(201, 73);
        txtTC.Margin = new Padding(3, 4, 3, 4);
        txtTC.Name = "txtTC";
        txtTC.Size = new Size(196, 27);
        txtTC.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(122, 256);
        label2.Name = "label2";
        label2.Size = new Size(58, 20);
        label2.TabIndex = 0;
        label2.Text = "Telefon";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(201, 201);
        txtEmail.Margin = new Padding(3, 4, 3, 4);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(196, 27);
        txtEmail.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(108, 108);
        label3.Name = "label3";
        label3.Size = new Size(72, 20);
        label3.TabIndex = 0;
        label3.Text = "FullName";
        // 
        // txtFullName
        // 
        txtFullName.Location = new Point(201, 108);
        txtFullName.Margin = new Padding(3, 4, 3, 4);
        txtFullName.Name = "txtFullName";
        txtFullName.Size = new Size(196, 27);
        txtFullName.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(105, 152);
        label4.Name = "label4";
        label4.Size = new Size(75, 20);
        label4.TabIndex = 0;
        label4.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(201, 152);
        txtUsername.Margin = new Padding(3, 4, 3, 4);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(196, 27);
        txtUsername.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(113, 310);
        label5.Name = "label5";
        label5.Size = new Size(67, 20);
        label5.TabIndex = 0;
        label5.Text = "Vergi No";
        // 
        // txtVergiNo
        // 
        txtVergiNo.Location = new Point(201, 306);
        txtVergiNo.Margin = new Padding(3, 4, 3, 4);
        txtVergiNo.Name = "txtVergiNo";
        txtVergiNo.Size = new Size(196, 27);
        txtVergiNo.TabIndex = 1;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(87, 354);
        label6.Name = "label6";
        label6.Size = new Size(93, 20);
        label6.TabIndex = 0;
        label6.Text = "Vergi Dairesi";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(134, 201);
        label7.Name = "label7";
        label7.Size = new Size(46, 20);
        label7.TabIndex = 0;
        label7.Text = "Email";
        // 
        // txtVergiDairesi
        // 
        txtVergiDairesi.Location = new Point(201, 350);
        txtVergiDairesi.Margin = new Padding(3, 4, 3, 4);
        txtVergiDairesi.Name = "txtVergiDairesi";
        txtVergiDairesi.Size = new Size(196, 27);
        txtVergiDairesi.TabIndex = 1;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(201, 256);
        txtPhone.Margin = new Padding(3, 4, 3, 4);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(196, 27);
        txtPhone.TabIndex = 1;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(201, 468);
        btnSave.Margin = new Padding(3, 4, 3, 4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(196, 31);
        btnSave.TabIndex = 2;
        btnSave.Text = "Kayıt Ol";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(201, 400);
        txtPassword.Margin = new Padding(3, 4, 3, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(196, 27);
        txtPassword.TabIndex = 4;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(141, 407);
        label8.Name = "label8";
        label8.Size = new Size(39, 20);
        label8.TabIndex = 3;
        label8.Text = "Şifre";
        // 
        // UserRegisterForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(705, 607);
        Controls.Add(txtPassword);
        Controls.Add(label8);
        Controls.Add(btnSave);
        Controls.Add(txtPhone);
        Controls.Add(txtVergiDairesi);
        Controls.Add(txtUsername);
        Controls.Add(label7);
        Controls.Add(txtEmail);
        Controls.Add(label6);
        Controls.Add(label4);
        Controls.Add(label2);
        Controls.Add(txtFullName);
        Controls.Add(txtVergiNo);
        Controls.Add(label3);
        Controls.Add(label5);
        Controls.Add(txtTC);
        Controls.Add(label1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "UserRegisterForm";
        Text = "UserRegisterForm";
        Load += UserRegisterForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtTC;
    private Label label2;
    private TextBox txtEmail;
    private Label label3;
    private TextBox txtFullName;
    private Label label4;
    private TextBox txtUsername;
    private Label label5;
    private TextBox txtVergiNo;
    private Label label6;
    private Label label7;
    private TextBox txtVergiDairesi;
    private TextBox txtPhone;
    private Button btnSave;
    private TextBox txtPassword;
    private Label label8;
}