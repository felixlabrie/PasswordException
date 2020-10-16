using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your password: ");
            string pass = Console.ReadLine();

            try
            {

                validatePass(pass);
            }
            catch (PasswordException pwe)
            {
                Console.WriteLine("A password error occurred.");
                Console.WriteLine(pwe.Message);
                Console.WriteLine(pwe.PasswordRuleIssue);
                Console.WriteLine("Strength: " + pwe.Strength);
            }
            finally
            {
                Console.WriteLine("The access code is ABCDE123");
            }
        }

        static bool validatePass(string password)
        {
            if (password.Length < 8)
            {
                var pe = new PasswordException("A password issue occurred", "Length was too short", 3);
                throw pe;
            }

            return true;
        }
    }
}
