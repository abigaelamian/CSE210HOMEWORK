using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly."
    ) {}

    protected override void PerformActivity()
    {
        int timePassed = 0;
        while (timePassed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            timePassed += 4;

            Console.Write("\nBreathe out... ");
            ShowCountdown(6);
            timePassed += 6;
        }
    }
}