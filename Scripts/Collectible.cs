using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        //send info to player (simillar to groundchecker)
        collision.gameObject.GetComponent<Inventory>();

        Destroy(gameObject);

    }

}
