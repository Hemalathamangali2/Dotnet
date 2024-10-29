using System;

namespace JumpStmts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Has the student received the Capgemini LOI? (yes/no)");
            string loiResponse = Console.ReadLine().ToLower();

            // Throw an exception if LOI is not received
            if (loiResponse != "yes")
            {
                throw new Exception("LOI not received. Student is not eligible for training.");
            }

            Console.WriteLine("LOI is received. Proceeding to training...");

            string[] topics = { "Conditional Statements", "Jump Statements", "Arrays", "OOPS" };
            int index = 0;

        TrainingLoop:
            if (index < topics.Length)
            {
                string topic = topics[index];
                Console.WriteLine($"\nHas the student covered {topic}? (yes/no)");
                string topicCovered = Console.ReadLine().ToLower();

                if (topicCovered == "yes")
                {
                    Console.WriteLine($"{topic} is covered. Moving to the next topic...");
                    index++;
                    goto TrainingLoop; // Use goto to continue to the next topic
                }

                if (topic != "OOPS")
                {
                    Console.WriteLine($"{topic} is not covered, but moving to the next topic...");
                    index++;
                    continue; // Use continue to skip to the next iteration (this will fall through)
                }

                if (topic == "OOPS" && topicCovered == "no")
                {
                    Console.WriteLine("OOPS is not covered. Restarting the training...");
                    return; // Use return to exit the method
                }

                if (topic == "OOPS" && topicCovered == "yes")
                {
                    Console.WriteLine("OOPS is covered. Training completed.");
                    break; // Use break to exit the loop
                }
            }

            // If all topics are covered or after breaking out of the loop
            Console.WriteLine("Training session has ended.");
        }
    }
}

