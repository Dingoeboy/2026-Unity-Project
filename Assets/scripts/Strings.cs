using JetBrains.Annotations;
using UnityEngine;

public class Strings : MonoBehaviour
{
    public string aName = "Picard";
    char targetLetter = 'a';     // can only store a single character single quotation marks for char data type
    char anotherLetter = 'A';  // chars are case sensitive'

    void Start()
    {
        Debug.Log("Welcome to Week 8!!!");

        Debug.Log("------------------------------------");
        foreach (char letter in aName)
        {
            Debug.Log(letter);

            if (letter == targetLetter)
            {
                Debug.Log("Found the letter " + targetLetter);
            }
            else
            {
                Debug.Log("This letter is not the one we are looking for");
            }
         } //end of foreach


        Debug.Log("------------------------------------");
        Debug.Log("Postion 0: " + aName[0]);



        Debug.Log("------------------------------------");
        string targetWord = "gamifaction";
        string playerGuess1 = "electrification";
        string playerGuess2 = "gamifaction";

        if (TestTheGuess(playerGuess2, targetWord))
        {
            Debug.Log("You can enter the mines of Moria!");
        }
        else
        {
            Debug.Log("You shall not pass!");
        }

    } // end of function start 




    //custom functions need to go in the class but outside of other functions
    // cannot have a function in a function

    public bool TestTheGuess(string secretWord, string guessWord)
    {
        // or you can test using the equals function
        if (secretWord.Equals(guessWord))
        {
            return true;
        }
        else
        {
            return false;
        }
    }// end of TestTheGuess function




} // end of class strings
