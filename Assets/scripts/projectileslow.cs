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
        
        Destroy(gameObject);  
        }    
        }

IEnumerator slow()
{
    yield return new WaitForSecondsRealtime(5000);
}
}
