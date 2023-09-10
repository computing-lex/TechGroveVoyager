using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLasers : MonoBehaviour
{

    public Transform diskPiece;
    private LineRenderer diskLocator;    

    // Start is called before the first frame update
    void Start()
    {
        diskLocator = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        diskLocator.SetPosition(1,diskPiece.position);

    }
}
