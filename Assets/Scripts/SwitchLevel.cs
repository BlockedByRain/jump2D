﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
    public GameObject player;
    //关卡切换
    void Update()
    {
        /*
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(player.GetComponent<PlayerController>().congratulation);
        */
        if (Input.GetKeyDown(KeyCode.E) && player.GetComponent<PlayerController>().congratulation && SceneManager.GetActiveScene().buildIndex<5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

    }
}
