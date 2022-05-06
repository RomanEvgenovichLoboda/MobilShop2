using System;
using System.Windows.Forms;

namespace MobilShop
{
   static public class Program
    {
       static public Shop SP;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SP = new Shop();
            Application.Run(SP);
        }
    }
}