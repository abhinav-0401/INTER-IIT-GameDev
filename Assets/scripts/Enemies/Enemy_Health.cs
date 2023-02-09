using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public float LowLevelHealth = 10f, MidLevelHealth = 20f, HighLevelHealth = 30f, EnemyHealth;
    private void Start() {
        if(transform.name == "Enemy Low Level"){
            EnemyHealth = LowLevelHealth;
        }
        if(transform.name == "Enemy Mid Level"){
            EnemyHealth = MidLevelHealth;
        }
        if(transform.name == "Enemy High Level"){
            EnemyHealth = HighLevelHealth;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet"){
            EnemyHealth -= other.gameObject.GetComponent<Bullet>().Bullet_damage;
            if(EnemyHealth <= 0 ){
                Destroy(gameObject);
            }
        }
    }

}
