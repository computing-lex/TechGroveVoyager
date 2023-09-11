using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckTheBinaryCode : MonoBehaviour
{
    public TMP_Text textField;

    public AudioSource goodSound;
    public AudioSource badSound;
    public AudioSource clickSound;

    public void checkAtoms()
    {
        clickSound.PlayOneShot(clickSound.clip);
        if (textField.text == "100110000110010000000000000000000")
        {
            goodSound.PlayDelayed(1);
            GameObject.FindObjectOfType<GameManager>().numberOfPuzzles++;
        }
        else
        {
            badSound.PlayDelayed(1);
        }
    }
}
