using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start the ledge spinning as soon as the game starts
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = 400;
    }


}

