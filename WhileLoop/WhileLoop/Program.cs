using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSoda = 30;
            int newSoda = 0;
            bool quitSoda = false;

            while (quitSoda == false)
            {
                Console.WriteLine("How many soda would you like to drink?");
                int daySoda = int.Parse(Console.ReadLine());

                if (daySoda < numSoda)
                {
                    newSoda = numSoda - daySoda;
                    numSoda = numSoda - daySoda;
                    Console.WriteLine($"You have {newSoda} left");
                }
                else
                {
                    Console.WriteLine("No more Soda left. Sorry");
                    quitSoda = true;
                }
            }
            while (quitSoda == false);
            Console.WriteLine("");

            //Exercise Two
            string name = "binju";
            int userTries = 10;
            bool isValidInput = false;

            while (isValidInput == false)            
            {
                Console.WriteLine("Guess my name");
                string userGuess = Console.ReadLine().Trim().ToLower();

                if (userGuess != name)
                {
                    userTries = userTries - 1;
                    Console.WriteLine("Please try again.");
                    Console.WriteLine($"You have {userTries} left");
                }
                else if (userTries <= 0)
                {
                    Console.WriteLine("Sorry you have no more tries left");
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Congrats. You guessed it right");
                    isValidInput = true;
                }
                
            }
            while (isValidInput == false);
            Console.WriteLine("");

            //Exercsie Three
            Random random = new Random();
            int number = random.Next(0, 101);
            bool validNumber = false;

            
            while (validNumber == false)
            {
                Console.WriteLine("Guess a number from 1 to 10");
                int userGuessNum = int.Parse(Console.ReadLine());

                if (userGuessNum != number)
                {
                    Console.WriteLine("You guessed it wrong. Try again");
                }
                else
                {
                    Console.WriteLine("You guessed it right. Congrats!");
                    validNumber = true;
                }

                Console.WriteLine("Would you like to continue?");
                string userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "n":
                    case "no":
                    case "No":
                        validNumber = true;
                        break;
                }
            }
            while (validNumber == false);
            Console.WriteLine("");

        }
    }
}
