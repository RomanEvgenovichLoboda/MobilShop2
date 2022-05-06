using MobilShop.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace MobilShop
{
    public partial class Shop : Form
    {
        Model_Db_Others model;
        static public List<string> bay_mobile;
        public Shop()
        {
            InitializeComponent();
            model = new Model_Db_Others();
            bay_mobile = new List<string>();
            AddProducts(this,"All");
        }
        private void Bay_button_Click(object sender, EventArgs e) { AddProducts(this, "My"); }
        private void All_button_Click(object sender, EventArgs e) { AddProducts(this,"All"); }
        private void Apple_button_Click(object sender, EventArgs e) { AddProducts(this,"Apple"); }
        private void Sumsung_button_Click(object sender, EventArgs e) { AddProducts(this,"Samsung"); }
        private void find_button_Click(object sender, EventArgs e) { AddProducts(this, search_textBox.Text, true); }
        private void userButton_Click(object sender, EventArgs e)
        {
            Sign_In_Up signForm = new Sign_In_Up();
            signForm.ShowDialog();
        }
        public static void AddProducts(Shop shop, string _company, bool search = false)
        {
            shop.Bay_button.Text = bay_mobile.Count.ToString();
            shop.panel2.Controls.Clear();
            int x = 5, y = 5;
            foreach (var item in shop.model.Mobiles)
            {
                if (_company == "All")
                {
                    shop.panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                else if (_company == "Apple" && _company == item.Company)
                {
                    shop.panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                else if (_company == "Samsung" && _company == item.Company)
                {
                    shop.panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                    x += 220;
                }
                else if (_company == "My")
                {
                    foreach (var name_ in bay_mobile)
                    {
                        if (name_ == item.Name)
                        {
                            shop.panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price, false) { Location = new Point(x, y), });
                            x += 220;
                        }
                    }
                }
                else if (search)
                {
                    if (_company.ToLower() == item.Name.ToLower() || _company.ToLower() == item.Company.ToLower())
                    {
                        shop.panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y), });
                        x += 220;
                    }
                }
                if (x / 200 >= 3)
                {
                    y += 230;
                    x = 5;
                }
            }
        }
    }
}