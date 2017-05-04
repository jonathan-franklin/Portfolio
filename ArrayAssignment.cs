using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAssignment : MonoBehaviour
{
    // Defining class variables and array
    private string[] ageArray = {"Man", "Dinosaurs", "Steel", "Steam", "Machines"};
    private string[] raceOneArray = {"Humans", "Mole People", "Dog People", "Mysterious Alien Race", "Machines" };
    private string[] raceTwoArray = {"Dolphins", "Humans", "Cat People", "Whovians", "Undead" };
    private string[] yearsArray = {"three thousand", "two", "a million", "thirty-seven years", "thirteen" };
    private string[] describerArray = {"misery", "bloodshed", "zaniness", "passive-aggressive cat throwing", "being done" };
    private string[] marryOneArray = {"Gregg", "Susan", "Jim", "Alphys of Astoria", "Emil" };
    private string[] marryTwoArray = {"Anthony", "George Washington", "Captain Planet", "Zorg", "the Undertaker" };
    private string[] aftermathArray = {"happy", "miffed", "fucking pleased with it", "bored", "ready to die" };
    private string[] cosmicBeingArray = {"owl", "serpent", "entity", "boredom", "doggo" };
    private string[] consumedArray = {"world", "universe", "souls of the elderly", "firstborn", "sea" };


    // Use this for initialization
    void Start ()
    {
        story();
    }
	
    public void story ()
    {
        print("In the age of " + ageArray[Random.Range(0, ageArray.Length)] + ", a great war broke out between the " + raceOneArray[Random.Range(0, raceOneArray.Length)] + " and the " + raceTwoArray[Random.Range(0, raceTwoArray.Length)] + ". After " + yearsArray[Random.Range(0, yearsArray.Length)] + " years of conflict and " + describerArray[Random.Range(0, describerArray.Length)] + ", a peace treaty was brokered. A royal marriage was arranged between " + marryOneArray[Random.Range(0, marryOneArray.Length)] + " and " + marryTwoArray[Random.Range(0, marryTwoArray.Length)] + ", and the world was " + aftermathArray[Random.Range(0, aftermathArray.Length)] + ". Thirty years later, a cosmic " + cosmicBeingArray[Random.Range(0, cosmicBeingArray.Length)] + " emerged and consumed the " + consumedArray[Random.Range(0, consumedArray.Length)] + ". The end.");
    }


}
