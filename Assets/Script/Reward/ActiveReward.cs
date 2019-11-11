using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveReward : MonoBehaviour
{
    public GameObject reward;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        reward.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null)
        {
            reward.gameObject.SetActive(true);
        }
    }
}
