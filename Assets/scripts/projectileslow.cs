using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileslow : MonoBehaviour
{
  float moveSpeed = 7f;

	Rigidbody2D rb;

	Vector2 moveDirection;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter2D (Collider2D col)
	{
        if (col.gameObject.tag == "Player")	
        {
        // col.gameObject.GetComponent<player>().speed=1f;       
        // print(col.gameObject.GetComponent<player>().speed);
        // StartCoroutine(slow());		
        // col.gameObject.GetComponent<player>().speed=22f;  
        // print(col.gameObject.GetComponent<player>().speed);
        Destroy(gameObject);  
        }    
        }

IEnumerator slow()
{
    yield return new WaitForSecondsRealtime(5000);
}
}
