using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Namespace.MindfulnessActivity
    {
        // array of prompts to display to the user
        private readonly string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // generate random prompts
        private static readonly Random random = new();

        public override void StartActivity(int duration)
        {
            // Narration introduction
            Console.WriteLine("Listing Activity: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.Write("State your duration of the activity in seconds: ");
            int activityDuration = int.Parse(Console.ReadLine());
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine("Prompt: " + prompt);
            Console.WriteLine("You have " + activityDuration + " list your items as per time given.");
           
            Thread.Sleep(5000);
            DateTime startTime = DateTime.Now;
            int itemsCount = 0;

            while ((DateTime.Now - startTime).TotalSeconds < activityDuration)
            {
                Console.Write("Enter an item: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                itemsCount++;
            }

            // display the number of items listed by the user
            Console.WriteLine("You listed " + itemsCount + " items.");

            // display the standard finishing message for all activities
            Console.WriteLine("Listing activity completed.");
        }
    }
}