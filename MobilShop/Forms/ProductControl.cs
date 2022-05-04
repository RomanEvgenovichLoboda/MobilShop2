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
    public partial class ProductControl : UserControl
    {
        Image [] images;
        public ProductControl(int _id, string _name, string _company, int _flash, int _SSD, int _processor, double _price)
        {
            images = new Image[] { new Bitmap(Properties.Resources._1), new Bitmap(Properties.Resources._2), new Bitmap(Properties.Resources._3), new Bitmap(Properties.Resources._4) };
            InitializeComponent();
            name_label.Text = _name;
            company_label.Text = _company;
            flash_label.Text = Convert.ToString(_flash);
            ssd_label.Text = Convert.ToString(_SSD);
            processor_label.Text = Convert.ToString(_processor);
            price_label.Text = Convert.ToString(_price);
            pictureBox1.Image = images[_id - 1];
        }
    }
}
