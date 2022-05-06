﻿using System;
using System.Drawing;
using System.Windows.Forms;
namespace MobilShop
{
    public partial class ProductControl : UserControl
    {
        Image [] images;
        public ProductControl(int _id, string _name, string _company, int _flash, int _SSD, int _processor, double _price, bool _My = true)
        {
            images = new Image[] { new Bitmap(Properties.Resources._1), new Bitmap(Properties.Resources._2), new Bitmap(Properties.Resources._3), new Bitmap(Properties.Resources._4), new Bitmap(Properties.Resources._5), new Bitmap(Properties.Resources._6) };
            InitializeComponent();
            name_label.Text = _name;
            company_label.Text = _company;
            flash_label.Text = $"{_flash.ToString()} Gb";
            ssd_label.Text = $"{_SSD.ToString()} Gb";
            processor_label.Text = $"{ _processor.ToString()} Core";
            price_label.Text = $"{_price.ToString()} ₴";
            pictureBox1.Image = images[_id - 1];
            if(!_My)
            {
                button1.Text = "X";
                button1.ForeColor = Color.Red;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "X")
            {
                Parent.Controls.Remove(this); 
                Shop.bay_mobile.Remove(name_label.Text);
                Shop.AddProducts(Program.SP, "My");
            }
            else Shop.bay_mobile.Add(name_label.Text);
        }
    }
}