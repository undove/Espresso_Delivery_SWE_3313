using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainScreen
{
    public partial class mainMenu : Form
    {
        private Form management = new ManagementScreen.managementScreen();
        private Form customerList;
        private Form orderPage;
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openCustomerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openOrderPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openManagement();
        }
        public void openCustomerList()
        {
            customerList = new Form();
            Hide();
            customerList.Show();
        }
        public void openOrderPage()
        {
            orderPage = new Form();
            Hide();
            orderPage.Show();
        }
        public void openManagement()
        {
            Hide();
            management.Show();
        }
    }
}
