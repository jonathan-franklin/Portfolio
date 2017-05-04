using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public void CloseApplication (string quit)
    {
        if (quit == "quit")
        {
            Application.Quit();
        }
    }
}
