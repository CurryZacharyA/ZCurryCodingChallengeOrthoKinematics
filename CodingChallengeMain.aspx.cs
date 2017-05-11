using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    /*
     * Using C#, write a web-api method that parses a sentence and replaces each word with the 
     * following: first letter, number of distinct characters between first and last character,
     * and last letter. For example, Patterns would become P5s. Words are separated by spaces or
     * non-alphabetic characters and these separators should be maintained in their original
     * form and location in the answer. 
     * 
     * 3rd party applications need to be authenticated before they call the method.
     * Try not to use helper methods for string manipulation, try to write your own algorithms
     * Include documentation on how to call your api
     * Include test cases and the results in your solution 
     * 
     * We are looking for accuracy, efficiency and solution completeness. Please include
     * this problem description in the comment at the top of your solution. 
     */

public partial class CodingChallengeMain : System.Web.UI.Page
{
    string strEnteredSentence;
    string strParsedSentence;
    string strWordToCheck = "";
    string strLettersFound = "";
    Boolean nextWord = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        //user cannot use or load the page unless logined in with the correct credentials
        if (Session["User"] != "User01")
            Response.Redirect("Authentication.aspx");
    }

    protected void Enter_Click(object sender, EventArgs e) {
        strEnteredSentence = tbEnterSentence.Text.ToString() + " ";

        //check entire sentence, character by character
        for (int i = 0; i < strEnteredSentence.Length - 1; i++) {
            checkIfLetter(strEnteredSentence.Substring(i, 1).ToUpper());
            if (nextWord == false)
                strWordToCheck += strEnteredSentence.Substring(i, 1);
                //add character to a "word" if it is a-z or A-Z
            else {
                //otherwise, end forming a "word" and keep character
                strParsedSentence += checkWord(strWordToCheck);
                strParsedSentence += strEnteredSentence.Substring(i, 1);
                strWordToCheck = "";
                strLettersFound = "";
                nextWord = false;
            }
        }
        strParsedSentence += checkWord(strWordToCheck);

        tbParsedSentence.Text = strParsedSentence;
    }

    protected string checkWord(string strWordToCheck) {
        string strNewWord = strWordToCheck;
        if (strWordToCheck.Length > 0) {
            //first letter will stay the same
            strNewWord = strWordToCheck.Substring(0, 1);
            if (strWordToCheck.Length > 2) {
                //word must be atlease 3 characters
                for (int i = 1; i < strWordToCheck.Length - 1; i++) {
                    //form list of characters if unique
                    strLettersFound = checkForRepetedLetter(strWordToCheck.Substring(i, 1).ToUpper());
                }
                //count length of unique characters list and add to the new word
                strNewWord += strLettersFound.Length.ToString();
            }
            //ending letter will be the same
            strNewWord += strWordToCheck.Substring(strWordToCheck.Length - 1, 1);
        }
        return strNewWord;
    }

    protected void checkIfLetter(string strLetter) {
        switch (strLetter) {
            case "A":
            case "B":
            case "C":
            case "D":
            case "E":
            case "F":
            case "G":
            case "H":
            case "I":
            case "J":
            case "K":
            case "L":
            case "M":
            case "N":
            case "O":
            case "P":
            case "Q":
            case "R":
            case "S":
            case "T":
            case "U":
            case "V":
            case "W":
            case "X":
            case "Y":
            case "Z":
                break;
            default:
                nextWord = true;
                break;
        }
    }

    protected string checkForRepetedLetter(string strLetter) {
        string strCharacter;

        switch (strLetter) {
            case "A":
                strCharacter = "A";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "B":
                strCharacter = "B";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "C":
                strCharacter = "C";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "D":
                strCharacter = "D";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "E":
                strCharacter = "E";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "F":
                strCharacter = "F";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "G":
                strCharacter = "G";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "H":
                strCharacter = "H";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "I":
                strCharacter = "I";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "J":
                strCharacter = "J";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "K":
                strCharacter = "K";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "L":
                strCharacter = "L";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "M":
                strCharacter = "M";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "N":
                strCharacter = "N";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "O":
                strCharacter = "O";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "P":
                strCharacter = "P";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "Q":
                strCharacter = "Q";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "R":
                strCharacter = "R";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "S":
                strCharacter = "S";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "T":
                strCharacter = "T";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "U":
                strCharacter = "U";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "V":
                strCharacter = "V";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "W":
                strCharacter = "W";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "X":
                strCharacter = "X";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "Y":
                strCharacter = "Y";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
            case "Z":
                strCharacter = "Z";
                strLettersFound += addDistinctCharacters(strCharacter, strLettersFound);
                break;
        }
        return strLettersFound;
    }

    protected string addDistinctCharacters(string strCharacter, string strLettersFound) {
        Boolean checkForSameLetter = false;
        string strLetterAdded = strCharacter;

        //if checking the first letter, skip to the end
        if (strLettersFound.Length > 0) {
            for (int i = 0; i < strLettersFound.Length; i++) {
                //check the list of current unique characters
                if (strLettersFound.Substring(i,1).ToString() == strCharacter) {
                    //if not a unique character, change boolean
                    checkForSameLetter = true;
                }
            }
        }
        else checkForSameLetter = false;
        if (checkForSameLetter)
            //if not unique, return nothing to add to unique list
            return "";
        else
            //add letter to unique list
            return strLetterAdded;
    }
}