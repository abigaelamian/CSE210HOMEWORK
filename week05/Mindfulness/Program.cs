using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("🧘 Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1") activity = new BreathingActivity();
            else if (choice == "2") activity = new ReflectionActivity();
            else if (choice == "3") activity = new ListingActivity();

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}
