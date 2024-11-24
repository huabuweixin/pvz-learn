using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttacking : MonoBehaviour
{
    float last = 0;

    void OnCollisionStay2D(Collision2D coll)
    {
        // Collided with a Plant?
        if (coll.gameObject.tag == "Plant")
        {
            // Play Attack Animation
            GetComponent<Animator>().SetTrigger("IsAttacking");
            // Deal damage once a second
            if (Time.time - last >= 1)
            {
                coll.gameObject.GetComponent<Health>().doDamage(1);
                last = Time.time;
            }
        }
    }
}
