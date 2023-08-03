using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWordsConsoleApp;
using ReverseSentence;

namespace ReverseWordsOrderConsoleAppTests
{
    [TestClass]
    public class ReverseWordsOrderTests
    {
        [TestMethod]
        public void ReverseSentence_ShouldReverseSentence()
        {
            // Arrange
            string input = "This is a test";
            string expected = "test a is This";

            // Act 
            MySentence ms = new();
            ms.Sentence = input;
            string actual = ms.ReverseSentence();                      

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseSentence_EmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            MySentence ms = new();
            ms.Sentence = input;
            string actual = ms.ReverseSentence();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
