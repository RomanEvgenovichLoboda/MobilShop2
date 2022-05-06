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
        Model_Db_Others model = new Model_Db_Others();
        public Shop()
        {
            InitializeComponent();
           // AddProducts();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Sign_In_Up signForm = new Sign_In_Up();
            signForm.ShowDialog();
            userButton.Text = "IN";
        }

        
        private void AddProducts(string _company)
        {
            panel2.Controls.Clear();
            int x = 5, y = 5;
            foreach (var item in model.Mobiles)
            {
                if (_company == "All")
                {
                    panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                else if(_company == "Apple" && _company == item.Company)
                {
                    panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                else if (_company == "Samsung" && _company == item.Company)
                {
                    panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                if (x / 200 >= 3)
                {
                    y += 230;
                    x = 5;
                }
            }
        }


        private void All_button_Click(object sender, EventArgs e) { AddProducts("All"); }

        private void Apple_button_Click(object sender, EventArgs e) { AddProducts("Apple"); }

        private void Sumsung_button_Click(object sender, EventArgs e) { AddProducts("Samsung"); }
    }
}
