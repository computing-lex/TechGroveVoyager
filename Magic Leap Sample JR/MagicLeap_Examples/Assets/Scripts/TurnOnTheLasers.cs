using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTheLasers : MonoBehaviour
{

    public GameManager theManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "LaserOrigin")
        {
            for(int i = 0; i < 3; i++) 
            {
                theManager.lasers[i].enabled = true;
            }
        }
    }
}
