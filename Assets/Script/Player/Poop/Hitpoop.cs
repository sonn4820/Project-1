using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpoop : MonoBehaviour
{
    public Transform firePoint1; // create fire point for prefab
    public Transform firePoint2; // create fire point for prefab
    public Transform firePoint3; // create fire point for prefab
    public Transform firePoint4; // create fire point for prefab

    public GameObject poopPrefab1; // var to hold prefab for instantiating orbs
    public GameObject poopPrefab2; // var to hold prefab for instantiating orbs
    public GameObject poopPrefab3; // var to hold prefab for instantiating orbs
    public GameObject poopPrefab4; // var to hold prefab for instantiating orbs

    private float timeBetweenShots = 1.2f;  // time between each shot
    private float delaytime; // call delay time

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= delaytime && (Input.GetKeyDown(KeyCode.J))) // Use J to shoot
        {
            LaunchPoop1(); // activate the shoot function
            LaunchPoop2(); // activate the shoot function
            LaunchPoop3(); // activate the shoot function
            LaunchPoop4(); // activate the shoot function
            delaytime = Time.time + timeBetweenShots; // delay time = timebtwshots
        }
    }
    void LaunchPoop1()
    {
        Instantiate(poopPrefab1, firePoint1.position, firePoint1.rotation); // instantiate the arrows
    }
    void LaunchPoop2()
    {
        Instantiate(poopPrefab2, firePoint2.position, firePoint2.rotation); // instantiate the arrows
    }
    void LaunchPoop3()
    {
        Instantiate(poopPrefab3, firePoint3.position, firePoint3.rotation); // instantiate the arrows
    }
    void LaunchPoop4()
    {
        Instantiate(poopPrefab4, firePoint4.position, firePoint4.rotation); // instantiate the arrows
    }
    
}
