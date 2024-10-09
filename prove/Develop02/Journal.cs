using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;



public class Journal
{
    
    string path = @"C:\Users\nhlak\Documents\cse210-hw\cse210-hw\prove\Develop02\MyJournal.txt";
    //A list to hold defined prompt
    public List<Entry> _entries = new List<Entry>();

    //Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        {
            _entries.Add(newEntry);
        }
    }


    //Display all entries in the journal

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNo entries in the Journal.\n");
            ForegroundColor = ConsoleColor.White;
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                entry.Display();
                ForegroundColor = ConsoleColor.White;
            }
        }
    }



    // Create and save text in journal text filr.
    public void SaveToFile()
    {
        //create a text file 
        //string path = @"C:\Users\nhlak\Documents\cse210-hw\cse210-hw\prove\Develop02\MyJournal.txt";
                  
            //Check if file exits
            if (!File.Exists(path))

            //if does not exist create one on the path provided
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    //Enter text on the file created
                    foreach (var entry in _entries)
                    {
                        writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                        break;
                    }
                }
            } 

            //when is created append all jornal text in this file
            if (File.Exists(path))
            {
                // first clear the previous text
                ClearFile();
                //Append all text of the journal
                foreach (var entry in _entries)
                    {
                        File.AppendAllText(path, $"\nEntry: \n{entry._date} | {entry._promptText} | {entry._entryText}");
                        
                    }    
            }
            

        ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"Journal saved to MyJournal text file under the path: {path}");
        ForegroundColor = ConsoleColor.White;
    }


     
     //Load the saved journal from file.
    public void LoadFromFile()
    {
         
        //string path = @"C:\Users\nhlak\Documents\cse210-hw\cse210-hw\prove\Develop02\MyJournal.txt";
        
        if (File.Exists(path))
            {
                using(StreamReader reader = File.OpenText(path))
                {
                
                    string file;
                    
                    while ((file =reader.ReadLine())!=null)
                    {
                        ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(file);
                        ForegroundColor = ConsoleColor.White;

                    }
                }
            
            }
    }        
    
    //clear file
    public void ClearFile()
    {
        File.WriteAllText(path,"");
        WaitForKey();
    }

    //press any key to carry on
    public void WaitForKey()
    {
        ForegroundColor = ConsoleColor.DarkGray;
        WriteLine("\nPress any key.........");
        ForegroundColor = ConsoleColor.White;
        ReadKey(true);
    }
}
