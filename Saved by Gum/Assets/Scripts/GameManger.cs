using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) {

            Time.timeScale = 1f;
            SceneManager.LoadScene("Main");

        }

        if (Input.GetKeyDown("escape")) {

            Application.Quit();

        }
    }
}
