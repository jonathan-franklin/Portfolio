using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetBehavior : MonoBehaviour
{
    public Text target;
    public PanelTrigger panelTrigger;
    Vector2 startPos;
    public float x;
    public float y;


	// Use this for initialization
	void Start ()
    {
        targetReset();
	}
	
	// Update is called once per frame
	void Update ()
    {
        TargetMovement();
    }

    public void TargetMovement ()
    {
        if (panelTrigger.gameOver == false)
        transform.Translate(Vector2.down, Space.World);
    }

    public void targetReset()
    {
        target.text = "" + Random.Range(1, 100);

        x = Random.Range(10f, 490f);
        y = 420f;
        startPos = new Vector2(x, y);
        transform.position = startPos;
    }

}
