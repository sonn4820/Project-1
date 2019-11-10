using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water3 : MonoBehaviour
{
    public float speed = -10f; // set up speed for the orb
    public Rigidbody2D rb; // get the rigidboy of the arrow

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject); // destroy when it goes off the screen
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed; // set up the formula of arrows' speed
    }
}
