//Unit 02 Develop: Journal Program

using System;
using System.Collections.Generic;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {

            Console.Write("Enter your full name: ");
            string userName = Console.ReadLine();   
            Journal myJournal = new Journal();

            myJournal._name = char.ToUpper(userName[0]) + userName.Substring(1);
            
            
            List<string> localStorageList = new List<string>();

        
        bool exitProgram = false;
        while(!exitProgram){

            List<string> notificationsList = new List<string>()
            {
            "What surprised you the most today?",
            "Describe a small act of kindness you witnessed or participated in today.",
            "What challenged you the most today, and how did you overcome it?",
            "If you could give one piece of advice to you future self, what would it be?",
            "Imagine you have a time capsule that will be opened 10 years from now. What would you put inside and why?",
            "Describe a decision you made today and how it impacted you or someone else.",
            "If you could have a conversation with your future self one year from now, what would you ask?",
            "What lesson did you learn from a mistake you made today?",
            "Imagine you're writing a song about today. What would the title be and what would the song be about?"
            };

            //Display the menu
            Console.WriteLine("Please select one of the following choices?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            string chargedFile= "No";
            string answerFileToLoad;
            string optionChoose = Console.ReadLine();
            

            switch (optionChoose)
            {

                    case "1": //write

                    Random random = new Random();
                    int num = random.Next(0, 6);
                    Entry entry1 = new Entry();
                    
                    entry1._message = notificationsList[num];
                    Console.WriteLine(entry1._message);
                    
                    Console.Write(">");
                    string userentryResponse = Console.ReadLine();
                    
                    entry1._response = char.ToUpper(userentryResponse[0]) + userentryResponse.Substring(1);
                    
                    myJournal._entries.Add(entry1);
                                        
                    
                    break;


                case "2": //display
                    
                    if(chargedFile == "Yes"){
                    foreach (string item in localStorageList)
                    {
                        Console.WriteLine(item);
                    }
                     myJournal.Display();

                    Console.WriteLine("To save the current list, please save it.");
                    }
                    
                    else if(chargedFile == "No"){
                    Console.WriteLine("------------------------------------------------------");
                    
                    myJournal.Display();

                    
                    Console.WriteLine("------------------------------------------------------");

                    Console.WriteLine("To save the current list, please save it.");

                    };

                    break;
            

                case "3": //load
                
                    chargedFile= "No";
                    
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    answerFileToLoad = Console.ReadLine();
                    string filename = answerFileToLoad;
                    
                    
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                            Console.WriteLine(line);
                            localStorageList.Add(line);                            
                    }
                    Console.WriteLine("File loaded.");
                    
                    chargedFile= "Yes";
                    break;


                case "4": //save


                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    string answerFileToSave = Console.ReadLine();
                    

                    using (StreamWriter outputFile = new StreamWriter(answerFileToSave))
                    {  

                        outputFile.WriteLine("------------------------------------------------------");
                        outputFile.WriteLine($"Name: {myJournal._name}");


                        foreach (Entry entry in myJournal._entries)
                        {


                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: "+entry._message);
                        outputFile.WriteLine($"{entry._response}");
                        
                        }

                        outputFile.WriteLine("------------------------------------------------------");
                        
                    };

                    break;


                case "5": //quit
                    exitProgram = true;
                    break;

                                
                default:
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        
            }    
    }
}