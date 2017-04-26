// File Prologue
// Name: Jonathan Franklin
// Project: While Loops
// Date: February 22, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

/// <summary>
/// This is a simple game that is played by the computer. The objective is to guess a random number between 0 and 99. Every wrong answer,
/// the distance between the correct answer and the minimum and maximum possible values is halved, so that it becomes progressively easier
/// for the computer to win as the game goes on. Attempt details and final scoring information is displayed in the Unity console.
/// </summary>

public class WhileLoops : MonoBehaviour
{

    // Declaring class variables
    private int randomGuess;
    private int minRange;
    private int maxRange;
    private int targetNumber;
    private int negSpread;
    private int posSpread;
    private int attemptCount;
    private bool isCorrect;

    // Declaring class constants
    private const int SPREAD_DIVIDER = 2;
    private const int TIMER_INCREMENT = 1;
   
    // Un-parameterized constructor
    public WhileLoops()
    {
        randomGuess = 1;
        minRange = 0;
        maxRange = 100;
        targetNumber = 0;
        negSpread = 0;
        posSpread = 0;
        attemptCount = 0;
        isCorrect = false;
    }

	// Use this for initialization
	void Start ()
    {
        createTarget(); // Declares random targetNumber value
        win();
    }

    // This method creates the target number, and is run at the beginning of the script.
    public void createTarget()
    {
        System.Random targetRandom = new System.Random();
        targetNumber = targetRandom.Next(minRange, maxRange);
    }

    // This method creates a guess and checks for a match with the target.
    public void guess()
    {
        randomGuess = UnityEngine.Random.Range(minRange, maxRange); 

        if (randomGuess == targetNumber) // If the guess is equal to the target, isCorrect is changed to true. See win() to see what happens next.
        {
            isCorrect = true;
        }
    }

    // This method changes the min and max ranges after each guess to be closer to the target number.
    // It does this by halving the distance between the targetNumber and the min/maxRange values.
    public void reassign()
    {
        negSpread = targetNumber - minRange;
        posSpread = maxRange - posSpread;
        minRange = targetNumber - (negSpread / SPREAD_DIVIDER); // SPREAD_DIVIDER = 2
        maxRange = targetNumber + (posSpread / SPREAD_DIVIDER);
    }

    // This method tests for the win condition and displays a congratulations message if it is satisfied.
    public void win()
    {
        while (isCorrect == false)
        {
            guess();
            reassign();
            attemptCount++;
            print("On attempt " + attemptCount + " you guessed " + randomGuess + ".");
        }

        print("Congratulations! You have won after " + attemptCount + " attempts. The correct answer was " + targetNumber + "."); // Win Message.
    }

}
