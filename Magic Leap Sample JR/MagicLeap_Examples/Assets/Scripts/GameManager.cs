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

    public bool celebration = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (everythingIsFixed && !celebration)
        {
            Instantiate(confetti,fixedLocation.position,fixedLocation.rotation);
            for(int i = 0; i < diskPieces.Length; i++)
            {
                diskPieces[i].transform.position = fixedLocation.position;
                diskPieces[i].transform.rotation = fixedLocation.rotation;
            }

            celebration = true;
        }
    }
    public void AddAPiece()
    {
        piecesCollected++;
    }
}
