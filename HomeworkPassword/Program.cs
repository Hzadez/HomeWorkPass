using System.Text.RegularExpressions;

namespace HomeworkPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Şifrəni daxil edin: "); 
            string password = Console.ReadLine(); 

            bool isValid = Password(password); 
            if (isValid)
            {
                Console.WriteLine("Şifrə düzgündür.");
            }
            else
            {
                Console.WriteLine("Şifrə düzgün deyil. Şifrə aşağıdakı şərtləri ödəməlidir:");
                Console.WriteLine(" * Minimum 8 simvol");
                Console.WriteLine(" * Böyük hərflə başlamalıdır");
                Console.WriteLine(" * Minimum 1 rəqəm olmalıdır");
                Console.WriteLine(" * Minimum 1 xüsusi karakter olmalıdır");
            }
            static bool Password(string password)
            {
                
                if (password.Length < 8)
                    return false;

                
                if (!char.IsUpper(password[0]))
                    return false;

                
                if (!password.Any(char.IsDigit))
                    return false;

               
                if (!password.Any(x => !char.IsLetterOrDigit(x))) 
                    return false;

                return true;
            }
        }


    }
}

