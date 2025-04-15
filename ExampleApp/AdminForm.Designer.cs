namespace ExampleApp
{
    partial class AdminForm
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
            btnSave = new Button();
            nmrUnitPrice = new NumericUpDown();
            nmrStock = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            button1 = new Button();
            lblBarcode = new Label();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            label1 = new Label();
            btnRemove = new Button();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(277, 308);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 26);
            btnSave.TabIndex = 23;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nmrUnitPrice
            // 
            nmrUnitPrice.Location = new Point(191, 174);
            nmrUnitPrice.Margin = new Padding(3, 2, 3, 2);
            nmrUnitPrice.Name = "nmrUnitPrice";
            nmrUnitPrice.Size = new Size(131, 23);
            nmrUnitPrice.TabIndex = 22;
            // 
            // nmrStock
            // 
            nmrStock.Location = new Point(191, 205);
            nmrStock.Margin = new Padding(3, 2, 3, 2);
            nmrStock.Name = "nmrStock";
            nmrStock.Size = new Size(131, 23);
            nmrStock.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 174);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 12;
            label7.Text = "Ürün fiyatı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 210);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 14;
            label5.Text = "Stok miktarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 147);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 16;
            label2.Text = "Ürün adı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(191, 142);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(190, 23);
            txtAd.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(68, 251);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(99, 22);
            button1.TabIndex = 25;
            button1.Text = "Barkod Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(238, 258);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 15);
            lblBarcode.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(419, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(543, 280);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(178, 308);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 26);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 87);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 28;
            label1.Text = "Ürün Ekleme Formu";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(68, 308);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(101, 26);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(68, 431);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(894, 213);
            dataGridView2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 397);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 31;
            label3.Text = "Kullanıcı Listesi";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 679);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(lblBarcode);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(nmrUnitPrice);
            Controls.Add(nmrStock);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private NumericUpDown nmrUnitPrice;
        private NumericUpDown nmrStock;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox txtAd;
        private Button button1;
        private Label lblBarcode;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Label label1;
        private Button btnRemove;
        private DataGridView dataGridView2;
        private Label label3;
    }
}