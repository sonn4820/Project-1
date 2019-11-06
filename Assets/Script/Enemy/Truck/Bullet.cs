using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // set up speed for the orb
    public Animator animator; // get animator
    public float delay = 0f; // delay time for death animation
    public Rigidbody2D rb; // get the rigidboy of the arrow
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed; // set up the formula of arrows' speed
    }
}
