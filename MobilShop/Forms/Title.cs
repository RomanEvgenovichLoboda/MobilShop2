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
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Sign_In_Up signForm = new Sign_In_Up();
            signForm.ShowDialog();
            userButton.Text = "IN";
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            //int x = 5, y = 100;

            //foreach (var item in model.Mobiles)
            //{
            //    Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
            //    x += 220;
            //    if(x/200 >= 3) 
            //    {
            //        y += 230;
            //        x = 5;
            //    }
            //}
            AddProducts();
        }
        private void AddProducts()
        {
            int x = 5, y = 5;

            foreach (var item in model.Mobiles)
            {
                panel2.Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                //Controls.Add(new ProductControl(item.Id, item.Name, item.Company, item.Flash, item.SSD, item.Processor, item.Price) { Location = new Point(x, y) });
                x += 220;
                if (x / 200 >= 3)
                {
                    y += 230;
                    x = 5;
                }
            }
        }
        private void RemoveProducts()
        {
            foreach (var item in model.Mobiles)
            {
                panel2.Controls.Clear();
                //Controls.Remove()
            }
        }
    }
}
