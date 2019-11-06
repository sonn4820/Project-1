using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject enemy;
    public Animator animator;
    bool change;
    // Start is called before the first frame update
    void Start()
    {
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (change == true)
        {
            animator.SetBool("change", true);
        }


        if (enemy = null)
        {
            change = true;
            Debug.Log("change");
        }
       
    }
}
