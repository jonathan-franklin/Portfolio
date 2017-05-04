// File Prologue
// Name: Jonathan Franklin
// Project: RandomNumberListGenerator Extra Credit
// Date: April 2, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberListGenerator : MonoBehaviour
{
    // Declaring class variables
    public float min;
    public float max;
    public int count;

    // Un-parameterized Constructor
    public RandomNumberListGenerator ()
    {
        min = 0;
        max = 0;
        count = 0;
    }

    // Parameterized Constructor
    public RandomNumberListGenerator (float mi, float ma, int co)
    {
        min = mi;
        max = ma;
        count = co;
    }

	// Use this for initialization
	void Start ()
    {
        GetListContents();
	}
	
    // This method creates a list of random floats.
    public List<float> SetListContents () 
    {
        float randomFloat = 0;
        List<float> randomFloatList = new List<float>();

        // For defined count, add random float between defined min and max to RnadomFloatList list.
        for (int i = 0; i < count; i++)
        {
            randomFloat = Random.Range(min, max);
            randomFloatList.Add(randomFloat);
        }

        return randomFloatList; // Return list.
    }

    // This method prints all the contents of randomFloatList.
    public void GetListContents ()
    {
        foreach (object o in SetListContents())
        {
            print(o);
        }
    }
}
