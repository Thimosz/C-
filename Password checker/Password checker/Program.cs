using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 10;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_-=+";

            Console.WriteLine("Please type your password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("the password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("strong");
                    break;
                case 2:
                    Console.WriteLine("medium");
                    break;
                case 1:
                    Console.WriteLine("weak");
                    break;
                default:
                    Console.WriteLine("The password doesn't meet any of our standards");
                    break;
            }

            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}
