using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAtomImage : MonoBehaviour
{
    public Image leftImage;
    public Image rightImage;

    public void checkAtoms()
    {
        if(leftImage.sprite.name == "Hydrogen1" &&  rightImage.sprite.name == "Hydrogen2")
        {
            Debug.Log("Good");
        }
        else
        {
            Debug.Log("Bad");
        }
    }
}
