using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collison2 : MonoBehaviour
{
    
    private static int playerOneScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            ScoreManager.instance.AddPoint();
            playerOneScore += 1;
            Debug.Log("Player one has a score of: " + playerOneScore);
        }
    }
}
