using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTheTable : MonoBehaviour
{

    public Transform destination;
    public LineRenderer laser;

    MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public void moveToTable()
    {
        transform.position = destination.position;
        laser.enabled = false;
        if (mesh.enabled == false)
        {
            mesh.enabled = true;
        }
    }
}
