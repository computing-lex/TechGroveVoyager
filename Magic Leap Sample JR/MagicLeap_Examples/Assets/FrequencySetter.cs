using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencySetter : MonoBehaviour
{

    public LineRenderer frequencyWave;
    int frequency;
    bool frequencyChanged = false;
    float[] yFrequency = new float[30];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            yFrequency[i] = frequencyWave.GetPosition(i).y;
        }
    }

    private void Update()
    {
        if (!frequencyChanged)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, Random.Range(-0.05f, 0.05f), currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
    }

    public void RunTheFrequency()
    {
        frequencyChanged = true;
        if (frequency == 5)
        {
            for (int i = 0; i < 30; i++)
            {
                Vector3 currentPosition = frequencyWave.GetPosition(i);
                Vector3 newPosition = new Vector3(currentPosition.x, yFrequency[i], currentPosition.z);
                frequencyWave.SetPosition(i, newPosition);
            }
        }
        else
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
