using System;
using System.Threading;

namespace ForLoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("How many minutes do you wish to workout?");
            int userMin = int.Parse(Console.ReadLine());

            Console.WriteLine("How often would you like to be reminded to drink water?");
            int userWater = int.Parse(Console.ReadLine());
            int timeInterval = userMin - userWater;

            for (int i = userMin; i > 0; i--)
            {
                Console.WriteLine($"It's been {i} since you worked out");
                Thread.Sleep(1000);
                if(i == timeInterval)
                {                   
                    Console.WriteLine("Time to drink water");
                    timeInterval = i - userWater;
                }

            }
            Console.WriteLine("You are done working out");
            Console.WriteLine("");

            //Exercise Two
            string userName = "Binju";

            Console.WriteLine("How many siblings do you have?");
            int userSiblingNum = int.Parse(Console.ReadLine());

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            for(int i = userSiblingNum; i > 0; i--)
            {
                Console.WriteLine("What is you siblings name?");
                string userSiblingName = Console.ReadLine();

                Console.WriteLine("How old is your sibling?");
                int userSiblingAge = int.Parse(Console.ReadLine());

                if(userAge > userSiblingAge)
                {
                    Console.WriteLine($"{userName} is the oldest");
                }
                else
                {
                    Console.WriteLine($"{userSiblingName} is the oldest sibling");
                }
            }
            Console.WriteLine("");

            //Exercise Three
            int totalPrice = 0;
            Console.WriteLine("How many people are you buying gifts for this holiday?");
            int userGift = int.Parse(Console.ReadLine());

            for(int i = userGift; i > 0; i--)
            {
                Console.WriteLine("How many gifts are you buying for this person?");
                int userGiftNum = int.Parse(Console.ReadLine());

                for(int j = userGiftNum; j > 0; j--)
                {
                    Console.WriteLine("How much did you spend on this gift?");
                    int userGiftPrice = int.Parse(Console.ReadLine());

                    if (userGiftPrice > 0)
                    {
                        totalPrice = totalPrice + userGiftPrice;
                        Console.WriteLine($"You spent ${totalPrice} this holiday");
                    }
                    else
                    {
                        Console.WriteLine("Your gift to this person was a gift of holiday spirit. Nice");
                    }
                }
            }
        }
    }
}
