using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public float LowLevelHealth = 10f, MidLevelHealth = 20f, HighLevelHealth = 30f;
    private float EnemyHealth;
    private void Start() {
        if(transform.name == "enemy low(Clone)"){
            EnemyHealth = LowLevelHealth;
        }
        if(transform.name == "enemy mid(Clone)"){
            EnemyHealth = MidLevelHealth;
        }
        if(transform.name == "enemy high(Clone)"){
            EnemyHealth = HighLevelHealth;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Bullet"){
            EnemyHealth -= other.gameObject.GetComponent<Bullet>().Bullet_damage;
            Debug.Log(transform.name + EnemyHealth);
            if(EnemyHealth <= 0 ){
                Destroy(gameObject);
            }
        }
    }

}
