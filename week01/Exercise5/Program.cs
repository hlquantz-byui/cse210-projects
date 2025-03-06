using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumer();
        int squareNum = SquareNumber(favNum);
        DisplayResult(name, squareNum);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string input = Console.ReadLine();

        return input;
    }

    static int PromptUserNumer(){
        Console.Write("Please enter your favorit number: ");
        string input = Console.ReadLine();
        int favNum = int.Parse(input);

        return favNum;
    }

    static int SquareNumber(int num){
        return num * num;
    }

    static void DisplayResult(string name, int squareNum){
        Console.WriteLine($"{name}, the square of your number is {squareNum}");
    }
}