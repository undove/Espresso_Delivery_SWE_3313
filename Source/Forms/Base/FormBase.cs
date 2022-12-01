using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base;

public class FormBase : Form
{
    public FormBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
        InitializeComponent();
        ConfigureWindow();
        _appSettings = new AppSettings();
    }

    public FormBase(IAppSettings appSettings) : this()
    {
        _appSettings = appSettings;
        InitializeComponent();
    }

    private IAppSettings _appSettings;

    protected void ConfigureWindow()
    {
        InitializeComponent();
        PerformLayout();
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espresso Delivery";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

    }

    /// <summary>
    ///     Helper method to set the form title
    /// </summary>
    /// <param name="title"></param>
    protected void SetTitle(string title = "")
    {
        Text = string.IsNullOrWhiteSpace(title)
            ? _appSettings.App.Name
            : $"{title} | {_appSettings.App.Name}";
    }

    private void OnLoadFormBase(object sender, EventArgs e)
    {
        ConfigureWindow(); //sets window to proper size and position - all forms should all this at start of OnLoad
        SetTitle();
    }

    private void FormBase_Load(object sender, EventArgs e)
    {

    }
}