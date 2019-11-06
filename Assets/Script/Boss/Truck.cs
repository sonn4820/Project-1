using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public Transform firePoint1; // create fire point for prefab
    public Transform firePoint2; // create fire point for prefab
    public Transform firePoint3; // create fire point for prefab
    public Transform firePoint4; // create fire point for prefab

    public GameObject orbPrefab; // var to hold prefab for instantiating orbs
    public Animator animator;// get animator
    public float delay = 0f; // delay time of death
    public float secsBetweenLaunch = 2f; // rate that we generate orbs from the enemy
    public float health = 10f; // initialize hp = 2


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchOrb1", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb2", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb3", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        InvokeRepeating("LaunchOrb4", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        orbPrefab.gameObject.SetActive(false); // set the orb inactive at start
    }

    // Update is called once per frame
    void Update()
    {
        orbPrefab.gameObject.SetActive(true); // when appear, active to orb
        if (health <= 0f) // hp < 0
        {
            animator.SetFloat("HP", health); //load death animation
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay); //destroy gameobject after the delay
            CancelInvoke("LaunchOrb"); // cancel the invoke
        }
    }
    void LaunchOrb1()
    {
        Instantiate(orbPrefab, firePoint1.position, firePoint1.rotation); // launch orb

    }
    void LaunchOrb2()
    {
        Instantiate(orbPrefab, firePoint2.position, firePoint2.rotation); // launch orb
    }
    void LaunchOrb3()
    {
        Instantiate(orbPrefab, firePoint3.position, firePoint3.rotation); // launch orb
    }
    void LaunchOrb4()
    {
        Instantiate(orbPrefab, firePoint4.position, firePoint4.rotation); // launch orb
    }
}
