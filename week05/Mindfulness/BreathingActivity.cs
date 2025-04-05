using System.Threading;

public class BreathingActivity : Activity
{
    private string _breathInMessage = "Breathe in...", _breathOutMessage = "Now breathe out...";
    private int _breathDuration = 5;

    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing Activity";
    }

    public override void StartActivity()
    {
        base.StartActivity();
        Breath();
        EndActivity();
    }

    private void Breath()
    {
        int breathCycle = _breathDuration * 2;
        int totalBreaths = _duration / breathCycle;

        for (int i = 0; i < totalBreaths; i++)
        {
            Console.Write(_breathInMessage);
            CountDown();
            Console.WriteLine();

            Console.Write(_breathOutMessage);
            CountDown();
            Console.WriteLine("\n");
        }
    }

    private void CountDown()
    {
        base.CoundDown(_breathDuration);
    }
}