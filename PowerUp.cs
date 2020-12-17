using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

   // public float multiplier = 1.4f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Pickup(other);


          //  Destroy(gameObject);
        }
    }

    void Pickup(Collider2D player)
    {
      //  Player stats = player.GetComponent<Player>();
       // stats.currentHealth *= multiplier;

        Destroy(gameObject);
    }

}
