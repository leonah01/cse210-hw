
class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "Who was, most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something l got done today??",
        "How was my schedule today?",
        "What is the new thing l discovered about myself today?",
        "What good advice did l get today?",
        "What did l learn from my daily scripture study today?",
    };

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);
        string selectedPrompt = prompts[promptIndex];
        // Get the user's response
        Console.WriteLine("New entry prompt: " + selectedPrompt);
        string response = Console.ReadLine();

        return "randomPrompt";
    }
}