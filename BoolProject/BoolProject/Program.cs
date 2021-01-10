using System;

namespace BoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("Please Enter Your Birth Month");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Birth day");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime Current = DateTime.Now;

            DateTime birthDate = new DateTime(Current.Year, birthMonth, birthDay);

            bool presentBirthday = birthDate < Current;

            Console.WriteLine($"The answer to if you have had your birthday this year is {presentBirthday} ");
            Console.WriteLine("");

            //Exercise Two
            Console.WriteLine("Enter your first name");
            string userFirst = Console.ReadLine();

            Console.WriteLine("Enter your Father's name");
            string userFather = Console.ReadLine();

            userFirst = userFirst.Trim();
            userFather = userFather.Trim();

            bool nameCompare = userFirst.Equals(userFather, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"The fact that the user has the same name as their father is {nameCompare}");
            Console.WriteLine("");

            //Exercise Three
            int binjuAge = 26;

            Console.WriteLine("Please enter your age");
            int userAge = int.Parse(Console.ReadLine());

            bool olderAge = binjuAge < userAge;

            Console.WriteLine($"The fact that Binju is younger than the user is {olderAge}");
            Console.WriteLine("");

            //Exercise Four
            string pass = "JellyFish";

            Console.WriteLine("Enter the password");
            string userPass = Console.ReadLine();

            userPass = userPass.Trim();

            bool correctPass = pass == userPass;

            Console.WriteLine($"The password you have entered is {correctPass}");
            Console.WriteLine("");







        }
    }
}
