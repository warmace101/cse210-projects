public string Load{

public string Load()
{
            static string PromptUserForJournal()
        {
            //Get our current path
            string myPath = Directory.GetCurrentDirectory();
            string[] filePaths = Directory.GetFiles(myPath, "*.txt");
            Console.WriteLine("Please enter the journal file you would like to load or type a new file name to save.");
            foreach (string s in filePaths)
            {
                string fn = Path.GetFileName(s);    
                Console.WriteLine(fn);
            }
            //need to add some data scrubbing here.  It is case sensitive.
            string userSelection = Console.ReadLine();
            bool matchFound = false;
            foreach (string s in filePaths)
            {
                string fn = Path.GetFileName(s);
                Console.WriteLine("Filename: " + fn.ToString() + "   User entered: " + userSelection);
                if (fn == userSelection)
                {
                    //we have a match.
                    Console.WriteLine("Loading journal " + fn.ToString());
                    matchFound = true;  
                    break;
                }
                else
                {
                    //Console.WriteLine("Your entry doesn't match any available journals.");
                }
            }
            if (!matchFound)
            {
                userSelection = "Journal.txt"; //Default to Journal.txt if the operator messes up?
            }
            return userSelection;
        }

}

};