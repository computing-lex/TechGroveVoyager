using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAtomImage : MonoBehaviour
{
    public Image leftImage;
    public Image rightImage;

    public AudioSource clickSound;
    public AudioSource goodSound;
    public AudioSource badSound;

    public void checkAtoms()
    {
        clickSound.Play();
        if(leftImage.sprite.name == "Hydrogen1" &&  rightImage.sprite.name == "Hydrogen2")
        {
            goodSound.PlayDelayed(1);
            Debug.Log("Good");
        }
        else
        {
            badSound.PlayDelayed(1);
            Debug.Log("Bad");
        }
    }
}
