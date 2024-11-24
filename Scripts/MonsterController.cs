using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= 0)
        {
            SceneManager.LoadScene("LoseScene"); // 切换到LoseScene
        }
    }
}
