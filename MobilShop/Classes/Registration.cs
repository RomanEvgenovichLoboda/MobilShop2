using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilShop.Classes
{
    class Registration
    {
        public void Regestration(string _email, string _pass)
        {
            string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                User regestration = new User() { email = _email, password = new Crypt().Generate(_pass) };
                connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
            }
        }
        public void signIn(string _email, string _pass)
        {
            List<User> usList = GetUsers();
            foreach (var item in usList)
            {
                if (item.email == _email && new Crypt().veryfy(_pass, item.password) == true)
                    MessageBox.Show("Autorisated =)");
            }
        }
        public List<User> GetUsers()
        {
            string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<User>($"SELECT * FROM [Users] ").ToList();
            }
        }
    }
}
