
class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void DisplayJournalEntries()
    {
        foreach(Entry entry in entries)
        {
            entry.DisplayEntry();
        }
       
    }

    public void CreateJournalEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string userPrompt = prompt.GetRandomPrompt();
        DateTime _date = DateTime.Now;
        string dateTime = _date.ToShortDateString();
        Console.WriteLine(userPrompt);

        string userResponse = Console.ReadLine();

        Entry entry = new Entry(dateTime, userPrompt, userResponse);
        entries.Add(entry);
    }

    public void SaveToFile()
    {
         Console.WriteLine("Enter a filename to save the journal to:");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))

        foreach (Entry entry in entries)
        {
            outputFile.WriteLine();
            outputFile.WriteLine("Date: " + entry._dateTime);
            outputFile.WriteLine("Prompt: " + entry._prompt);
            outputFile.WriteLine("Response: " + entry._response);
            outputFile.WriteLine();
        }
    }

    public void LoadFromCSV(Stream fileName)
    {
        using (System.IO.StreamReader file = new System.IO.StreamReader(fileName))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                DateTime date = DateTime.Parse(fields[0]);
                string prompt = fields[1];
                string response = fields[2];
                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }

    }

    internal void LoadFromCSV()
    {
        throw new NotImplementedException();
    }
}