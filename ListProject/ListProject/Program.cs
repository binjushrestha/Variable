using System;
using System.Collections.Generic;
using System.Linq;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            List<string> guestList = new List<string>()
            {
                "Sam",
                "Samantha",
                "Angela",
                "Alexa",
                "Annie"
            };
            for(int i = 0; i < guestList.Count; i++)
            {
                if (i < guestList.Count)
                {
                    Console.WriteLine($"Hi {guestList[i]}. You are invited to my party on Friday.");
                }
            }
            Console.WriteLine("");  
            
            //Exercise Two
            for (int j = 1; j < 6; j++)
            {
                Console.WriteLine($"Add more guest no.{j}");
                string newGuest = Console.ReadLine();

                guestList.Add(newGuest);
            }

            Console.WriteLine("The new guestlist is " + String.Join(" , ",guestList));

            for(int k = 1; k < 3; k++)
            {
                Console.WriteLine($"The guestlist is too long. Choose guests no.{k}  you would like to uninvite");
                string guestUninvite = Console.ReadLine().Trim();

                guestList.Remove(guestUninvite);
            }

            Console.WriteLine("The new guestlist is " + String.Join(" , ", guestList));
            Console.WriteLine("");

            //Exercise Three
            int halfGuestList = guestList.Count / 2;
            List<string> waitList = new List<string>();
            while(guestList.Count > halfGuestList)
            {
                int waitIndex = guestList.Count - 1;
                waitList.Add(guestList[waitIndex]);
                guestList.RemoveAt(waitIndex);
            }
           
            for (int i = 0; i < waitList.Count; i++)
            {
                Console.WriteLine($"Hi {waitList[i]} Sorry to inform you but you have been placed in a waitlist for the party" +
                    $" There are total of {{{waitList.Count}}} and you are no.{i + 1} in the waiting list");
                Console.WriteLine("");
            }

            //Exercise Four
            List<double> guestGifts = new List<double>();
            for(int guestIndex = 0; guestIndex < 4; guestIndex++)
            {
                Console.WriteLine("How much are you going to give me at the party?");
                double totalSum =double.Parse(Console.ReadLine());

                guestGifts.Add(totalSum);


            }
            double totalGift = guestGifts.Sum();
            Console.WriteLine($"I will receive a total of {totalGift}");


            

        }
    }
}
