

namespace RegistrationValidation.Controller
{
    public class TextCrypt
    {
         public string Generate(string pass)
        {
           return BCrypt.Net.BCrypt.HashPassword(pass);
        }
    }
}
