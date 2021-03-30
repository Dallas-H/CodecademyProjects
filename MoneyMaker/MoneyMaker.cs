using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Variables 
            double quater = 25;
            double quatersLeftover;
            double totalQuaters;
            double dimes = 10;
            double totalDimes;
            double dimesLeftOver;
            double nickels = 5;
            double totalNickels;
            double totalPennies;

            string amountToConvert;
            double amountToDouble;

            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount: (Under 100)");
            
            amountToConvert = Console.ReadLine();
            amountToDouble = Math.Floor(Convert.ToDouble(amountToConvert));

            Console.WriteLine();
            Console.WriteLine($"{amountToConvert} cents is equal to ...");
            Console.WriteLine();

            totalQuaters = Math.Floor(amountToDouble / quater);
            quatersLeftover = amountToDouble % quater;

            totalDimes = Math.Floor(quatersLeftover / dimes);
            dimesLeftOver = amountToDouble % dimes;

            totalNickels = Math.Floor(dimesLeftOver / nickels);
            totalPennies = dimesLeftOver % nickels;

            //Output
            Console.WriteLine($"Quaters coins: {totalQuaters}");
            Console.WriteLine($"Dimes coins: {totalDimes}");
            Console.WriteLine($"Nickles coins: {totalNickels}");
            Console.WriteLine($"Pennies coins: {totalPennies}");







        }
    }
}
