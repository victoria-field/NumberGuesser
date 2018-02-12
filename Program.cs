using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

           

            while (true) {

                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;

                Console.WriteLine("guess a number between 1 and 10");

                while (guess != correctNumber) {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess)) {
                        //error
                        PrintColorMessage(ConsoleColor.Red, "that is not a number");

                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctNumber) {

                        PrintColorMessage(ConsoleColor.Red, "That is the wrong number try again");

                    
                    }

                }

                PrintColorMessage(ConsoleColor.Yellow, "That is right number");
               

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                
                if(answer == "Y")
                {
                    continue;
                }else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }


        }

        static void GetAppInfo()
        {
            string appName = "number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "V Field";

            //Start here
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : version {1} and it is written by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a game", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
