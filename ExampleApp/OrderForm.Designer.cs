namespace ExampleApp
{
    partial class OrderForm
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
            btnAdd = new Button();
            nmrAdet = new NumericUpDown();
            cmbProducts = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            dgvOrders = new DataGridView();
            dtpSevkTarihi = new DateTimePicker();
            label1 = new Label();
            lblKdv = new Label();
            lblBarcode = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(366, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 41);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(152, 177);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(150, 27);
            nmrAdet.TabIndex = 36;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(152, 42);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(359, 28);
            cmbProducts.TabIndex = 34;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 184);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 29;
            label5.Text = "Miktar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 132);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 30;
            label3.Text = "Sevk Tarihi :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 45);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 32;
            label8.Text = "Ürünler";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(30, 349);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(921, 333);
            dgvOrders.TabIndex = 39;
            // 
            // dtpSevkTarihi
            // 
            dtpSevkTarihi.Location = new Point(152, 125);
            dtpSevkTarihi.MinDate = new DateTime(2025, 4, 16, 0, 0, 0, 0);
            dtpSevkTarihi.Name = "dtpSevkTarihi";
            dtpSevkTarihi.Size = new Size(250, 27);
            dtpSevkTarihi.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 225);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 41;
            label1.Text = "KDV:";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(152, 225);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(0, 20);
            lblKdv.TabIndex = 42;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(152, 86);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 43;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(86, 258);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 44;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 763);
            Controls.Add(lblPrice);
            Controls.Add(lblBarcode);
            Controls.Add(lblKdv);
            Controls.Add(label1);
            Controls.Add(dtpSevkTarihi);
            Controls.Add(dgvOrders);
            Controls.Add(btnAdd);
            Controls.Add(nmrAdet);
            Controls.Add(cmbProducts);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private NumericUpDown nmrAdet;
        private ComboBox cmbProducts;
        private Label label5;
        private Label label3;
        private Label label8;
        private DataGridView dgvOrders;
        private DateTimePicker dtpSevkTarihi;
        private Label label1;
        private Label lblKdv;
        private Label lblBarcode;
        private Label lblPrice;
    }
}