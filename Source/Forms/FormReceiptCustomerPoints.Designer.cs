namespace CoffeePointOfSale.Forms
{
    partial class FormReceiptCustomerPoints
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.cartBox = new System.Windows.Forms.TextBox();
            this.RULabel = new System.Windows.Forms.Label();
            this.RBLabel = new System.Windows.Forms.Label();
            this.RewardsPointsUsed = new System.Windows.Forms.Label();
            this.RemainingBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(560, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receipt";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(34, 33);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(124, 58);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cartBox
            // 
            this.cartBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cartBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cartBox.Location = new System.Drawing.Point(456, 107);
            this.cartBox.Multiline = true;
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(389, 440);
            this.cartBox.TabIndex = 55;
            //this.cartBox.TextChanged += new System.EventHandler(this.cartBox_TextChanged);
            // 
            // RULabel
            // 
            this.RULabel.AutoSize = true;
            this.RULabel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RULabel.ForeColor = System.Drawing.Color.White;
            this.RULabel.Location = new System.Drawing.Point(456, 562);
            this.RULabel.Name = "RULabel";
            this.RULabel.Size = new System.Drawing.Size(290, 33);
            this.RULabel.TabIndex = 56;
            this.RULabel.Text = "Rewards Points Used:";
            //this.RULabel.Click += new System.EventHandler(this.RULabel_Click);
            // 
            // RBLabel
            // 
            this.RBLabel.AutoSize = true;
            this.RBLabel.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RBLabel.ForeColor = System.Drawing.Color.White;
            this.RBLabel.Location = new System.Drawing.Point(456, 606);
            this.RBLabel.Name = "RBLabel";
            this.RBLabel.Size = new System.Drawing.Size(267, 33);
            this.RBLabel.TabIndex = 57;
            this.RBLabel.Text = "Remaining Balance:";
            //this.RBLabel.Click += new System.EventHandler(this.RBLabel_Click);
            // 
            // RewardsPointsUsed
            // 
            this.RewardsPointsUsed.AutoSize = true;
            this.RewardsPointsUsed.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RewardsPointsUsed.ForeColor = System.Drawing.Color.White;
            this.RewardsPointsUsed.Location = new System.Drawing.Point(765, 562);
            this.RewardsPointsUsed.Name = "RewardsPointsUsed";
            this.RewardsPointsUsed.Size = new System.Drawing.Size(80, 33);
            this.RewardsPointsUsed.TabIndex = 58;
            this.RewardsPointsUsed.Text = "XXXX";
            //this.RewardsPointsUsed.Click += new System.EventHandler(this.RewardsPointsUsed_Click);
            // 
            // RemainingBalance
            // 
            this.RemainingBalance.AutoSize = true;
            this.RemainingBalance.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemainingBalance.ForeColor = System.Drawing.Color.White;
            this.RemainingBalance.Location = new System.Drawing.Point(765, 606);
            this.RemainingBalance.Name = "RemainingBalance";
            this.RemainingBalance.Size = new System.Drawing.Size(80, 33);
            this.RemainingBalance.TabIndex = 59;
            this.RemainingBalance.Text = "XXXX";
            //this.RemainingBalance.Click += new System.EventHandler(this.RemainingBalance_Click);
            // 
            // FormReceiptCustomerPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.RemainingBalance);
            this.Controls.Add(this.RewardsPointsUsed);
            this.Controls.Add(this.RBLabel);
            this.Controls.Add(this.RULabel);
            this.Controls.Add(this.cartBox);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormReceiptCustomerPoints";
            this.Text = "FormReceiptCustomer";
            //this.Load += new System.EventHandler(this.FormReceiptCustomerPoints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnHome;
        private TextBox cartBox;
        private Label RULabel;
        private Label RBLabel;
        private Label RewardsPointsUsed;
        private Label RemainingBalance;
    }
}