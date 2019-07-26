using System;
using System.Collections.Generic;


namespace WordCounter
{
    public class Item

  
    {
         
        public List<string> wordFinder(string word, string sentence)
        {

         List <string> answerList = new List<string>();
            
            for(int i = 0; i<sentence.Length; i++)
            {

            if(sentence.Contains(word))
            {
                answerList.Add(word);
            }
            }

           return answerList;
        }
    }
}