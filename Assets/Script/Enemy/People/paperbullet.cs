using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paperbullet : MonoBehaviour
{
    public GameObject Player; // get the player
    public float speed = 1f; // set up speed
    public float HP = 1f; // set up health
    public Animator animator; // get animator
    public float delay = 0f; // set delay after death
    public AudioSource o1; // get audio source
    // Start is called before the first frame update
    void Start()
    {
        o1.GetComponent<AudioSource>(); // play the audio source
    }

    // Update is called once per frame
    void OnBecameVisible()
    {

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime); // moving toward the player
        

        if (Player.transform.position.x < transform.position.x)
        {
            //face left
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Player.transform.position.x > transform.position.x)
        {
            //face right
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (HP <= 0) // if hp is below 0, destroy and play death animation
        {
            animator.SetFloat("HP", HP);
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hit")
        { 
            HP -= 1;
        }
    }
}

