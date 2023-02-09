using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    bool canTakeDamage = true;
    public float health = 10;
    public float damage;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (this.tag == "enemy")
        {

            if (canTakeDamage)
            {
                StartCoroutine(WaitForSeconds());
                
                
                if(collision.gameObject.tag == "Player 1"){
                    this.health -= damage;
                    if(Character_Health.instance.character_health_1 > 0)
                    Character_Health.instance.character_health_1-=damage;
                }
                if(collision.gameObject.tag == "Player 2"){
                    this.health -= damage;
                    if(Character_Health.instance.character_health_2 > 0)
                    Character_Health.instance.character_health_2-=damage;
                }
            }
            if (this.health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    IEnumerator WaitForSeconds()
    {
        canTakeDamage = false;
        yield return new WaitForSecondsRealtime(1);
        canTakeDamage = true;
    }
}
