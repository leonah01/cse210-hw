using System;
using MindfulnessApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to menu program");

      while (true)
        {
            // Display the menu of activities.
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            // Get user input.
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Wrong choice. Please choose a number from 1 to 4.");
                continue;
            }

            // If the user chose to quit, end the program.
            if (choice == 4)
            {
                Console.WriteLine("Thank you for trying this App!");
                break;
            }

            // Prompt the user to enter a duration for the activity.
            Console.Write("Enter duration in seconds: ");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration < 1)
            {
                Console.WriteLine("Wrong choice.");
            }

            // Prepare to start the activity.
            string[] spinner = { "/", "-", "\\", "|" };
            int index = 0;
            for (int i = 3; i >= 1; i--)
            {
                Console.Write("Start your preparations ");
                Console.Write(spinner[index]);
                Console.CursorLeft--;
                index = (index + 1) % spinner.Length;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("start!");

            switch (choice)
            {
                // Create a new instance of the BreathingActivity class and start the activity.
                // Create a new instance of the ReflectionActivity class and start the activity.
                // Create a new instance of the ListingActivity class and start the activity.
                case 1:
                    var breathingActivity = new Namespace2.BreathingActivity();
                    breathingActivity.StartActivity(duration);
                    break;
                case 2:
                    var reflectionActivity = new Namespace3.ReflectionActivity();
                    reflectionActivity.StartActivity(duration);
                    break;
                case 3:
                    var listingActivity = new ListingActivity();
                    listingActivity.StartActivity(duration);
                    break;
            }

            // The conclusion.
            Console.WriteLine("Awsome! Activity copleted.");
            Console.WriteLine();
        } 
    }
    

}