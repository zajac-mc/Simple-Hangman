/*  
    2021 07 07 Marcin Zajac
    The Hangman Game Implemmentation

    Implemenentation of the simple hangman according to functional requirements (more in .pdf attachement)
    and my best knowledge
*/

using System;
using System.IO;
using System.Linq;

namespace Simple_Hangman
{
    class Program
    {   
        static void Main(string[] args)
        {
            string listName = "countries_and_capitals.txt";
            Random rnd = new Random();

            string[] geoPair = getPair();
            string country = geoPair[0];
            string capitol = geoPair[1];
            Console.WriteLine(country);
            Console.WriteLine(capitol);
            displayAsDashes(capitol);
            // char[] capitolToGuess = capitol.ToCharArray();
            // foreach(char letter in capitolToGuess)
            // {
            //     if (letter != ' ')
            //     {
            //         Console.Write(" _ ");
            //         // Console.Write(letter);
            //     }
            //     else Console.Write("   ");
            // }
            Console.WriteLine("Hello World!");



            void displayAsDashes(string wordToDash)
            { 
                char[] word = wordToDash.ToCharArray();
                foreach (char letter in word)
                {
                    if (letter != ' ')
                    {
                        Console.Write(" _ ");
                    }
                    else Console.Write("   ");
                }
            }


            string[] getPair()
        {
            // TODO: Better error handling
            if (!File.Exists(listName))
            {
                Console.WriteLine("Error");
                string[] err = {"Error"};
                return err;
            }

            int lineCount = File.ReadLines(listName).Count();
            int linesToSkip = rnd.Next(lineCount);
            string line = File.ReadLines(listName).Skip(linesToSkip).Take(1).First();
            string[] pair = line.Split('|');
            pair[0] = pair[0].Trim();
            pair[1] = pair[1].Trim();

            return pair;
        }
        }        
    }    
}
