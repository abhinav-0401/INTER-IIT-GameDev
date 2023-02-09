using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileinfect : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player 1")
        {
            col.gameObject.GetComponent<Infection>().infection = true;
            // if ( >= 0)
            // {
            //     col.gameObject.GetComponent<player>().health -= 1f;
                Destroy(gameObject);
            // }
        }
        if (col.gameObject.tag == "Player 2")
        {
            col.gameObject.GetComponent<Infection>().infection = true;
            // if ( >= 0)
            // {
            //     col.gameObject.GetComponent<player>().health -= 1f;
                Destroy(gameObject);
            // }
        }
    }
}
