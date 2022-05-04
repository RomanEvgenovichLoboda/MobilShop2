
namespace MobilShop.Classes
{
    class Crypt
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword(pass);
        }
        public bool veryfy(string pass, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(pass, hash);
        }
    }
}
