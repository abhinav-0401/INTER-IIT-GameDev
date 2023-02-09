using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float bullet_Speed = 20f, Bullet_damage = 2f;
    void Start()
    {
        // gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_Speed);
        Destroy(gameObject, 4f);   
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }

    
}
