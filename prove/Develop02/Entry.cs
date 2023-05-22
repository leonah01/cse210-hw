public class Entry
{
    public DateTime _dateTime;
    public string _prompt;
    public string _response;

    public string Date { get; internal set; }

    public Entry(DateTime date, string prompt, string response)
    {
        _dateTime = date;
        _prompt = prompt;
        _response = response;
    }

    public Entry(string dateTime, string userPrompt, string userResponse)
    {
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public void RemoveEntry(int index)
    {
        Entry.RemoveAt(index);
    }

    private static void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}