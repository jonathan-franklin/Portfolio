// File Prologue
// Name: Jonathan Franklin
// Project: DivisibleByThree Extra Credit
// Date: April 2, 2017

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisibleByThree : MonoBehaviour
{
    // Declaring class variables
    public float min;
    public float max;
    private const int COUNT = 100;

    List<float> hundredRandomValues = new List<float>();

    // Unparameterized Constructor
    public DivisibleByThree()
    {
        min = 0;
        max = 0;
    }

    // Parameterized Constructor
    public DivisibleByThree(float mi, float ma)
    {
        min = mi;
        max = ma;
    }

    // This method calls the following methods at runtime
    void Start()
    {
        SetList();
        GetArray();
    }

    // This method generates a list using RandomNumberListGenerator.SetListContents()
    public List<float> SetList ()
    {
        RandomNumberListGenerator listGen = GetComponent<RandomNumberListGenerator>(); // Creating object listGen from RandomNumberListGenerator
        listGen.min = min; // Setting listGen min variable to local min value
        listGen.max = max; // Setting listGen max variable to local max value
        listGen.count = COUNT; // Setting listGen count variable to local COUNT constant value

        hundredRandomValues.AddRange(listGen.SetListContents()); // This adds list elements created by listGen.SetListContents() to local list hundredRandomValues

        return hundredRandomValues; // Return list hundredRandomValues
    }

    // This method removes list elements that are not divisible by three from hundredRandomValues and moves those values to an array
    public float[] GetArray ()
    {
        List<float> itemsToRemove = new List<float>(); // Child list of entities to remove from main list

        // For each float f in our list hundredRandomValues that is not divisible by three, we will add that number to list itemsToRemove
        foreach (float f in hundredRandomValues)
        {
            if (f % 3.000000f != 0)
            {
                itemsToRemove.Add(f);
            }
        }

        // Every value in child list itemsToRemove will be removed from hundredRandomValues
        foreach (float f in itemsToRemove)
        {
            hundredRandomValues.Remove(f);
        }

        // This next statement moves all elements from hundredRandomValues to a float array named "thirds"
        float[] thirds = hundredRandomValues.ToArray();

        // This following block sorts the array in descending order
        Array.Sort<float>(thirds,
        new Comparison<float>(
                (i1, i2) => i2.CompareTo(i1)
        ));

        // Every item in array "thirds" will be printed to console
        foreach (object o in thirds)
        {
            print(o);
        }

        return thirds;
    }

}
