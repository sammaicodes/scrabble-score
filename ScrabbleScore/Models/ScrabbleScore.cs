using System;

namespace Game
{
  public class ScrabbleScore
  {
    public int userOneTotal { get; set; }
    public int userTwoTotal { get; set; }
    public ScrabbleScore(int userOneTotal, int userTwoTotal)
    {
      userOneTotal = userOneTotal;
      userTwoTotal = userTwoTotal;
    }
    public int GetTotalOne()
    {
      return _userOneTotal;
    }
    public int SetTotalOne()
    {

    }
    // userOneTotal += wordScore

    //  public int GetTotalTwo()
    // {
    //   return _userTwoTotal;
    // }


    public static string GetScrabbleWord(string userInput)
    {
      return userInput;
    }
    public static char FindScrabbleLetter(string userInput)
    {
      char letter = userInput[0];
      return letter;
    }
    public static int AddingLetterValue(char letter)
    {
      int value = 0;

      switch (letter)
      {
        // case a:
        case 'e':
          // case i:
          // case o:
          // case u:
          // case l:
          // case n:
          // case r:
          // case s:
          // case t:
          value += 1;
          break;
        // case d:
        case 'g':
        default:
          value += 2;

          break;
          // case b:
          // case c:
          // case m:
          // case p:
          //   value += 3;
          //   break;
          // case f:
          // case h:
          // case v:
          // case w:
          // case y:
          //   value += 4;
          //   break;
          // case k:
          //   value += 5;
          //   break;
          // case j:
          // case x:
          //   value += 8;
          //   break;
          // case q:
          // case Z:
          //   value += 10;
          // default:
          // break;
      }
      return value;
    }
  }
}

// need a loop to go through every letter in the word
// then pass it to switch cases (this helps us add numerical value to letters) //could use object instead? 
// add them

/*

WE NEED TO SOMEHOW IMPLEMENT GET-SET!!!!!
we can make an object for these key value pairs?
user to input a word. 
Maybe we seperate?
loop through a string? indexof() a string character form a word. 
wed convert a string to an integer at some point. 
make loop to pull value from indexed string and add up and return that value? 
switch statment that holds all values 
*/
