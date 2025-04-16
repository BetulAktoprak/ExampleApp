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
            btnSave.BackColor = Color.LightSkyBlue;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(317, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 35);
            btnSave.TabIndex = 23;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // nmrUnitPrice
            // 
            nmrUnitPrice.Location = new Point(218, 232);
            nmrUnitPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmrUnitPrice.Name = "nmrUnitPrice";
            nmrUnitPrice.Size = new Size(150, 27);
            nmrUnitPrice.TabIndex = 22;
            // 
            // nmrStock
            // 
            nmrStock.Location = new Point(218, 273);
            nmrStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmrStock.Name = "nmrStock";
            nmrStock.Size = new Size(150, 27);
            nmrStock.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 232);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 12;
            label7.Text = "Ürün fiyatı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 280);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 14;
            label5.Text = "Stok miktarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 196);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 16;
            label2.Text = "Ürün adı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(218, 189);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(217, 27);
            txtAd.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(78, 335);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 25;
            button1.Text = "Barkod Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(272, 344);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 563);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1418, 330);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(203, 411);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 35);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(144, 116);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 28;
            label1.Text = "Ürün Ekleme Formu";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.Location = new Point(78, 411);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 35);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(536, 64);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(910, 382);
            dataGridView2.TabIndex = 30;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(781, 28);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 31;
            label3.Text = "Kullanıcı Listesi";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1589, 905);
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