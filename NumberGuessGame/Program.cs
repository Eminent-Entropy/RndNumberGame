using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    class Program
    {

        static void Game()
        {
            try
            {
                Random rnd = new Random();
                int Num = rnd.Next(101);//generates random number betwen 0 and 100
                bool correct = false;
                int guess;

                Console.WriteLine("Guess a number from 0-100: ");

                while (correct == false)//if user's guess is wrong it loops
                {
                    guess = Convert.ToInt32(Console.ReadLine());//gets user's guess
                    if (guess == Num)//if user is correct
                    {
                        Console.WriteLine("Correct! \n");
                        correct = true;
                    }
                    else if (guess < Num)//if user is wrong and number is higher
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > Num)//if user is wrong and number is lower
                    {
                        Console.WriteLine("Lower");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please type a number \n");//if user didn't type a number
            } 
        }


        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)//loops id user didn't type exit
            {
                Console.WriteLine("Type start to start a new game or exit to exit the program: \n");
                string UserInput = Console.ReadLine();

                if (String.Compare(UserInput, "start") == 0)//if user typed start
                {
                    Console.Clear();
                    Game();
                    Console.WriteLine("Click any key to continue:");
                    Console.ReadKey();//so user sees what the program says
                    Console.Clear();
                }
                else if(String.Compare(UserInput, "exit") == 0)//if user type exit
                {
                    exit = true;//stops loop and finishes the program
                }
                else//if user didn't type start or exit
                {
                    Console.WriteLine("type start or exit \n");
                }
            }
        }
    }
}