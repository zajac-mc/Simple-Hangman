/*  
    2021 07 07 Marcin Zajac
    The Hangman Game Implemmentation

    Implemenentation of the simple hangman according to functional requirements (more in .pdf attachement)
    and my best knowledge
*/

using System;
using System.IO;


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
            // TODO: Better error handling
            if (!File.Exists(listName))
            {
                Console.WriteLine("Error");
                return "ERROR";
            }
            Console.WriteLine("Para");
            return "Para";
        }
        }        
    }    
}
