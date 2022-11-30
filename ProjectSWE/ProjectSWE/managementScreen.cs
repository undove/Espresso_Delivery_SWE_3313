using ProjectSWE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementScreen
    {
    public partial class managementScreen : Form
    {
        private Form menu;
        public managementScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeCSVFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu = new MainScreen.mainMenu();
            Hide();
            menu.Show();
        }
        void writeCSVFile()
        {
            Class1 csv = new Class1();
            csv.Main();
        }
    }
}
