using System;
using UnityEngine;
using TMPro;

public class AssignTheBinaryCode : MonoBehaviour
{
    public TMP_Text m_text;
    public string[] binaryCodes = new string[8];


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        m_text.text = binaryCodes[Int32.Parse(other.name)];
    }
}
