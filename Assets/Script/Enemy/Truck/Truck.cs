using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public GameObject orbPrefab; // var to hold prefab for instantiating orbs

    private float secsBetweenLaunch = 1f; // rate that we generate orbs from the enemy
    public float health = 10f; // initialize hp = 2
    public float speed = 4f; // set up speed of enemy
    public Animator animator;// get animator
    public float delay = 0f; // delay time of death

    public Transform firePoint1; // create fire point for prefab
    public Transform firePoint2; // create fire point for prefab
    public Transform firePoint3; // create fire point for prefab
    public Transform firePoint4; // create fire point for prefab
    public Transform firePoint5; // create fire point for prefab

    float chanceDirectionChange = 0.04f; // how likely ship will change direction

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchOrb1", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb2", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb3", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb4", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb5", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        orbPrefab.gameObject.SetActive(false); // set the orb inactive at start


    }

    // Update is called once per frame
    void Update()
    {
        orbPrefab.gameObject.SetActive(true); // when appear, active to orb

        Vector3 Ypos = transform.position; // create a var to hold current position
        Ypos.y += speed * Time.deltaTime; // sets the Ypos of our ship to the speed var * sec since last frame
        transform.position = Ypos;

        if (health <= 0f) // hp < 0
        {
            animator.SetFloat("HP", health); //load death animation
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay); //destroy gameobject after the delay
            CancelInvoke("LaunchOrb1"); // cancel the invoke
            CancelInvoke("LaunchOrb2"); // cancel the invoke
            CancelInvoke("LaunchOrb3"); // cancel the invoke
            CancelInvoke("LaunchOrb4"); // cancel the invoke
            CancelInvoke("LaunchOrb5"); // cancel the invoke
        }


    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            speed = -Mathf.Abs(speed);  // if the enemy pos x is greater than 0.75 reverse speed
        }
    }
    void LaunchOrb1()
    {
        Instantiate(orbPrefab, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchOrb2()
    {
        Instantiate(orbPrefab, firePoint2.position, firePoint2.rotation); // instantiate the arrows
    }
    void LaunchOrb3()
    {
        Instantiate(orbPrefab, firePoint3.position, firePoint3.rotation); // instantiate the arrows
    }
    void LaunchOrb4()
    {
        Instantiate(orbPrefab, firePoint4.position, firePoint4.rotation); // instantiate the arrows
    }
    void LaunchOrb5()
    {
        Instantiate(orbPrefab, firePoint5.position, firePoint5.rotation); // instantiate the arrows
    }
    void FixedUpdate()
    {

        if (Random.value < chanceDirectionChange)
        {  // change direction at a random interval
            speed *= -1;
        }

    }
