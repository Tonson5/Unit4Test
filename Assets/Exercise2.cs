using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public GameObject rainDrop;
    public GameObject rainSpawn;

    
    void Rain(int drops)
    {
        for (int i = 0; i < drops; i++)
        {
            Instantiate(rainDrop, rainSpawn.transform.position,rainSpawn.transform.rotation);
        }
    }

    /**********************************
     * Write a method called Rain
     * 
     * Allow the user to enter an integer called drops
     * Use a FOR loop to instantiate the number of raindrops
     * indicated by the user.  Instantiate them at the rainSpawn
     * location.
     *********************************/
   
 
    void Update()
    {
        //If the user presses the R key, call Rain(10);
      if (Input.GetKeyDown(KeyCode.R))
        {
            Rain(10);
        }
    }
}
