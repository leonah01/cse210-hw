using System;
using System.Threading;

namespace Namespace2
{
    public class BreathingActivity : Namespace.MindfulnessActivity
    {
        public override void StartActivity(int duration)
        {
            // print some introductory messages
            Console.WriteLine("Breathing Activity: This activity will guide you through a breathing exercise to help you relax and focus.");
            Console.WriteLine("Be sure to be comfortable.");

            // wait for 3 seconds
            Pause(3);
            Console.WriteLine("Take a deep breath in through your nose.");

            Animate("Hold your breath.", 3);

            Console.WriteLine("Slowly exhale.");

            Animate("Pause.", 1);

            // instruct the user to repeat the cycle for the given duration
            Console.WriteLine("Repeat this cycle for " + duration + " seconds.");

            int cycles = duration / 7; 

            // loop through the required number of cycles
            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Inhale...");

                Animate("Hold...", 3);

                Console.WriteLine("Exhale...");

                Animate("Pause...", 1);
            }

            // indicate that the activity is complete
            Console.WriteLine("how do you feel.");
        }
    }
}