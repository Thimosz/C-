using System;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            
            Console.WriteLine("Wich amount of cents would you like to convert to coins?: ");
            string amount = Console.ReadLine();
            double amountDouble = Math.Floor(Convert.ToDouble(amount));
            Console.WriteLine(" ");
            Console.WriteLine($"{amountDouble} cents is equal to...");
            Console.WriteLine(" ");

            int gold = 10;
            int silver = 5;

            double goldCoins = Math.Floor(amountDouble / gold);
            double leftOver = amountDouble % gold;

            double silverCoins = Math.Floor(leftOver / silver);
            leftOver = leftOver % silver;           
          
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {leftOver}");

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            
        }
    }
}
