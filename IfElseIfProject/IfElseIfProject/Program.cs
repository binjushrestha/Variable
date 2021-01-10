using System;

namespace IfElseIfProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            string pass = "HelloworlD";

            Console.WriteLine("Enter the password");
            string userPass = Console.ReadLine();

            if(userPass == pass)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            Console.WriteLine("");

            //Exercise Two
            Console.WriteLine("Please Enter Your Birth Month");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Birth day");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime Current = DateTime.Now;

            DateTime birthDate = new DateTime(Current.Year, birthMonth, birthDay);
            int dayLeft;
            if (birthDate < Current)
            {
                dayLeft = (Current - birthDate).Days;
                Console.WriteLine($"Your birthday was {dayLeft} ago.");
            }
            else if(birthDate > Current){
                dayLeft = (birthDate - Current).Days;
                Console.WriteLine($"Your birthday is in {dayLeft}.");
            }
            else if(birthDate.Date == Current.Date)
            {
                Console.WriteLine("Happy Birthday!!!");
            }
            Console.WriteLine("");

            //Exercise Three
            Console.WriteLine("Please Enter your age");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your bestfriends age");
            int friendAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your sibling or cousin age");
            int familyAge = int.Parse(Console.ReadLine());

            if (userAge > friendAge || userAge > familyAge)
            {
                Console.WriteLine("You are older than atleast one person");

            }
            else if (userAge < friendAge || userAge < familyAge)
            {
                Console.WriteLine("You are younger than atleast one person");
            }
            else if((userAge < friendAge && userAge > familyAge)|| (userAge < familyAge && userAge > friendAge))
            {
                Console.WriteLine("How do you like being in the middle?");
            }
            else
            {
                Console.WriteLine("You guys are about the same age");
            }
            Console.WriteLine("");

            //Exercise Four
            Console.WriteLine("Are you in school (Yes/No)");
            string answer = Console.ReadLine().Trim();

            if (answer.Equals("yes", StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine("What grade are you in?");
                int grade = int.Parse(Console.ReadLine());

                if (grade > 1 || grade < 12)
                {
                    if (grade < 9)
                    {
                        Console.WriteLine("I hope you are studying hard.");
                    }
                    else if (grade > 9 || grade < 13)
                    {
                        Console.WriteLine("Do you plan on going to college? (Yes/No)");
                        string userCollege = Console.ReadLine();

                        if (userCollege.Equals("yes", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            Console.WriteLine("You have made a right decison");
                        }
                        else
                        {
                            Console.WriteLine("You should reconsider your decision");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Good Luck with that");
                    }
                }
                else
                {
                    Console.WriteLine("Good Luck with that");
                }
                Console.WriteLine("");
            
            }

        }
    }
}
