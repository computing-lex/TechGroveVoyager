using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] diskPieces;
    public LineRenderer[] lasers;
    public Transform fixedLocation;
    public float piecesCollected = 0;
    public GameObject confetti;
    public bool everythingIsFixed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (everythingIsFixed)
        {
            Instantiate(confetti,fixedLocation.position,Quaternion.identity);
            for(int i = 0; i < diskPieces.Length; i++)
            {
                diskPieces[i].transform.position = fixedLocation.position;
            }
        }
    }
    public void AddAPiece()
    {
        piecesCollected++;
    }
}
