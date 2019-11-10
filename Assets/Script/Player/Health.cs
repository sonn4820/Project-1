using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private float HP = 10f; // initialize HP 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        Debug.Log("Player HP: " + HP);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "enemy")
        {
            HP -= 1f;
        }
    }
}
