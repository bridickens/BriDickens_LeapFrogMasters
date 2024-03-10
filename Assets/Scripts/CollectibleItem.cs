using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;
    [SerializeField] private float speedIncrease = 5;
    [SerializeField] private float duration = 1;
    private void OnTriggerEnter(Collider other)
    {
        P1Controller player = other.gameObject.GetComponent<P1Controller>();
        P2Controller player2 = other.gameObject.GetComponent<P2Controller>();
        if (player != null)
        {
            StartCoroutine(SpeedUp(player));
        }
        if(player2 != null)
        {
            StartCoroutine(SpeedUp2(player2));
        }
        Debug.Log($"Item collected: {itemName}");
        
        Managers.Inventory.AddItem(itemName);

        this.gameObject.GetComponent<Renderer>().enabled = false;

    }

    public IEnumerator SpeedUp(P1Controller player)
    {
        ActivatePowerup(player);
        yield return new WaitForSeconds(duration);
        DeactivatePowerup(player);
        Destroy(this.gameObject);


    }
    public IEnumerator SpeedUp2(P2Controller player2)
    {
        ActivatePowerup2(player2);
        yield return new WaitForSeconds(duration);
        DeactivatePowerup2(player2);
        Destroy(this.gameObject);


    }

    private void ActivatePowerup(P1Controller player)
    {
        player.NewSpeedIncrease(speedIncrease);
    }
    private void DeactivatePowerup(P1Controller player)
    {
        player.NewSpeedIncrease(-speedIncrease);
    }

    private void ActivatePowerup2(P2Controller player2)
    {
        player2.NewSpeedIncrease(speedIncrease);
    }
    private void DeactivatePowerup2(P2Controller player2)
    {
        player2.NewSpeedIncrease(-speedIncrease);
    }
}
