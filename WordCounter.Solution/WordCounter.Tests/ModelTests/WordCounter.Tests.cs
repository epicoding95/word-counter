using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter;



namespace WordCounter.TestTools{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]


        public void ItemConversion_findWord_word()
        {
            Item newItem = new Item();
            List<string> actualValue = newItem.wordFinder("anything", "yes anything");

            List<string> testValue = newItem.wordFinder("anything", "yes anything");
            for(int i = 0; i<actualValue.Count; i++)
            {
                Assert.AreEqual(actualValue[i],testValue[i]);
            }
        }
    }
}
    