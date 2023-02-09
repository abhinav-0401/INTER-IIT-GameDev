using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.01f;
    void Start()
    {
        gameObject.AddComponent<Rigidbody2D>();
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.velocity = new Vector2(-speed,0);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet"){
            Destroy(gameObject);
        }
    }
}
