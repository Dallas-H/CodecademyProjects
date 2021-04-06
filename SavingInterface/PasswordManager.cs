using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IRestable
    {
        //Fields

        //Properties
        private string Password
        {
            get; set;
        }
        public bool Hidden
        { get; private set; }

        //Constructors
        public PasswordManager(string password, bool hidden)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be 8 characters long");
            }
            else
            {
                Password = password;

            }
            Hidden = hidden;
        }

        //Methods
        public bool ChangePassword(string password, string newPassword)
        {
            if (password == Password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("Unsuccessful change");
                return false;
            }
        }

        //Interface
        public void Display()
        {
            Console.WriteLine();
            if (Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
        public void Reset()
        {
            Password = " ";
            Hidden = false;
        }
    }
}