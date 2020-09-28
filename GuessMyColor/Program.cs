using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;
            // 1-red, 2-green, 3-blue

            while(!rightGuess)
            {
                Console.WriteLine("what's my color?");
                string userInput = Console.ReadLine().ToLower();

                if(computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You Won!");
                    rightGuess = true;
                }else if(computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("You Won");
                    rightGuess = true;
                }else if(computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("You Won");
                    rightGuess = true;
                }else
                {
                    Console.WriteLine("Try Again n0oB");
                }
                

                
            }
        }
    }
}
