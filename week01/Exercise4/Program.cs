using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums;
        nums = new List<int>();
        Console.WriteLine("Enter a list of unmbers, type 0 when finished.");

        int number;
        int sum = 0;
        double average;
        int largest = int.MinValue;

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if(number != 0){
                nums.Add(number);
            }
        } while (number != 0);

        foreach (int num in nums)
        {
            sum += num;

            if (num > largest){
                largest = num;
            }
        }

        average = (double)sum / nums.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}