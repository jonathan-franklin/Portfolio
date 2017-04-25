// File Prologue
// Name: Jonathan Franklin
// Project: Else Assignment
// Date: February 15, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script creates a little game in the console for the user to play. The objective is simple. Using the up key,
/// the user must rise to 2500 km. Every up key press increases their elevation by 100 km. However, as time goes by,
/// so does their downward velocity, as they are being acted on by gravity at a rate of 10 km/s^s. Pretty strong, obviously.
/// So it is up to the user to achiever their goal before their downward acceleration outpaces their upward.
/// 
/// NOTE: THE NEW GAME FEATURE AFTER WINNING THE FIRST TIME IS NOT YET IMPLEMENTED.
/// </summary>
/// 

/* Here is a brief explainer on else statements. Else statements provide an alternate course of action if the preceding
 * if-statement is not satisfied. Furthermore, an else-if statement can provide multiple alternate courses of action. Each
 * else-if has its own test condition, and if none of those are satisifed, then the final else block is executed as the default. */

public class ElseAssignment : MonoBehaviour
{
    // Declaring class variables
    private int altitude;
    private int velocity;
    private int gravity;
    private bool win;

    // Un-parameterized Constructor
    public ElseAssignment()
    {
        altitude = 0;
        velocity = 0;
        gravity = 0;
        win = false;
    }

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(MyUpdate());
        InvokeRepeating("AltitudeDisplay", 0.0f, 1.0f); // Display altitude once per second.
        InvokeRepeating("Velocity", 0.0f, 1.0f); // Recalculate velocity once per second.
        InvokeRepeating("AltitudeSubtraction", 0.0f, 1.0f); // Recalculate altitude drop due to gravity once per second.
    }

    IEnumerator MyUpdate()
    {
        while (win == false) // The methods called here will run each frame as long as the win bool is false.
        {
            Acceleration(); // Check whether player is above zero every frame.
            AltitudeAddition(); // Check for player input every frame.
            yield return null;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        Win(); // Check for win condition every frame.
	}

    // The purpose of this method is to display the current altitude in the console.
    public void AltitudeDisplay()
    {
        print("Your current altitude is " + altitude + " km.");
    }

    // This method checks if the altitude is greater than zero, and if so, it activates the gravity value.
    public void Acceleration()
    {
        if (altitude <= 0)
        {
            gravity = 0;
        }
        else
        {
            gravity = 10;
        }
    }

    // If the gravity is activated, it begins adding the gravity value to the velocity value. Else, velocity is zero.
    public void Velocity()
    {
        if (win == false)
          if (gravity == 10)
            {
                velocity += gravity;
            }   
            else
            {
                velocity = 0;
            }
        else
        {
            return;
        }
    }

    // This method adds 100km every time the user presses the Up arrow key.
    public void AltitudeAddition()
    {
        if (win == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                altitude += 100;
            }
        }
        else
        {
            return;
        }

    }

    // This method subtracts the appropriate amount of elevation from altitude to emulate gravity.
    public void AltitudeSubtraction()
    {
        if (win == false)
        {
            // If the altitude is greater than zero, begin subtracting for gravity.
            if (altitude > 0)
            {
                altitude = altitude - velocity;
            }
            // Else, reset altitude and velocity to zero.
            else
            {
                altitude = 0;
                velocity = 0;
            }
        }
        else
        {
            return;
        }

    }

    // This method checks if the win condition is satisfied and provides a replay prompt if it is.
    public void Win()
    {
        if (altitude >= 2500) // The user must reach 2500 km to win the game.
        {
            CancelInvoke(); // This stops all invoked repeating methods.
            win = true;
            print("YOU DID IT. CONGRATULATIONS!");
            print("Do you want to play again? Y/N");

            // If the user presses Y, the script is reloaded.
            if (Input.GetKeyDown(KeyCode.Y))
            {
                altitude = 0;
                velocity = 0;
                gravity = 0;
                win = false;

                StartCoroutine(MyUpdate());
                InvokeRepeating("AltitudeDisplay", 0.0f, 1.0f); // Display altitude once per second.
                InvokeRepeating("Velocity", 0.0f, 1.0f); // Recalculate velocity once per second.
                InvokeRepeating("AltitudeSubtraction", 0.0f, 1.0f); // Recalculate altitude drop due to gravity once per second.
            }
            // Else, the script is terminated.
            else
            {
                End();
            }
        }
    }

    // This method terminates the script when called.
    public void End()
    {
        this.enabled = false;
    }


}
