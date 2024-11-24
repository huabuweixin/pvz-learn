using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winchose : MonoBehaviour
{
    // Start is called before the first frame update
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, 200, 100), "选择关卡"))
        {
            SceneManager.LoadScene("ChoseScene");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 80, 200, 100), "Exit"))
        {
            Application.Quit();
        }
    }
}
