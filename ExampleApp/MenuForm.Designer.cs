namespace ExampleApp
{
    partial class MenuForm
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
            btnCustomer = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 12);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(235, 167);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Müşteriler";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(253, 12);
            button2.Name = "button2";
            button2.Size = new Size(235, 167);
            button2.TabIndex = 1;
            button2.Text = "Stok Kartları";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 185);
            button3.Name = "button3";
            button3.Size = new Size(235, 167);
            button3.TabIndex = 1;
            button3.Text = "Siparişler\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 643);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCustomer);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomer;
        private Button button2;
        private Button button3;
    }
}