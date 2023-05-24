using System;
using System.Threading;

namespace Namespace
{
    public abstract class MindfulnessActivity
    {
        public virtual void StartActivity(int duration)
        {
            throw new NotImplementedException();
        }

        protected static void Pause(int durationInSeconds)
        {
            Console.WriteLine("Prepare to begin in:");

            // This loop displays a countdown from 3 to 1.
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000); 
            }

            // This message is displayed to signal the start of the activity.
            Console.WriteLine("Start!");

            Thread.Sleep(durationInSeconds * 1000);
        }

        protected static void Animate(string message, int durationInSeconds)
        {
            // This loop displays the message for the duration.
            for (int i = 0; i < durationInSeconds; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(1000);
            }
        }
    }
}