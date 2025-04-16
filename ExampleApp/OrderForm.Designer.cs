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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SkyBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(377, 235);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 38);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(148, 161);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(150, 27);
            nmrAdet.TabIndex = 36;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(148, 26);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(359, 28);
            cmbProducts.TabIndex = 34;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 168);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 29;
            label5.Text = "Miktar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 116);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 30;
            label3.Text = "Sevk Tarihi :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 29);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 32;
            label8.Text = "Ürünler";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = SystemColors.Control;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(30, 349);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(921, 333);
            dgvOrders.TabIndex = 39;
            // 
            // dtpSevkTarihi
            // 
            dtpSevkTarihi.Location = new Point(148, 109);
            dtpSevkTarihi.MinDate = new DateTime(2025, 4, 16, 0, 0, 0, 0);
            dtpSevkTarihi.Name = "dtpSevkTarihi";
            dtpSevkTarihi.Size = new Size(250, 27);
            dtpSevkTarihi.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 209);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 41;
            label1.Text = "KDV:";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(148, 209);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(0, 20);
            lblKdv.TabIndex = 42;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(148, 70);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(0, 20);
            lblBarcode.TabIndex = 43;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(82, 242);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 44;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(dtpSevkTarihi);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblBarcode);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblKdv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbProducts);
            groupBox1.Controls.Add(nmrAdet);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(30, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 291);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Sipariş";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1020, 763);
            Controls.Add(dgvOrders);
            Controls.Add(groupBox1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}