using System;
using System.Text;


namespace ReverseSentence
{
    public class MySentence
    {
        public string Sentence { get; set; } = string.Empty;

        //Reverse Sentence
        public string ReverseSentence()
        {
            string[] arrWords = Sentence.Split(' ');
            Array.Reverse(arrWords);
            return string.Join(' ', arrWords);
        }
    }
}

namespace ReverseWordsConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter number of cases and then PRESS enter to continue:");
            string cases = Console.ReadLine();
            int option;
            //validating input i.e number of cases
            while (!int.TryParse(cases, out option))
            {
                Console.WriteLine("Incorrect input type. Please enter a numeric value and then PRESS enter to continue:");
                cases = Console.ReadLine();
            }

                      
            //Number of cases correct
            for (int i = 0; i < option; i++)
            {
                Console.Write("Please enter your sentence and then PRESS enter to continue:\n");
                //Read in a sentence from the console
                string strSentence = Console.ReadLine();
                if (strSentence?.ToLower() == "n")
                {
                    break;
                }

                //Creating instance of MySentence class
                ReverseSentence.MySentence s = new()
                {
                    Sentence = strSentence
                };

                //Calling the ReverseSentence() method ... (implemented in MySentence class)
                string reversedSentence = s.ReverseSentence();

                //Call the print method 
                DisplayReversedSentence(reversedSentence);
            }
        }

        //Printing the reversed sentence
        static void DisplayReversedSentence(string reversedSentence)
        {
            Console.WriteLine("Reversed sentence: " + reversedSentence + "\n");
        }
    }
}
