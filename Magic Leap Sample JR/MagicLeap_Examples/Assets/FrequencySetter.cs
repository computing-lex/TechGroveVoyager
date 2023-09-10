using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencySetter : MonoBehaviour
{

    public LineRenderer frequencyWave;
    int frequency;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (frequency == 0)
        {
            for (int i = 0;i<30;i++)
            {
              Vector3 currentPosition = frequencyWave.GetPosition(i);
              Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
              frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 1)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 2)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 3)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 4)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 5)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 6)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        if (frequency == 7)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
    }
}
