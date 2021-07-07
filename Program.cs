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


            Console.WriteLine(getPair());
            Console.WriteLine("Hello World!");

            string getPair()
        {
            string para = "Error";

            // TODO: Better error handling
            if (!File.Exists(listName))
            {
                Console.WriteLine("Error");
                return para;
            }

            int lineCount = File.ReadLines(listName).Count();
            int linesToSkip = rnd.Next(lineCount);
            para = File.ReadLines(listName).Skip(linesToSkip).Take(1).First();


            Console.WriteLine($"Plik ma {lineCount} lini. Lines to skip = {linesToSkip}");
            return para;
        }
        }        
    }    
}
