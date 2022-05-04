using MobilShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilShop
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Sign_In_Up signForm = new Sign_In_Up();
            signForm.ShowDialog();
            userButton.Text = "IN";
        }
    }
}
