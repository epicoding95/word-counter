using System;
using System.Collections.Generic;


namespace WordCounter
{
    public class Item

  
    {
         
        public int wordFinder(int number, string sentence)
        {
                
         List <int> answerList = new List<int>();
         
            number = 0;
            for(int i = 0; i<sentence.Length; i++)
            {

            if(answerList.Contains(number))
            {
                number+= 1;
            }
            else
            {
                Console.WriteLine("Your sentence doesnt contain that word");
                break;
            }
               
            }

           return number;
        }
    }
}