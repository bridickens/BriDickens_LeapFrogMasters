using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    private static int playerTwoScore;
    //If the player collides with the other, increment score
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            playerTwoScore += 1;
            Debug.Log("Player two has a score of: " + playerTwoScore);
        }
    }
}
