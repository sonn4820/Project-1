using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mrcleanbullet : MonoBehaviour
{
    float speed = -10f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }
    void Update()
    {

    }
}

    // Update is called once per frame
    

