using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTheTable : MonoBehaviour
{

    public Transform destination;
    public LineRenderer laser;
    public void moveToTable()
    {
        transform.position = destination.position;
        laser.enabled = false;
    }
}
