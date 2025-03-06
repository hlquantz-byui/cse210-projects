using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1,101);

        // Console.Write("What is the magic number? ");
        string input;
        // int magicNumber = int.Parse(input);
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber){
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
        
    }
}