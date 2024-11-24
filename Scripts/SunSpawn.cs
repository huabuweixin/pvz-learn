using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 10, 10);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(prefab,
            transform.position,
            Quaternion.identity);
    }
}
