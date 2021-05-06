using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace ScabbleScore.Test
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void CalculateScrabbleScore_ReceiveUserInput_word()
    {
      string userWord = ScrabbleScore.CalculateScrabbleScore("peach");
      Assert.AreEqual(userWord, "peach");
    }
  }
}
