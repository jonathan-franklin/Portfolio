using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FINAL : MonoBehaviour 
{
	public InputField BasicOperationsParameterOne;
	public InputField BasicOperationsParameterTwo;
	public InputField ValueInputField;
	public InputField UnitInputField;
	public InputField WestwardSpeed;
	public InputField EastwardSpeed;
	public InputField Time;

	// This method prints "Hello", followed by my name and the system time.
	public void Hello ()
	{
		print ("Hello");
		print ("My name is Jonathan Franklin");
		print(System.DateTime.Now);
	}

	// This is the method the button calls when pressed in order to run BasicOperations with the user inputted parameters.
	public void BasicOperationsOnClick ()
	{
		BasicOperations (double.Parse (BasicOperationsParameterOne.text), double.Parse (BasicOperationsParameterTwo.text));
	}

	// This method takes two parameters and adds, subtracts, multiplies, and divides them, then prints the results.
	public void BasicOperations (double x, double y)
	{
		double result = 0;

		result = x + y;
		print(x + " + " + y + " = " + result);

		result = x - y;
		print(x + " - " + y + " = " + result);

		result = x * y;
		print(x + " * " + y + " = " + result);

		result = x / y;
		print(x + " / " + y + " = " + result);
	}

	// This method averages a list of random numbers and prints the result;
	public void Average ()
	{
		List<int> integerList = new List<int>();
		double average = 0;

		// Adding some random values to the list to be calculated.
		integerList.Add (Random.Range(1, 100));
		integerList.Add (Random.Range(1, 100));
		integerList.Add (Random.Range(1, 100));
		integerList.Add (Random.Range(1, 100));
		integerList.Add (Random.Range(1, 100));

		average = (integerList[0] + integerList[1] + integerList[2] + integerList[3] + integerList[4]) / integerList.Count;
		print("The average of five random numbers between 1 and 99 is " + average + ".");
	}

	// Runs UnitConversion using UI values.
	public void UnitConversionOnClick ()
	{
		UnitConversion (int.Parse(ValueInputField.text), UnitInputField.text);
	}

	// Converts feet to inches, or vice versa, depending on the arguments.
	public void UnitConversion (int x, string units)
	{
		double convertedUnit;
		const int CONVERSION_FACTOR = 12;

		if (units == "feet" || units == "foot" || units == "Feet" || units == "Foot") 
		{
			convertedUnit = x *	CONVERSION_FACTOR;
			print (convertedUnit + " inches");
		} 
		else if (units == "inches" || units == "inch" || units == "Inches" || units == "Inch") 
		{
			convertedUnit = x / CONVERSION_FACTOR;
			print (convertedUnit + " feet");
		} 
		else 
		{
			print ("Please enter either feet/foot or inch/inches for the unit.");
		}
	}

	// Runs TrainProblem() with UI values.
	public void TrainProblemOnClick ()
	{
		TrainProblem (int.Parse(WestwardSpeed.text), int.Parse(EastwardSpeed.text), int.Parse(Time.text));
	}

	// Calculates the distance of two trains leaving from the same location but in opposite directions.
	public void TrainProblem (int speedOne, int speedTwo, int hours)
	{
		int westDistance = speedOne * hours;
		int eastDistance = speedTwo * hours;
		int trainSpread = westDistance + eastDistance;

		print ("The trains are " + trainSpread + " miles apart from each other.");
	}
}
