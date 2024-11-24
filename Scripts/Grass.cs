using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BuildMenu;

public class Grass : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
            if (BuildMenu.cur != null)
            {
                Instantiate(BuildMenu.cur.gameObject, transform.position, Quaternion.identity);
                SunCollect.score -= BuildMenu.cur.price;
                BuildMenu.cur = null;
            }
    }
}
