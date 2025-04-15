namespace ExampleApp
{
    partial class CariForm
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
            txtCariAd = new TextBox();
            label1 = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // txtCariAd
            // 
            txtCariAd.Location = new Point(161, 72);
            txtCariAd.Name = "txtCariAd";
            txtCariAd.Size = new Size(348, 27);
            txtCariAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 79);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Cari Ad :";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(415, 134);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // CariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(label1);
            Controls.Add(txtCariAd);
            Name = "CariForm";
            Text = "CariForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCariAd;
        private Label label1;
        private Button btnKaydet;
    }
}