namespace CoffeePointOfSale.Forms
{
    partial class FormPayCustomer
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
            this.btnPay = new System.Windows.Forms.Button();
            this.inputBoxCVV = new System.Windows.Forms.TextBox();
            this.btnRewards = new System.Windows.Forms.Button();
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
            this.btnCancel.Location = new System.Drawing.Point(37, 33);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inputBoxCardNumber
            // 
            this.inputBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBoxCardNumber.Location = new System.Drawing.Point(132, 294);
            this.inputBoxCardNumber.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.inputBoxCardNumber.Name = "inputBoxCardNumber";
            this.inputBoxCardNumber.PlaceholderText = "Card Number";
            this.inputBoxCardNumber.Size = new System.Drawing.Size(368, 44);
            this.inputBoxCardNumber.TabIndex = 14;
            this.inputBoxCardNumber.TextChanged += new System.EventHandler(this.inputBoxCardNumber_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.Location = new System.Drawing.Point(298, 396);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 58);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // inputBoxCVV
            // 
            this.inputBoxCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBoxCVV.Location = new System.Drawing.Point(530, 294);
            this.inputBoxCVV.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.inputBoxCVV.Name = "inputBoxCVV";
            this.inputBoxCVV.PlaceholderText = "CVV";
            this.inputBoxCVV.Size = new System.Drawing.Size(78, 44);
            this.inputBoxCVV.TabIndex = 16;
            // 
            // btnRewards
            // 
            this.btnRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnRewards.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRewards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewards.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRewards.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRewards.Location = new System.Drawing.Point(818, 288);
            this.btnRewards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRewards.Name = "btnRewards";
            this.btnRewards.Size = new System.Drawing.Size(353, 58);
            this.btnRewards.TabIndex = 18;
            this.btnRewards.Text = "Pay With Rewards Points";
            this.btnRewards.UseVisualStyleBackColor = false;
            this.btnRewards.Click += new System.EventHandler(this.btnRewards_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(188, 196);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(96, 30);
            this.ErrorText.TabIndex = 19;
            this.ErrorText.Text = "ErrText";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPayCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.btnRewards);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.inputBoxCVV);
            this.Controls.Add(this.inputBoxCardNumber);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormPayCustomer";
            this.Text = "FormPayCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private TextBox inputBoxCardNumber;
        private Button btnPay;
        private TextBox inputBoxCVV;
        private Button btnRewards;
        public Label ErrorText;
    }
}