using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private float HP = 3f; // initialize HP 
    public AudioSource Ouch;
    public GameObject HP1;
    public GameObject HP2;
    public GameObject HP3;

    // Start is called before the first frame update
    void Start()
    {
        Ouch = GetComponent<AudioSource>();
        HP1.gameObject.SetActive(true);
        HP2.gameObject.SetActive(true);
        HP3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ( HP == 2)
        {
            HP3.gameObject.SetActive(false);
        }
        if (HP == 1)
        {
            HP2.gameObject.SetActive(false);
        }
        
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
            Ouch.Play();
        }
    }
}
