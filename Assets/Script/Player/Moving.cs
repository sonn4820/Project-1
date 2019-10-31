using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Animator animator; // get animator
    public float speed = 10f; // set up speed
    public float moveHorizontal; // call new float for horizontal movement
    public float moveVertical; // call new float for vertical movement

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveHorizontal = Input.GetAxis("Horizontal") * speed; // move hor

        moveVertical = Input.GetAxis("Vertical") * speed; // move ver

        animator.SetFloat("VerSpeed", moveHorizontal); // get animation
        animator.SetFloat("HorSpeed", moveVertical); // get animation



        GetComponent<Rigidbody2D>().velocity = new Vector2(moveHorizontal, moveVertical); // get rigidbody for player

     

    }
}
