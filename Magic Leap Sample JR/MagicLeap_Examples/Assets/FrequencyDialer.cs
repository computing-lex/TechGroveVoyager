using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyDialer : MonoBehaviour
{
    public LineRenderer frequencyLine;

    private void Update()
    {
        for(int i = 0; i < 25; i++)
        {
            Vector3 currentPosition = frequencyLine.GetPosition(i);
            Vector3 newPosition = new Vector3(currentPosition.x,Random.Range(0.1f,0.3f),currentPosition.z);
            frequencyLine.SetPosition(i, newPosition);    
        }
    }
}
