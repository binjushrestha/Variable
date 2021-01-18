using System;

namespace ArraysProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise One
            string[] friendsName = new string[3];
            friendsName[0] = "Angela";
            friendsName[1] = "Alexa";
            friendsName[2] = "Puja";

            for(int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"Hi {friendsName[i]}. Nice to meet you.");
                Console.WriteLine("It's been a long time");
                Console.WriteLine("");
            }

            //Exercise Two
            string[] lunchBuddy = new string[]
                {"Angela","Alexa","Puja","Tom","Jerry","Masha","Bi","Den" };

            int j = 0 ;
            bool isValidInput = false;
            while (isValidInput == false)
            {
                if (j < lunchBuddy.Length)
                {
                    
                    Console.WriteLine($"Hey {lunchBuddy[j]}. You are invited to seat at the lunch table with me. Congrats");
                    j++;

                }
                else
                {
                    isValidInput = true;
                }
            }
            Console.WriteLine("");

            //Exercise Three
            int[] testScores = new int[10];
            int k = 0;
            

            for (int i = 0; i < testScores.Length; i++)
            {
                Console.WriteLine("Enter your test scores");
                int userScore = int.Parse(Console.ReadLine());
            
                testScores[i] = userScore;

                if (i == 9)
                {
                    k = (testScores[0] + testScores[1] + testScores[2] + testScores[3] + testScores[4] + testScores[5] + testScores[6] + testScores[7] + testScores[8] + testScores[9]) / 10;
                    Console.WriteLine($"Your average testscore is {k}");

                        if (k < 80)
                        {
                            Console.WriteLine("You are so Grounded.");
                        }
                        else
                        {

                            Console.WriteLine("Congrats on getting good grades. You are Free!!!");
                            
                        }
                    

                }
                
                
                
            }
            


            
        }
    }
}
