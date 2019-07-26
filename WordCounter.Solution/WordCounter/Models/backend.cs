using System;
using System.Collections.Generic;


namespace WordCounter
{
    public class Item

  
    {
         
        public int wordFinder(string sentence, string number)
        {
                

         
            int numberOfTimes = 0;

            for(int i = 0; i<sentence.Length; i++)
            {
                
            if(sentence[i] == number[i])
            {
                numberOfTimes += 1;
               
            }
            else
            {
                Console.WriteLine("Your sentence doesnt contain that word");
                break;
            }
               
            }

           return numberOfTimes;
        }
    }
}