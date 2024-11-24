using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 100), "第一关"))
        {
            SceneManager.LoadScene("GameScene1");
            SunCollect.score = 600;
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 100), "第二关"))
        {
            SceneManager.LoadScene("GameScene2");
            SunCollect.score = 500;
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 100), "Exit"))
        {
            Application.Quit();
        }
    }
}
