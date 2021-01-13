using System;

namespace LoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            bool isValidInput = false;
            do
            {
                Console.WriteLine("How old are you?");
                int userAge;
                bool isNumber = int.TryParse(Console.ReadLine(), out userAge);
                if (isNumber == false)
                {
                    Console.WriteLine("You have entered an invalid number.");
                }
                else if (userAge < 3 || userAge > 150)
                {
                    Console.WriteLine("Please enter your age correctly");
                }
                else
                {
                    isValidInput = true;
                }
            }
            while (isValidInput == false);
            Console.WriteLine("");

            //Exercise Two
            string Pass = "PassworD";
            bool correctPass = false;
            do
            {
                Console.WriteLine("Please enter the password");
                string userPass = Console.ReadLine();
                if (userPass == Pass)
                {
                    Console.WriteLine("Correct Password");
                    correctPass = true;
                }         
                else
                {
                    Console.WriteLine("Please try again");
                    
                }
            }
            while (correctPass == false);
            Console.WriteLine("");

            //Exercise Three
            bool validInput = false; 
            do
            {
                
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine().Trim();
                 
                if (string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("Please enter you valid name");
                }
                else
                {
                    Console.WriteLine($"Hi {userName}. Nice to meet you");
                    validInput = true;
                }
            }
            while(validInput == false);
            Console.WriteLine("");

        }
    }
}
