namespace ExampleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 91);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Cari :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 27);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 136);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Malzeme :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 27);
            textBox3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 314);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Sevk Tarihi :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(169, 311);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(187, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(591, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(859, 576);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(359, 28);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 273);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 1;
            label4.Text = "Oluşturulma Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 359);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 1;
            label5.Text = "Miktar :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 177);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 1;
            label6.Text = "Barcode :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 223);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 1;
            label7.Text = "Birim Fiyat :";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(169, 266);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(187, 27);
            maskedTextBox2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(169, 352);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(169, 223);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(383, 434);
            button1.Name = "button1";
            button1.Size = new Size(145, 41);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 828);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(maskedTextBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button button1;
    }
}
