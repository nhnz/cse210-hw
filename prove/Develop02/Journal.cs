using System.Diagnostics;
// created class Journal
class Journal
{
    //A list for the entries
    public List<Entry> entries = new List<Entry>();
    public static readonly string[] prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
//Allow user to record in the Journal
    public void JournalEntry()
    {
        Random recordings = new Random();
        string prompt = prompts[recordings.Next(prompts.Length)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        entries.Add(new Entry(date, prompt, response));
        Console.WriteLine("Entry saved!");
    }
    //Display contect of the Journal
    public void DisplayJournalEntries()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    // Save Journal Content to files
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }
    //Load Journal from the file you save in 

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
