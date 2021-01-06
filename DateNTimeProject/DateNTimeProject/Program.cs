using System;

namespace DateNTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("What month were you born?");
            int userMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What year were you born?");
            int userYear = int.Parse(Console.ReadLine());

            Console.WriteLine("What date were you born?");
            int userDate = int.Parse(Console.ReadLine());

            DateTime userBirthday = new DateTime(userYear, userMonth, userDate);

            Console.WriteLine("What is your father's date of birth in (MM/DD/YYYY)");
            DateTime fatherBirthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Your birthdate is {userBirthday.ToLongDateString()}");
            Console.WriteLine($"Your father's birthdate is {fatherBirthday.ToLongDateString()}");
            Console.WriteLine("");

            //Exercise Two
            DateTime currentDate = DateTime.Today;
            DateTime currentTime = DateTime.Now;

            Console.WriteLine("Hello");
            Console.WriteLine($"Current Date is {currentDate.ToLongDateString()}");
            Console.WriteLine($"Current Time is {currentTime.ToShortTimeString()}");
            Console.WriteLine($"Please enter an Integer");

            int newDate = int.Parse(Console.ReadLine());
            DateTime newDate1 = currentDate.AddDays(newDate);

            Console.WriteLine($"The new day is a {newDate1.DayOfWeek}");
            Console.WriteLine($"The new month is {newDate1.Month}");
            Console.WriteLine($"The new date is {newDate1.Date.ToShortDateString()}");
            Console.WriteLine($"The new year is {newDate1.Year}");
            Console.WriteLine("");

            //Exercise Three
            TimeSpan ticks = userBirthday - fatherBirthday;
            int yearsDifference = ticks.Days / 365;
            Console.WriteLine($"The age difference between user and father is {yearsDifference}");

            DateTime nextBirthday = new DateTime(currentDate.Year + 1, userMonth, userDate);
            ticks = nextBirthday - currentDate;
            double hours = ticks.TotalHours;

            Console.WriteLine($"The number of hours until user's birthday is {hours}");

            



        }
    }
}
