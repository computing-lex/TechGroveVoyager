using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckTheWaveForm : MonoBehaviour
{
    public TMP_Text m_text;
    public string[] binaryCodes = new string[8];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        m_text.text = binaryCodes[Int32.Parse(other.name)];
    }
}
