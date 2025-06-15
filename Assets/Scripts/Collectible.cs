using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public int value;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //TODO send info to player
        Inventory playerInventory = null;
        playerInventory = collision.gameObject.GetComponent<Inventory>();
        //playerInventory.
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Inventory.instance.Increasecollectible(value);
        }

    }


}
