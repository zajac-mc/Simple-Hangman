/*  
    2021 07 07 Marcin Zajac
    The Hangman Game Implemmentation

    Implemenentation of the simple hangman according to functional requirements (more in .pdf attachement)
    and my best knowledge
*/

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

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

            List<char> usedLetters = new List<char>();

            Console.WriteLine(usedLetters.Count);
            usedLetters.Add('a');            
            Console.WriteLine(usedLetters.Count);            
            Console.WriteLine(usedLetters.Last());
            usedLetters.Add('b');
            usedLetters.Add('o');
            usedLetters.Add('e');
            usedLetters.Add('i');
            displayAsDashes(capitol);

            
            Console.WriteLine("Hello World!");



            void displayAsDashes(string wordToDash)
            { 
                char[] word = wordToDash.ToCharArray();
                foreach (char letter in word)
                {
                    bool used = false;
                    if (letter != ' ')
                    {
                        for (int i = 0; i < usedLetters.Count; i++)
                        {
                            if (letter == usedLetters[i])
                            {
                                used = true;
                            }
                        }

                        if (used)
                        {
                            Console.Write($" {letter} ");
                        }
                        else Console.Write(" _ ");
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
