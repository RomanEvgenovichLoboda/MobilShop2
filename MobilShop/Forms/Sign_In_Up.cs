using MobilShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilShop.Forms
{
    public partial class Sign_In_Up : Form
    {
        public Sign_In_Up()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(emailBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                if (emailBox.Text == "" || passwordBox.Text == "") { MessageBox.Show("Empty Line =("); }
                else
                {
                    Registration reg = new Registration();
                    reg.signIn(emailBox.Text, passwordBox.Text);
                    this.Close();
                }
            }
            else { MessageBox.Show("Wrong email format"); }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(emailBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                if (emailBox.Text == "" || passwordBox.Text == "") { MessageBox.Show("Empty Line =("); }
                else
                {
                    Registration reg = new Registration();
                    reg.Regestration(emailBox.Text, passwordBox.Text);
                    this.Close();
                }
            }
            else { MessageBox.Show("Wrong email format"); }
        }
    }
}
