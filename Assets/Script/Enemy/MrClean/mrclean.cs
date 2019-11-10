using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mrclean : MonoBehaviour
{
    float speed = 10f;
    public GameObject orbPrefab1; // var to hold prefab for instantiating orbs
    public GameObject orbPrefab2; // var to hold prefab for instantiating orbs


    public Transform firePoint1; // create fire point for prefab
    public Transform firePoint2; // create fire point for prefab
    public Transform firePoint3; // create fire point for prefab

    public Animator animator;// get animator
    public float delay = 0f; // delay time of death
    private float secsBetweenLaunch = 0.7f; // rate that we generate orbs from the enemy
    public float HP = 10f; // initialize HP 
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchOrb1", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb2", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb3", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        orbPrefab1.gameObject.SetActive(false); // set the orb inactive at start
        orbPrefab2.gameObject.SetActive(false); // set the orb inactive at start
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        orbPrefab1.gameObject.SetActive(true); // when appear, active to orb
        orbPrefab2.gameObject.SetActive(true); // when appear, active to orb
        animator.SetFloat("HP", HP);
        if (HP <= 0f) // hp < 0
        {
            animator.SetFloat("HP", HP); //load death animation
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay); //destroy gameobject after the delay
            CancelInvoke("LaunchOrb1"); // cancel the invoke
            CancelInvoke("LaunchOrb2"); // cancel the invoke
            CancelInvoke("LaunchOrb3"); // cancel the invoke
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            speed = speed * -1;
        }
        if (HP >= 1f && collision.gameObject.tag == "hit")
        {
            HP -= 1f;
            Debug.Log("MrClean HP: " + HP);
        }
    }
    void LaunchOrb1()
    {
        Instantiate(orbPrefab1, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchOrb2()
    {
        Instantiate(orbPrefab2, firePoint2.position, firePoint2.rotation); // instantiate the arrows
    }
    void LaunchOrb3()
    {
        Instantiate(orbPrefab1, firePoint3.position, firePoint3.rotation); // instantiate the arrows
    }
}
