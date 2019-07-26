using System;
using System.Collections.Generic;


namespace WordCounter
{
    public class Item
    
    {

        public string Sentence {get; set;}
        public string Word {get; set;}

        public Item (string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }


         
        public int wordFinder(string sentence, string word,string[] newWords)
        {
                
            List<string> myList = new List<string>();

            int Count = 0;
            for(int i = 0; i<sentence.Length; i++)
            {
                
            if(sentence.Contains(word))
            { 
              
               myList.Add(word);
            
            }
            else
            {
                 return 0;
            }
            
            }
            return Count;
        } 

        public string[] splitSentence(string sentence)
        {
            string[] newWords = sentence.Split(" ");
            return newWords;
        }

      
    }
}