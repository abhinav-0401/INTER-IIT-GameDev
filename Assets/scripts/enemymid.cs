using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymid : MonoBehaviour
{
    bool canTakeDamage = true;
    public float health = 10;
    private float min_dist = 8;
    // public Transform Player;
    public GameObject gun;
     void Update()
    {
        
        Transform Player=GameObject.FindGameObjectWithTag("Player 1").transform;
        if(!Player){
            return;
        }
        Vector3 difference = Player.position - gun.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        // gun.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

    }
}
