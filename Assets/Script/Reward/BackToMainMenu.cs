﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
