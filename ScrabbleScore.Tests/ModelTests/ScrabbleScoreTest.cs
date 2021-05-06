using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace ScabbleScore.Test
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void GetScrabbleWord_ReceiveUserInput_word()
    {
      string userWord = ScrabbleScore.GetScrabbleWord("peach");
      Assert.AreEqual(userWord, "peach");
    }
    [TestMethod]
    public void FindScrabbleLetter_GetAnIndex_IndexNumber()
    {
      char numberString = ScrabbleScore.FindScrabbleLetter("peach");

      string word = "peach";
      char letter = word[0];
      Assert.AreEqual(numberString, letter);
    }
    [TestMethod]
    public void AddingLetterValue_FromUserIndexInput_NumberFromIndexedLetter()
    {
      int value = ScrabbleScore.AddingLetterValue('e');
      int letterValue = 1;
      Assert.AreEqual(value, letterValue);
    }
    [TestMethod]
    public void GetTotalOne_FromUserIndexInput_UserOneTotal()
    {
      ScrabbleScore newConstructor = new ScrabbleScore(2, 3);
      int total = newConstructor.GetTotalOne();
      int currentTotal = 2;

      // newConstructor.SetTotalOne();
      Assert.AreEqual(total, currentTotal);
    }



  }
}
