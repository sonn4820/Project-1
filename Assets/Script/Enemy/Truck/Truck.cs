using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public GameObject orbPrefab1; // var to hold prefab for instantiating orbs
    public GameObject orbPrefab2; // var to hold prefab for instantiating orbs
    public GameObject orbPrefab3; // var to hold prefab for instantiating orbs
    public GameObject orbPrefab4; // var to hold prefab for instantiating orbs

    public float secsBetweenLaunch = 2f; // rate that we generate orbs from the enemy
    public float health = 10f; // initialize hp = 2
    public Animator animator;// get animator
    public float delay = 0f; // delay time of death

    public Transform firePoint1; // create fire point for prefab
    public Transform firePoint2; // create fire point for prefab
    public Transform firePoint3; // create fire point for prefab
    public Transform firePoint4; // create fire point for prefab

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchOrb1", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
        orbPrefab1.gameObject.SetActive(false); // set the orb inactive at start
        orbPrefab2.gameObject.SetActive(false); // set the orb inactive at start
        orbPrefab3.gameObject.SetActive(false); // set the orb inactive at start
        orbPrefab4.gameObject.SetActive(false); // set the orb inactive at start

    }

    // Update is called once per frame
    void Update()
    {
        orbPrefab1.gameObject.SetActive(true); // when appear, active to orb
        orbPrefab2.gameObject.SetActive(true); // when appear, active to orb
        orbPrefab3.gameObject.SetActive(true); // when appear, active to orb
        orbPrefab4.gameObject.SetActive(true); // when appear, active to orb

        if (health <= 0f) // hp < 0
        {
            animator.SetFloat("HP", health); //load death animation
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay); //destroy gameobject after the delay
            CancelInvoke("LaunchOrb"); // cancel the invoke
        }

    }
    void LaunchOrb1()
    {
        Instantiate(orbPrefab1, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchOrb2()
    {
        Instantiate(orbPrefab2, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchOrb3()
    {
        Instantiate(orbPrefab3, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchOrb4()
    {
        Instantiate(orbPrefab4, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }

}
