using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        
        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine("Your letter grade is: " + letterGrade);

        if (grade >= 70){
            Console.WriteLine("You passed the course.");
        } else {
            Console.WriteLine("Better luck next time.");
        }
    }
}