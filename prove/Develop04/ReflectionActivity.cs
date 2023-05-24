using System.Diagnostics; 
using System.Threading; 

namespace Namespace3
{
    public class ReflectionActivity : Namespace.MindfulnessActivity
    {
        // randomly select prompts
        private static readonly string[] Prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly Random Random = new();

        public override void StartActivity(int duration)
        {
            // Narrator introduction
            Console.WriteLine("Reflection Activity: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            AnimateSpinner("Generating prompt", 5);
            string prompt = Prompts[Random.Next(Prompts.Length)];
            Console.WriteLine("Prompt: " + prompt);
            Console.WriteLine($"You have {duration} seconds to reflect on your prompt...");

            // create a Stopwatch object to measure elapsed time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Time's up!");
        }

        private static void AnimateSpinner(string message, int durationInSeconds)
        {
            Console.Write(message);
            for (int i = 0; i < durationInSeconds; i++)
            {
                Console.Write("."); 
                Thread.Sleep(500); 
            }
            Console.WriteLine(); 
        }
    }
}