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
            //arrange
            
            Item testItem = new Item("yes", "yes yes");
            ///Ac
            int actualValue = testItem.WordFinder(testItem.Sentence,testItem.Word);
            //Assert
            Assert.AreEqual(actualValue, 2);


           
            
        }

    [TestMethod]
     public void ItemConversion_findSplit_Word()
        {
            //arrange
            
            Item testItem2 = new Item("yes", "yes,,,+/-,,yes+yes ");
            ///Ac
            int actualValue2 = testItem2.WordFinder(testItem2.Sentence,testItem2.Word);
            //Assert
            Assert.AreEqual(actualValue2, 3);
        }


    }
}
    