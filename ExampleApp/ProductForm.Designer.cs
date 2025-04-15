namespace ExampleApp
{
    partial class ProductForm
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
            btnKaydet = new Button();
            nmrUnitPrice = new NumericUpDown();
            nmrStock = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtMalzeme = new TextBox();
            button1 = new Button();
            lblBarcode = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(390, 263);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(137, 35);
            btnKaydet.TabIndex = 23;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // nmrUnitPrice
            // 
            nmrUnitPrice.Location = new Point(168, 85);
            nmrUnitPrice.Name = "nmrUnitPrice";
            nmrUnitPrice.Size = new Size(150, 27);
            nmrUnitPrice.TabIndex = 22;
            // 
            // nmrStock
            // 
            nmrStock.Location = new Point(168, 127);
            nmrStock.Name = "nmrStock";
            nmrStock.Size = new Size(150, 27);
            nmrStock.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 85);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 12;
            label7.Text = "Birim Fiyat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 134);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Stok :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 49);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 16;
            label2.Text = "Malzeme :";
            // 
            // txtMalzeme
            // 
            txtMalzeme.Location = new Point(168, 42);
            txtMalzeme.Name = "txtMalzeme";
            txtMalzeme.Size = new Size(359, 27);
            txtMalzeme.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(27, 188);
            button1.Name = "button1";
            button1.Size = new Size(162, 29);
            button1.TabIndex = 25;
            button1.Text = "Barkod Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(222, 197);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1089, 373);
            dataGridView1.TabIndex = 27;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 792);
            Controls.Add(dataGridView1);
            Controls.Add(lblBarcode);
            Controls.Add(button1);
            Controls.Add(btnKaydet);
            Controls.Add(nmrUnitPrice);
            Controls.Add(nmrStock);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtMalzeme);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private NumericUpDown nmrUnitPrice;
        private NumericUpDown nmrStock;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox txtMalzeme;
        private Button button1;
        private Label lblBarcode;
        private DataGridView dataGridView1;
    }
}