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
            Console.WriteLine("\nWelcome to Word-Counter!");
            Console.WriteLine("\nPress any key to begin!");
            Console.ReadKey();
            Console.WriteLine("\nEnter a sentence");
            string userSentence = Console.ReadLine();
            Console.WriteLine("Enter a word to find out if it appears in your sentence");
            string userWord = (Console.ReadLine());

            Item newItem = new Item(userSentence,userWord );
            Console.WriteLine(@"your word " +  userWord +  " appears "+ newItem.WordFinder(userSentence,userWord) + " time(s)" + "");

            Console.WriteLine("Would you like to write any more sentences or be done? ---yes/no?"); 
            string answerAgain = Console.ReadLine();

            if (answerAgain == "yes")
            {
                Main();
            }
            else{
                Console.WriteLine("goodbye");
            }
           





        }
    }
}