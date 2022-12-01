namespace CoffeePointOfSale.Forms
{
    partial class FormReceiptCustomerCard
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
            this.Cardinfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cartBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cardinfo
            // 
            this.Cardinfo.AutoSize = true;
            this.Cardinfo.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cardinfo.ForeColor = System.Drawing.Color.White;
            this.Cardinfo.Location = new System.Drawing.Point(705, 596);
            this.Cardinfo.Name = "Cardinfo";
            this.Cardinfo.Size = new System.Drawing.Size(160, 33);
            this.Cardinfo.TabIndex = 5;
            this.Cardinfo.Text = "********XXXX";
            this.Cardinfo.Click += new System.EventHandler(this.Cardinfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(480, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Credit Card:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(585, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Receipt";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(46, 41);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 58);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // cartBox
            // 
            this.cartBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cartBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cartBox.Location = new System.Drawing.Point(476, 106);
            this.cartBox.Multiline = true;
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(387, 474);
            this.cartBox.TabIndex = 54;
            // 
            // FormReceiptCustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.cartBox);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.Cardinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormReceiptCustomerCard";
            this.Text = "FormReceiptCustomerCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Cardinfo;
        private Label label2;
        private Label label1;
        private Button btnHome;
        private TextBox cartBox;
    }
}