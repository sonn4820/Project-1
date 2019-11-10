using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPaper : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject water1;
    public GameObject water2;

    // Start is called before the first frame update
    void Start()
    {
        door1.gameObject.SetActive(true);
        door2.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (water1 == null )
        {
            door1.gameObject.SetActive(false);
        } else if (water2 == null)
        {
            door2.gameObject.SetActive(false);
        }

    }
}
