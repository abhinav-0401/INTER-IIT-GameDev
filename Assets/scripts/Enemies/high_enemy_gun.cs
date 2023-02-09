using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class high_enemy_gun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject[] bullets;
    [SerializeField] Transform shootPoint;
    Rigidbody2D rb;
    Vector2 moveDirection;
    [SerializeField]float moveSpeed = 3f;
    float fireRate = 0.8f;
    float Time_Stamp = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }
    void CheckIfTimeToFire()
    {
        // Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Time.time > Time_Stamp)
        {
            // int x =Random.Range(0,enemies.Length);
            int r = Random.Range(0, 10);
            if (r >= 0 && r < 8)
            {
                GameObject clone = Instantiate(bullets[0], shootPoint.position, Quaternion.identity);
                rb = clone.GetComponent<Rigidbody2D>();
                // target = GameObject.FindObjectOfType<Cat>();
                moveDirection = (shootPoint.position - transform.position).normalized * moveSpeed;
                // print(moveDirection.y);
                rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
                Time_Stamp = Time.time + fireRate;
            }
            else
            {
                GameObject clone = Instantiate(bullets[1], shootPoint.position, Quaternion.identity);
                rb = clone.GetComponent<Rigidbody2D>();
                // target = GameObject.FindObjectOfType<Cat>();
                moveDirection = (shootPoint.position - transform.position).normalized * moveSpeed;
                // print(moveDirection.y);
                rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
                Time_Stamp = Time.time + fireRate;
            }
        }
    }
}
