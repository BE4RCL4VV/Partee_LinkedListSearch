using System;
using System.IO;

namespace Partee_LinkedListSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ListOPeeps = new LinkedList();
            Node head = new Node(new MetaData("A", 'A', -1));
            ListOPeeps.Head = head;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader stream = new StreamReader("C:\\Users\\parte\\source\\repos\\Partee_LinkedListSearch\\yob2019.txt");
                    //Read the first line of text
                    string line = stream.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string[] info = line.Split(',');
                    string nameData = info[0];
                    char genderData = info[1][0];
                    int rankData = int.Parse(info[2]);

                    MetaData newPerson = new MetaData(nameData, genderData, rankData);
                    Node newNode = new Node(newPerson);
                    ListOPeeps.AddNode(newNode);

                    //Read the next line
                    line = stream.ReadLine();
                }              
                //close the file
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            PrintMenu();
            string selection = "";
            while (selection != "9")
            {
                selection = Console.ReadLine();
                // Name Search
                if (selection == "1")
                {
                    Console.WriteLine("Enter the Name you wish to search for: ");
                    string input = Console.ReadLine();
                    bool answer = ListOPeeps.Contains(input);
                    if (answer)
                    {
                        Console.WriteLine("The list contains " + input);
                    }
                    else
                    {
                        Console.WriteLine("The list does not contain " + input);
                    }
                    Console.WriteLine("Press Enter to Return to Menu");
                    Console.ReadLine();
                    PrintMenu();
                }
                // Overall Number of Nodes
                if (selection == "2")
                {
                    Console.WriteLine("Overall Count: " + ListOPeeps.Overall);
                    Console.WriteLine("Press Enter to Return to Menu");
                    Console.ReadLine();
                    PrintMenu();
                }
                // Number of Female Nodes
                if (selection == "3")
                {
                    Console.WriteLine("Female Count: " + ListOPeeps.Females);
                    Console.WriteLine("Press Enter to Return to Menu");
                    Console.ReadLine();
                    PrintMenu();
                }
                // Number of Male Nodes
                if (selection == "4")
                {
                    Console.WriteLine("Male Count: " + ListOPeeps.Males);
                    Console.WriteLine("Press Enter to Return to Menu");
                    Console.ReadLine();
                    PrintMenu();
                }
                // Add Node with new data
                if (selection == "5")
                {
                    Console.Clear();
                    Console.WriteLine("You will Need a Name, Gender, and Rank to proceed");
                    Console.WriteLine("Enter the Name of the Person you want to add: ");
                    string nameInput = Console.ReadLine();
                    Console.WriteLine("Enter the Gender of the Person as \"M\" or \"F\": ");
                    char genderInput = Console.ReadLine().ToUpper()[0];
                    Console.WriteLine("Enter the Rank of the Person as a whole number: ");
                    int rankInput = int.Parse(Console.ReadLine());
                    
                    MetaData newPerson = new MetaData(nameInput, genderInput, rankInput);
                    Node addedNode = new Node(newPerson);
                    if (ListOPeeps.Contains(addedNode.Person.Name, addedNode.Person.Gender))
                    {                        
                        Console.WriteLine("That name already exists. _1x will be added to the end" +
                            "\nEnter \"1\" if ok. \"2\" to return to Main Menu");
                        string choiceInput = Console.ReadLine();
                        if (choiceInput == "1")
                        {
                            addedNode.Person.Name = addedNode.Person.Name + "_1x";
                            ListOPeeps.AddNode(addedNode);
                            Console.WriteLine(addedNode.Person.Name + " added to list");
                            Console.ReadLine();
                            PrintMenu();
                        }
                        else
                        {
                            PrintMenu();
                        }
                    }                   
                }
                // Top ranked data
                if (selection == "6")
                {
                    Console.WriteLine("Top Male: " + ListOPeeps.TopMale.Name + " Rank: " + ListOPeeps.TopMale.Rank + " Top Female: " + ListOPeeps.TopFemale.Name + " Rank: " + ListOPeeps.TopFemale.Rank); ;
                    Console.ReadLine();
                    PrintMenu();
                }
            }           
        }
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Doubly Linked List Schmigadoon!!!");
            Console.WriteLine("Select an Option");
            Console.WriteLine("Enter:  1: to Search for a Name\n" + 
                "\t2: to Display the Overall Count of names\n" +
                "\t3: to Display the Total Count of Females\n" +
                "\t4: to Display the Total Count of Males\n" +
                "\t5: to Add a Name to the List\n" +
                "\t6: to Show the Top Ranked Names\n" +
                "\t9: To Exit the Madness");
        }
    }
}
