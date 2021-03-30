using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variables
            int minLength = 3;
            bool uppercase;
            bool lowercase;
            bool digits;
            bool specialChars;
            
            int score;
            string password;

            Console.WriteLine("Enter a Password: ");
            password = Console.ReadLine();

            score = 0;

            if (password.Length>= minLength)
            {
                score++;
            }

            if (Tools.Contains(password,"ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
            {
                score++;
            }

            if (Tools.Contains(password, "abcdefghijklmnopqurtuvwxyz"))
            {
                score++;
            }
            if (Tools.Contains(password, "1234567890"))
            {
                score++;
            }
            if (Tools.Contains(password, "!@#$%^&*"))
            {
                score++;
            }
            Console.WriteLine(score);


            switch (score)
            {
                case 5:
                    Console.WriteLine("Password is extremely strong!");
                        break;
                case 4:
                    Console.WriteLine("Password is extremely strong!");
                    break;
                case 3:
                    Console.WriteLine("Password is strong");
                    break;
                case 2:
                    Console.WriteLine("Password is medium!");
                    break;
                case 1:
                    Console.WriteLine("Password is week");
                    break;
                default:
                    break;
            }


        }
    }
}
