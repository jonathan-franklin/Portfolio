using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject gameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("GAME OVER");
        gameOver = true;

        gameOverPanel.gameObject.SetActive(true);
    }

}
