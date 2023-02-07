using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float health =100;
    public bool canTakeDamage=true;
    public float speed=22f;
    public bool infection=false;
    float infectRate;
	float nextinfect;
    int totalinfect=0;
    // Start is called before the first frame update
    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody2D>();
         infectRate = 1f;
		 nextinfect= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        print(health);
        if(health<=0)
        {
            Destroy(gameObject);
        }
        float h = Input.GetAxis("Horizontal");
        float k = Input.GetAxis("Vertical");
        // just to get user input from wasd or arrow keys
        Vector2 player_position = transform.position;
        player_position.x += h * Time.deltaTime * speed;
        player_position.y += k * Time.deltaTime * speed;
        transform.position = player_position;
        CheckIfTimeToFire();
    }
    void CheckIfTimeToFire()
	{
        if(infection)
        {
		if (Time.time > nextinfect&&totalinfect<3) {
			health-=1f;
            totalinfect+=1;
			nextinfect = Time.time + infectRate;
		}
        if(totalinfect>=3){
            infection=false;
            totalinfect=0;
        }
	}
    }
}
