using System;

class Program
{
    static void Main(string[] args)
    {
        Journal   journal=new Journal();
        int       menuUserinput = 0;

        List<String>  menu = new List<string>
            {
                "Welcome to my journal program, Please select one of the following options:",
                "1. write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Exit",
                "6. State your selection?"
            };
            while (menuUserinput != 5)
            {
                foreach(string menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                }
                menuUserinput = int.Parse(Console.ReadLine());
                if (menuUserinput == 1) 
                {
                    journal.CreateJournalEntry();
                }
                else if (menuUserinput == 2)
                {
                    journal.DisplayJournalEntries();
                }
                else if (menuUserinput == 3)
                {
                    journal.LoadFromCSV();
                }
                else if (menuUserinput == 4)
                {
                    journal.SaveToFile();
                }
            }
    }    
}