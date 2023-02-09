using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    private float speed = 4;
    private float max_dist = 15;
    private float min_dist = 1;
    // public Transform Player;

    // Update is called once per frame
    void Update()
    {
        GameObject Player=GameObject.FindGameObjectWithTag("Player 1");
        if(!Player){
            return;
        }
        float dist = Vector2.Distance(Player.transform.position, transform.position);
        if(dist<=max_dist&&dist>=min_dist)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed*Time.deltaTime);      
        }
        else{
            transform.position = Vector2.MoveTowards(transform.position, -transform.right, speed * Time.deltaTime);
        }

    }
}
