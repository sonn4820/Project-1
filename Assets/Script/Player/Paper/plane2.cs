using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane2 : MonoBehaviour
{
    public Transform firePoint; // create fire point for prefab
    public GameObject hitPrefab;  // place to drop prefab
    public AudioSource hit; // place for drop audio
    private float timeBetweenShots = 1f;  // time between each shot
    private float delaytime; // call delay time


    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponent<AudioSource>(); // get the audio source 
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= delaytime && (Input.GetKeyDown(KeyCode.J))) // Use J to shoot
        {
            boom2(); // activate the shoot function
            delaytime = Time.time + timeBetweenShots; // delay time = timebtwshots
        }


    }
    void boom2() // shoot function
    {
        Instantiate(hitPrefab, firePoint.position, firePoint.rotation); // instantiate the arrows

    }
}
