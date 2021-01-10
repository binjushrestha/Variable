using System;

namespace TernaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exaercise One
            string movieToWatch = "";
            bool likesSuperHeroes = true;
   
            movieToWatch = likesSuperHeroes ? movieToWatch = "Avengers" : movieToWatch = "Harry Potter";
            Console.WriteLine("");

            //Exercise Two
            int customerAge = 14;
            string drinkToServe = "";

            drinkToServe = customerAge < 21 ? drinkToServe = "Soda" : drinkToServe = "Beer";
            Console.WriteLine("");

            //Exercise Three
            string name = "Scott";
            int salary = 25000;
            int payCheckAmount = 0;

            payCheckAmount = name == "Scott" ? salary / 2 : salary * 5;


        }
    }
}
