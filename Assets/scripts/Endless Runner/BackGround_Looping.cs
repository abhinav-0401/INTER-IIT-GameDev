using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Looping : MonoBehaviour
{
    public float ScrollSpeed, endx, startx;
    private void Update() {
        transform.Translate(Vector2.left * ScrollSpeed * Time.deltaTime);

        if(transform.position.x <= endx){
            Vector2 pos = new Vector2( startx,transform.position.y);
            transform.position = pos;
        }
    }
}
