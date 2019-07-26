using System;
using System.Collections.Generic;
using WordCounter;




namespace frotnEnd
{
    public class Program
    {
        public static void Main()
        {

           
            Console.BackgroundColor = ConsoleColor.Black;
             Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Word-Counter!");
            Console.WriteLine("Press any key to begin!");
            Console.ReadKey();
            Console.WriteLine("\nEnter a sentence");
            string userSentence = Console.ReadLine();
            Console.WriteLine("Enter a word to find out if it appears in your sentence");
            string userWord = (Console.ReadLine());

            Item newItem = new Item(userSentence,userWord );
            Console.WriteLine("your word appears this many times" + " " + newItem.WordFinder(userSentence,userWord));
           





        }
    }
}