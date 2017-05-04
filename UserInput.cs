// File Prologue
// Name: Jonathan Franklin
// Project: Calculator Command
// Date: April 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public InputField functionInputField;
    public Text target;
    public TargetBehavior targetBehavior;
    public GameObject targetObject;
    public GameObject addButton;
    public GameObject subtractButton;
    public GameObject multiplyButton;
    public GameObject divideButton;
    public GameObject moduloButton;
    public GameObject pointCounter;

    // Declaring class variables
    public float inputOne = 0;
    public float inputTwo = 0;
    public float currentInput = 0;
    public string currentOperator;
    public float result;
    public bool resultAchieved = false;

    // Declaring class constants
    public const int TEN_MULTIPLIER = 10;

    // List recording which mathematical operators have been used.
    List<string> operators = new List<string>();


    // This method sets the behaviors when various buttons are clicked.
    public void clickNumberButton (string numberClicked)
    {
        // The following two lines ensure that the input field correctly displays what the user is inputting.
        string currentString = functionInputField.text;
        string newString = currentString + numberClicked;

        if (numberClicked == "1" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 1;
            newString = "1";
            resultAchieved = false;
        }
        else if (numberClicked == "2" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 2;
            newString = "2";
            resultAchieved = false;
        }
        else if (numberClicked == "3" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 3;
            newString = "3";
            resultAchieved = false;
        }
        else if (numberClicked == "4" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 4;
            newString = "4";
            resultAchieved = false;
        }
        else if (numberClicked == "5" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 5;
            newString = "5";
            resultAchieved = false;
        }
        else if (numberClicked == "6" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 6;
            newString = "6";
            resultAchieved = false;
        }
        else if (numberClicked == "7" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 7;
            newString = "7";
            resultAchieved = false;
        }
        else if (numberClicked == "8" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 8;
            newString = "8";
            resultAchieved = false;
        }
        else if (numberClicked == "9" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 9;
            newString = "9";
            resultAchieved = false;
        }
        else if (numberClicked == "0" && resultAchieved == true)
        {
            currentInput = currentInput * TEN_MULTIPLIER;
            newString = "";
            resultAchieved = false;
        }
        else if (numberClicked == "1" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 1;
        }
        else if (numberClicked == "2" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 2;
        }
        else if (numberClicked == "3" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 3;
        }
        else if (numberClicked == "4" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 4;
        }
        else if (numberClicked == "5" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 5;
        }
        else if (numberClicked == "6" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 6;
        }
        else if (numberClicked == "7" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 7;
        }
        else if (numberClicked == "8" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 8;
        }
        else if (numberClicked == "9" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER + 9;
        }
        else if (numberClicked == "0" && resultAchieved == false)
        {
            currentInput = currentInput * TEN_MULTIPLIER;
        }
        else if (numberClicked == "+" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "+";
            currentInput = 0;
            operators.Add("+");

            // The following if statement resets all operator buttons to active after they have each been used.
            if (operators.Contains("+") && operators.Contains("-") && operators.Contains("*") && operators.Contains("/") && operators.Contains("%"))
            {
                operators.Remove("+");
                operators.Remove("-");
                operators.Remove("*");
                operators.Remove("/");
                operators.Remove("%");
                addButton.GetComponent<Button>().interactable = true;
                subtractButton.GetComponent<Button>().interactable = true;
                multiplyButton.GetComponent<Button>().interactable = true;
                divideButton.GetComponent<Button>().interactable = true;
                moduloButton.GetComponent<Button>().interactable = true;
            }
            // The following else statement sets a button to inactive if there are other operator buttons that have not yet been used.
            else
            {
                addButton.GetComponent<Button>().interactable = false;
            }
        }
        else if (numberClicked == "-" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "-";
            currentInput = 0;
            operators.Add("-");

            // The following if statement resets all operator buttons to active after they have each been used.
            if (operators.Contains("+") && operators.Contains("-") && operators.Contains("*") && operators.Contains("/") && operators.Contains("%"))
            {
                operators.Remove("+");
                operators.Remove("-");
                operators.Remove("*");
                operators.Remove("/");
                operators.Remove("%");
                addButton.GetComponent<Button>().interactable = true;
                subtractButton.GetComponent<Button>().interactable = true;
                multiplyButton.GetComponent<Button>().interactable = true;
                divideButton.GetComponent<Button>().interactable = true;
                moduloButton.GetComponent<Button>().interactable = true;
            }
            // The following else statement sets a button to inactive if there are other operator buttons that have not yet been used.
            else
            {
                subtractButton.GetComponent<Button>().interactable = false;
            }
        }
        else if (numberClicked == "*" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "*";
            currentInput = 0;
            operators.Add("*");

            // The following if statement resets all operator buttons to active after they have each been used.
            if (operators.Contains("+") && operators.Contains("-") && operators.Contains("*") && operators.Contains("/") && operators.Contains("%"))
            {
                operators.Remove("+");
                operators.Remove("-");
                operators.Remove("*");
                operators.Remove("/");
                operators.Remove("%");
                addButton.GetComponent<Button>().interactable = true;
                subtractButton.GetComponent<Button>().interactable = true;
                multiplyButton.GetComponent<Button>().interactable = true;
                divideButton.GetComponent<Button>().interactable = true;
                moduloButton.GetComponent<Button>().interactable = true;
            }
            // The following else statement sets a button to inactive if there are other operator buttons that have not yet been used.
            else
            {
                multiplyButton.GetComponent<Button>().interactable = false;
            }
        }
        else if (numberClicked == "/" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "/";
            currentInput = 0;
            operators.Add("/");

            // The following if statement resets all operator buttons to active after they have each been used.
            if (operators.Contains("+") && operators.Contains("-") && operators.Contains("*") && operators.Contains("/") && operators.Contains("%"))
            {
                operators.Remove("+");
                operators.Remove("-");
                operators.Remove("*");
                operators.Remove("/");
                operators.Remove("%");
                addButton.GetComponent<Button>().interactable = true;
                subtractButton.GetComponent<Button>().interactable = true;
                multiplyButton.GetComponent<Button>().interactable = true;
                divideButton.GetComponent<Button>().interactable = true;
                moduloButton.GetComponent<Button>().interactable = true;
            }
            // The following else statement sets a button to inactive if there are other operator buttons that have not yet been used.
            else
            {
                divideButton.GetComponent<Button>().interactable = false;
            }
        }
        else if (numberClicked == "%" && inputOne == 0)
        {
            inputOne = currentInput;
            currentOperator = "%";
            currentInput = 0;
            operators.Add("%");

            // The following if statement resets all operator buttons to active after they have each been used.
            if (operators.Contains("+") && operators.Contains("-") && operators.Contains("*") && operators.Contains("/") && operators.Contains("%"))
            {
                operators.Remove("+");
                operators.Remove("-");
                operators.Remove("*");
                operators.Remove("/");
                operators.Remove("%");
                addButton.GetComponent<Button>().interactable = true;
                subtractButton.GetComponent<Button>().interactable = true;
                multiplyButton.GetComponent<Button>().interactable = true;
                divideButton.GetComponent<Button>().interactable = true;
                moduloButton.GetComponent<Button>().interactable = true;
            }
            // The following else statement sets a button to inactive if there are other operator buttons that have not yet been used.
            else
            {
                moduloButton.GetComponent<Button>().interactable = false;
            }
        }
        // This block does calculations and resets values when the enter button is pressed.
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "+" && currentInput != 0)
        {
            inputTwo = currentInput;
            result = inputOne + inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
            resultAchieved = true;
            
            // This block checks whether the user's input was correct, and resets the target if so.
            if (newString == target.text)
            {
                targetObject.GetComponent<TargetBehavior>().targetReset();
                pointCounter.GetComponent<PointCounter>().addPoints();
            }
        }
        // This block does calculations and resets values when the enter button is pressed.
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "-" && currentInput != 0)
        {
            inputTwo = currentInput;
            result = inputOne - inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
            resultAchieved = true;

            // This block checks whether the user's input was correct, and resets the target if so.
            if (newString == target.text)
            {
                targetObject.GetComponent<TargetBehavior>().targetReset();
                pointCounter.GetComponent<PointCounter>().addPoints();
            }
        }
        // This block does calculations and resets values when the enter button is pressed.
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "*" && currentInput != 0)
        {
            inputTwo = currentInput;
            result = inputOne * inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
            resultAchieved = true;

            // This block checks whether the user's input was correct, and resets the target if so.
            if (newString == target.text)
            {
                targetObject.GetComponent<TargetBehavior>().targetReset();
                pointCounter.GetComponent<PointCounter>().addPoints();
            }
        }
        // This block does calculations and resets values when the enter button is pressed.
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "/" && currentInput != 0)
        {
            inputTwo = currentInput;
            result = inputOne / inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
            resultAchieved = true;

            // This block checks whether the user's input was correct, and resets the target if so.
            if (newString == target.text)
            {
                targetObject.GetComponent<TargetBehavior>().targetReset();
                pointCounter.GetComponent<PointCounter>().addPoints();
            }
        }
        // This block does calculations and resets values when the enter button is pressed.
        else if (numberClicked == "Enter" && inputOne != 0 && inputTwo == 0 && currentOperator == "%" && currentInput != 0)
        {
            inputTwo = currentInput;
            result = inputOne % inputTwo;
            print(result);

            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "" + result;
            resultAchieved = true;

            // This block checks whether the user's input was correct, and resets the target if so.
            if (newString == target.text)
            {
                targetObject.GetComponent<TargetBehavior>().targetReset();
                pointCounter.GetComponent<PointCounter>().addPoints();
            }
        }
        // This block resets values when the enter button is pressed before an operator is used.
        else if ((numberClicked == "Enter" && currentInput == 0) || currentOperator == "")
        {
            inputOne = 0;
            inputTwo = 0;
            currentInput = 0;
            currentOperator = "";

            newString = "";
        }

        // This statement updates the input field's text value to reflect the current user input.
        functionInputField.text = newString;
    }

}
