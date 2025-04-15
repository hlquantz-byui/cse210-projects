using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        activities.Add(new Swimming(DateTime.Now, 40, 20));
        activities.Add(new Cycling(DateTime.Now, 45, 20));
        activities.Add(new Running(DateTime.Now, 30, 3));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}