using System;

namespace SwitchCaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("Would you like to play a game? (Yes/No)");
            string userGame = Console.ReadLine().Trim().ToLower();
            
                switch (userGame)
                {
                    case "yes":
                    Console.WriteLine("YAY! Let's play Candyland!");
                        break;

                    case "no":
                    Console.WriteLine("It looks like more solitaire for me.");
                        break;
                    default:
                        Console.WriteLine("I'm going to take that as a yes and set up the Candlyland board.");
                        break;
                }
            Console.WriteLine("");

            //Exercise Two
            Console.WriteLine("What is you favorite programming language?");
            string userProgram = Console.ReadLine().Trim().ToLower();

                switch (userProgram)
                {
                    case "c#":
                        Console.WriteLine("Excellent choice!");
                        break;

                    case "java":
                    case "python":
                        Console.WriteLine("You can do better than that.");
                        break;

                    case "html":
                    case "css":
                        Console.WriteLine("Those are not programming languages.");
                        break;

                    case "javascript":
                        Console.WriteLine("I have nothing to say to you.");
                        break;

                    default:
                        Console.WriteLine("I have no experience with that language.");
                        break;
                }
            Console.WriteLine("");

            //Exercise Three
            Console.WriteLine("What is your favorite sport in school?");
            string userFav = Console.ReadLine().Trim().ToLower();
            

            switch (userFav)
            {
                case "math":
                    Console.WriteLine("What is the square root of 144?");
                    int userAnswer = int.Parse(Console.ReadLine());

                    if(userAnswer == 12)
                    {
                        Console.WriteLine("Congratulations!!");
                    }
                    else
                    {
                        Console.WriteLine("You should probably go back to school");
                    }
                    break;

                case "english":
                    Console.WriteLine("True/False – This sentences are demonstrating gooder grammar");
                    string userEng = Console.ReadLine().Trim().ToLower();

                    if (userEng == "false")
                    {
                        Console.WriteLine("Congratulations!!");
                    }
                    else
                    {
                        Console.WriteLine("You should probably go back to school");
                    }
                    break;

                case "science":
                    Console.WriteLine("Is Pluto a planet or a moon?");
                    string userSci = Console.ReadLine().Trim().ToLower();

                    if (userSci == "planet")
                    {
                        Console.WriteLine("Congratulations!!");
                    }
                    else
                    {
                        Console.WriteLine("You should probably go back to school");
                    }
                    break;
                case "gym":
                    Console.WriteLine("How many burpees can you do?");
                    int userGym = int.Parse(Console.ReadLine().Trim().ToLower());

                    if (userGym >= 0)
                    {
                        Console.WriteLine("Nice");
                    }
                    else
                    {
                        Console.WriteLine("Really?");
                    }
                    break;
                default:
                    Console.WriteLine("I have no further questions");
                    break;
            }
            Console.WriteLine("");
        }
    }
}
