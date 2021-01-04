using System;

namespace ProjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            Console.WriteLine("What is your fullname?");

            string userName = Console.ReadLine();
            string allLower = userName.ToLower();
            string allTrim = allLower.Trim();
            Console.WriteLine(allTrim);

            string allUpper = userName.ToUpper();
            string allTrim2 = allUpper.Trim();
            Console.WriteLine(allTrim2);

            string name = userName.Trim();
            Console.WriteLine(name);
            Console.WriteLine(name.IndexOf(' '));
            Console.WriteLine(name.LastIndexOf(' '));
            Console.WriteLine("");

            //Exercise Two
            Console.WriteLine("What is your SSN?");

            string userSSN = Console.ReadLine();
            string userSSN1 = userSSN.Replace("-", string.Empty);
            string firstThree = userSSN1.Substring(0, 3);
            Console.WriteLine(firstThree);

            string lastFour = userSSN1.Substring(5, 4);
            Console.WriteLine(lastFour);

            string display = userSSN1.Substring(0, 5);
            string displaySSN = userSSN1.Replace(display, "*****");
            Console.WriteLine(displaySSN);
            Console.WriteLine("");

            //Exercise Three
            Console.WriteLine("Please provide a phrase so that we can help you create your new password");
            string newPhrase = Console.ReadLine();
            string newPassword = newPhrase.Replace(" " , string.Empty);
            newPassword = newPassword.Replace("a", "2").Replace("A" , "2");
            newPassword = newPassword.Replace("o", "0").Replace("O", "0");
            newPassword = newPassword.Replace("i", "!").Replace("I", "!");

            Console.WriteLine("Enter any number greater than 9");
            string newNum = Console.ReadLine();
            newPassword += newNum.Substring(0, 1);
            newPassword = newNum.Substring(newNum.Length - 1, 1) + newPassword;

            string finalPassword = $"Hello! Your original phrase is: {newPhrase} Your number is: {newNum} and your new Password is: {newPassword}";

            Console.WriteLine(finalPassword);


        }
    }
}
