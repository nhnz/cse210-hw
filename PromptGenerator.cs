public class PropmtGenerator
{
    string promptResponse;
//prompt generator for display list    
    do
    {
    
        Console.WriteLine("Welcome The Journal App:\n");
        Console.WriteLine("Menu:\n");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Diplay entries");
        Console.WriteLine("3. Save to file");
        Console.WriteLine("4. Load from file")
        Console.WriteLine("5 Save to file")
        Console.WriteLine("6. Exit\n")
        Console.Write("What would you like to do?: ")
        promptResponse = Console.ReadLine();

        switch (promptResponse)

// prompt generator for the user to chose from dis 
        {

            case "1":
                journal.JournalEntry();
                break;

            case "2":
                journal.DisplayJournalEntries();
                break;
            
            case "3":
                journal.SaveToFile();
                break;
            
            case "4":
                journal.LoadFromFile();
                break;

            case "5":
                Console.WriteLine("You have exited the journal. See you later!!!");
                break;
            
            default:
                console.WriteLine("Invalid selection");
                break;
            
        }
    }while (promptResponse != 5)
    {
        
    }
}   
