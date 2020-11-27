using System;

namespace NumberWizardv4
{
    public static class Util
    {
        private static Random rnd = new Random();
        public static int GetRandom()
        {
            return rnd.Next(1, 1000);
        }
    }
    class Program
    {
        int maxGuess;
        int minGuess;
        int guess = Util.GetRandom();

        public void StartGame()
        {

            maxGuess = 1000;
            minGuess = 1;
            
            Console.Clear();
            Console.WriteLine("\n Please pick a number between " + minGuess + " and " + maxGuess);
            Console.WriteLine("\n Is your number higher or lower than " + guess + "?\n");
            maxGuess += 1;
            ContinuedGuessing();
        }

        public void ContinuedGuessing()
        {
            Console.WriteLine("\n Please type H for Higher, L for Lower, C for Correct, or Q to Quit\n");
            string userInput = Console.ReadLine();

            if (userInput == "H" || userInput == "h")
            {
                minGuess = guess;
                NextGuess();
            }

            else if (userInput == "L" || userInput == "l")
            {
                maxGuess = guess;
                NextGuess();
            }

            else if (userInput == "C" || userInput == "c")
            {
                Console.WriteLine("\n Hooray!  Computer is a winrar!\n");
                System.Threading.Thread.Sleep(1000);
                GameOver();
            }

            else if (userInput == "Q" || userInput == "q")
            {
                GameOver();
            }

            else
            {
                Console.WriteLine("\n I'm sorry, I didn't get that\n");
                ContinuedGuessing();
            }
        }

        public void NextGuess()
        {
            guess = (maxGuess + minGuess) / 2;
            Console.Clear();
            Console.WriteLine("\n Is your number higher or lower than " + guess + "?\n");
            ContinuedGuessing();
        }

        public void GameOver()
        {
            Console.Clear();
            Console.WriteLine("\n Would you like to play again?\n\n Type Yes to continue or No to quit\n");
            string userContinue = Console.ReadLine();

            if (userContinue == "Yes" || userContinue == "yes" || userContinue == "y" || userContinue == "Y") 
            {
                StartGame();
            }

            else if (userContinue == "No" || userContinue == "no" || userContinue == "n" || userContinue == "N")
            {
                Console.Clear();
                Console.WriteLine("\n Thank you for playing!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                return;
            }

            else
            {
                Console.WriteLine("\n\n I'm sorry, I didn't get that\n\n");
                GameOver();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to Number Wizard!\n\n--------------------------\r");
            Console.WriteLine("\n version 1.0");
            Console.WriteLine("\n Toberdyne Industries 2020\n https://www.toberdyne.net");
            System.Threading.Thread.Sleep(2000);
            Program g = new Program();
            g.StartGame();

        }
    }
}
