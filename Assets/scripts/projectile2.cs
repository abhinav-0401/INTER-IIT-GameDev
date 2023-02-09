using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile2 : MonoBehaviour
{
    public float expRadius = 10f;
    public float expForce = 100f;
    float moveSpeed = 7f;
    public float timeOut = 4.0f;
    public bool detachChildren = false;

    Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {
        Invoke("DestroyNow", timeOut);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, expRadius, 1);

        foreach (Collider2D obj in objects)
        {
            if (obj.gameObject.tag == "Player 1")
            {
                print(obj.gameObject.tag);
                
                if(Character_Health.instance.character_health_1 >= 0){
                    Character_Health.instance.character_health_1-=3f;
                    Destroy(gameObject);
                }
                Vector2 dir = obj.transform.position - transform.position;
                obj.GetComponent<Rigidbody2D>().AddForce(dir * expForce, ForceMode2D.Impulse);
                
            }
            if (obj.gameObject.tag == "Player 2")
            {
                print(obj.gameObject.tag);
                
                if(Character_Health.instance.character_health_2 >= 0){
                    Character_Health.instance.character_health_2-=3f;
                    Destroy(gameObject);
                }
                
                Vector2 dir = obj.transform.position - transform.position;
                obj.GetComponent<Rigidbody2D>().AddForce(dir * expForce, ForceMode2D.Impulse);
            }
        }

    }


    void DestroyNow()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, expRadius, 1);
        foreach (Collider2D obj in objects)
        {
            if (obj.gameObject.tag == "Player 1" || obj.gameObject.tag == "Player 2")
            {
                if (obj.gameObject.GetComponent<player>().health >= 0)
                {
                    obj.gameObject.GetComponent<player>().health -= 2f;
                    Destroy(gameObject);
                }
            }
            Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();

            Vector3 deltaPos = rb.transform.position - transform.position;

            // Apply a force in t$$anonymous$$s direction with a magnitude of expForce.
            Vector3 force = deltaPos.normalized * expForce;
            rb.AddForce(force);
        }
        if (detachChildren)
        { // detach the children before destroying if specified
            transform.DetachChildren();
        }

        // destory the game Object
        Destroy(gameObject);
    }
}
