using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    float moveSpeed = 7f;
	float Damage = 10f;
    Rigidbody2D rb;

    Vector2 moveDirection;

	// accessing health values of both the characters from the Character_Health script which is singleton
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player 1")
        {
            
			if(Character_Health.instance.character_health_1 > 0f){
				Character_Health.instance.character_health_1 -= Damage;
				Debug.Log(Character_Health.instance.character_health_1 + col.gameObject.tag);
			}
			Destroy(gameObject);
        }
        if (col.gameObject.tag == "Player 2")
        {
            
			if(Character_Health.instance.character_health_2 > 0f){
				Character_Health.instance.character_health_2-= Damage;
				Debug.Log(Character_Health.instance.character_health_2 + col.gameObject.tag);
			}
			Destroy(gameObject);
        }
    }
}