namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDrinkOrder = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManagement.BackgroundImage")));
            this.btnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Location = new System.Drawing.Point(861, 184);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(288, 280);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.OnClickBtnManagement);
            // 
            // btnDrinkOrder
            // 
            this.btnDrinkOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnDrinkOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrinkOrder.BackgroundImage")));
            this.btnDrinkOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDrinkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinkOrder.Location = new System.Drawing.Point(512, 184);
            this.btnDrinkOrder.Name = "btnDrinkOrder";
            this.btnDrinkOrder.Size = new System.Drawing.Size(288, 280);
            this.btnDrinkOrder.TabIndex = 1;
            this.btnDrinkOrder.UseVisualStyleBackColor = false;
            this.btnDrinkOrder.Click += new System.EventHandler(this.OnClickBtnDrinkOrder);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCustomerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomerList.BackgroundImage")));
            this.btnCustomerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerList.Location = new System.Drawing.Point(163, 184);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(288, 280);
            this.btnCustomerList.TabIndex = 2;
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.OnClickBtnCustomerList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(548, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(881, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Management";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.btnDrinkOrder);
            this.Controls.Add(this.btnManagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button btnManagement;
    private Button btnDrinkOrder;
    private Button btnCustomerList;
    private Label label1;
    private Label label2;
    private Label label3;
}