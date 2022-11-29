
namespace ManagementScreen
{
    partial class managementScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managementScreen));
            this.salesReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesReport
            // 
            this.salesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.salesReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesReport.BackgroundImage")));
            this.salesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salesReport.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesReport.Location = new System.Drawing.Point(476, 237);
            this.salesReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesReport.Name = "salesReport";
            this.salesReport.Size = new System.Drawing.Size(396, 247);
            this.salesReport.TabIndex = 0;
            this.salesReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salesReport.UseVisualStyleBackColor = false;
            this.salesReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(20, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // managementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salesReport);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "managementScreen";
            this.Text = "managementScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salesReport;
        private System.Windows.Forms.Button button2;
    }
}

