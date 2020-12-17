
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip coinPickupSound;
  //  static AudioScource audioSrc;


    void Start()
    {

        coinPickupSound = Resources.Load<AudioClip>("coinPickUp");

     //   audioSrc = GetComponent<AudioScource>();


        /*
    }

        public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "coinPickup":
                audioSrc.PlayOneShot(coinPickupSound);

                break;

         }
 */
    } 





 
}
