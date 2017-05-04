using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text counter;
    public int points;
    public const int POINT_SCALE = 10;

	// Use this for initialization
	void Start ()
    {
        points = 0;
        counter.text = "0";
	}
	
    public void addPoints ()
    {
        int newPoints;
        newPoints = points + POINT_SCALE;
        points = newPoints;

        counter.text = "" + points;
    }
}
