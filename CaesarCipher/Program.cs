using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptMessage = "hello";
            string decryptMessage = "khoor";

            Console.WriteLine(Encrypt(encryptMessage, 3));
            Console.WriteLine(Decrypt(decryptMessage, 3));
            
        }
        static string Encrypt(string message, int key)
        {
            //Variables
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //string messege;
            char[] secertMessage;
            char[] encryptedMessage;
            string convertedMessage;

            //Console.WriteLine("Enter secert message: ");
            //messege = Console.ReadLine().ToLower();

            message.ToLower();
            secertMessage = message.ToCharArray();
            encryptedMessage = new char[secertMessage.Length];

            for (int i = 0; i < secertMessage.Length; i++)
            {
                char startLetter = secertMessage[i];
                if (Char.IsLetter(startLetter))
                {
                    int positionEndLetter = (Array.IndexOf(alphabet, startLetter) + key) % alphabet.Length;
                    char endLetter = alphabet[positionEndLetter];
                    encryptedMessage[i] = endLetter;
                }
                else
                {
                    encryptedMessage[i] = startLetter;
                }
            }
            return convertedMessage = String.Join("", encryptedMessage);
        }
        
        static string Decrypt(string message, int key)
        {
            //Variables
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //string messege;
            char[] secertMessage;
            char[] encryptedMessage;
            string convertedMessage;

            //Console.WriteLine("Enter secert message: ");
            //messege = Console.ReadLine().ToLower();

            message.ToLower();
            secertMessage = message.ToCharArray();
            encryptedMessage = new char[secertMessage.Length];

            for (int i = 0; i < secertMessage.Length; i++)
            {
                char startLetter = secertMessage[i];
                if (Char.IsLetter(startLetter))
                {
                    int positionEndLetter = (Array.IndexOf(alphabet, startLetter) - key) % alphabet.Length;
                    char endLetter = alphabet[positionEndLetter];
                    encryptedMessage[i] = endLetter;
                }
                else
                {
                    encryptedMessage[i] = startLetter;
                }
            }
            return convertedMessage = String.Join("", encryptedMessage);
        }
       
    }
}