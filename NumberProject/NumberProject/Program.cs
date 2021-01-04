using System;

namespace NumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("Enter a Integer value");
            string a = Console.ReadLine();

            Console.WriteLine("Enter another Integer value");
            string b = Console.ReadLine();

            int num1 = int.Parse(a);
            int num2 = int.Parse(b);

            Console.WriteLine($"{num1} plus {num2} equals {num1 + num2}");
            Console.WriteLine($"{num1} minus {num2} equals {num1 - num2}");
            Console.WriteLine($"{num1} multiplied by {num2} equals {num1 * num2}");
            Console.WriteLine($"{num1} divided by {num2} equals {(double)num1 / (double)num2}");
            Console.WriteLine("");

            //Exercise Two
            Console.WriteLine("Please enter your age");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your father's age");
            int fatherAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your mother's age");
            int motherAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"The difference between you and your father's age is {fatherAge - userAge}");
            Console.WriteLine($"The difference between you and your mothers's age is {motherAge - userAge}");
            Console.WriteLine("");

            //Exercise Three
            Console.WriteLine("Please provide your hourly wage");
            double userWage = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide your weekly hours");
            double userHour = double.Parse(Console.ReadLine());

            Console.WriteLine("How many weeks of unpaid vacation they take every year?");
            double userUnpaid = double.Parse(Console.ReadLine());
            userUnpaid *= (userWage * userHour);

            double weekWage = userWage * userHour;
            double yearWage = weekWage * 52;
            double totalWage = yearWage - userUnpaid;
            string total = string.Format("{0:C}",totalWage);
            Console.WriteLine($"Your annual income is: {total}");



        }
    }
}
