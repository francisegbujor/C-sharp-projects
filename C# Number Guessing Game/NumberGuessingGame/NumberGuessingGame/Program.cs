using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int winNum = rand.Next(0, 100);

            bool win = false;

            try
            {
                while (win == false)
                {

                    Console.Write("Guess a number between 0 and 100: ");
                    string guess = Console.ReadLine();
                    int num = Convert.ToInt32(guess);

                    if (num == winNum)
                    {
                        Console.WriteLine("Congrats you win!");
                        win = true;

                    }
                    else if (num > winNum)
                    {
                        Console.WriteLine("Too high. Guess again");
                    }
                    else
                    {
                        Console.WriteLine("Too low. Guess again");

                    }


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Not a valid input. Try again!");
                    
            }

            Console.WriteLine("Thank you for playing!");
            Console.Write("Press any key to exit");
            Console.ReadLine();
        }
    }
}
