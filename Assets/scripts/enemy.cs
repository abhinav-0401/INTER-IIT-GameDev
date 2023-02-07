using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    bool canTakeDamage = true;
    private float health = 10;
    public float damage;
    void OnCollisionStay2D(Collision2D collision) 						
	{	
		if (this.tag == "enemy" && collision.gameObject.tag == "Player")	
        {
        
         if(canTakeDamage)
         {
         StartCoroutine (WaitForSeconds());
         if(collision.gameObject.GetComponent<player>().health>=0)
            {
              collision.gameObject.GetComponent<player>().health-=damage;       
              this.health-=damage;       
        }
        }
        if(this.health<=0)
        {
            Destroy(gameObject);
        }
		}
	}

  IEnumerator WaitForSeconds()
  {
      canTakeDamage = false;
      yield return new WaitForSecondsRealtime (1);
      canTakeDamage = true;
  }
}
