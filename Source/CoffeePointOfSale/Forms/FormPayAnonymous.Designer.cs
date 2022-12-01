namespace CoffeePointOfSale.Forms
{
    partial class FormPayAnonymous
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputBoxCardNumber = new System.Windows.Forms.TextBox();
            this.inputBoxCVV = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(33, 31);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 58);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inputBoxCardNumber
            // 
            this.inputBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBoxCardNumber.Location = new System.Drawing.Point(402, 280);
            this.inputBoxCardNumber.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.inputBoxCardNumber.Name = "inputBoxCardNumber";
            this.inputBoxCardNumber.PlaceholderText = "Card Number";
            this.inputBoxCardNumber.Size = new System.Drawing.Size(368, 44);
            this.inputBoxCardNumber.TabIndex = 13;
            this.inputBoxCardNumber.TextChanged += new System.EventHandler(this.inputBoxCardNumber_TextChanged);
            // 
            // inputBoxCVV
            // 
            this.inputBoxCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBoxCVV.Location = new System.Drawing.Point(800, 280);
            this.inputBoxCVV.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.inputBoxCVV.Name = "inputBoxCVV";
            this.inputBoxCVV.PlaceholderText = "CVV";
            this.inputBoxCVV.Size = new System.Drawing.Size(78, 44);
            this.inputBoxCVV.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.Location = new System.Drawing.Point(577, 382);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 58);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(484, 152);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(96, 30);
            this.ErrorText.TabIndex = 16;
            this.ErrorText.Text = "ErrText";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPayAnonymous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.inputBoxCVV);
            this.Controls.Add(this.inputBoxCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormPayAnonymous";
            this.Text = "FormPayAnonymous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        public TextBox inputBoxCardNumber;
        public TextBox inputBoxCVV;
        private Button btnPay;
        public Label ErrorText;
    }
}