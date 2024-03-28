using System;

class Car
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter a number to learn if it's a prime number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("It is a prime number.");
            }
            else
            {
                Console.WriteLine("It's not a prime number.");
            }

            Console.Write("\nPress 1 to continue, or any other key to exit.");
            string userInput = Console.ReadLine();

            if (userInput != "1")
            {
                continueProgram = false;
            }
        }
    }
}
