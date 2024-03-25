class BreathingActivity : Activity
{
    public override void StartActivity()
    {
        CommonStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int remainingTime = duration;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);

            remainingTime -= 4;
        }

        CommonEndingMessage("Breathing Activity");
    }
}
