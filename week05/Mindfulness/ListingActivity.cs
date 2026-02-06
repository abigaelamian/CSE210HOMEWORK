using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you list positive things in your life."
    ) {}

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt:\n> {prompt}");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();
        Stopwatch timer = new Stopwatch();
        timer.Start();

        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}