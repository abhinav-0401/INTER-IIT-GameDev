using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // [SerializeField]
    // public GameObject[] bullets;
    // // GameObject bullet;
 
    float fire_Rate = 0.8f;
    float Time_Stamp = 0.0f;
    // public Transform Player;
    [SerializeField]float moveSpeed = 3f;

    // Rigidbody2D rb;
    // Vector2 moveDirection;
	[SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    
    private void FixedUpdate() {
        
		if(Time.time > Time_Stamp)
		Fire(bulletPrefab, shootPoint, fire_Rate, moveSpeed);
        
    }
    public void Fire(GameObject gobj, Transform shootPoint, float firerate, float bullet_Speed){
        Time_Stamp = Time.time + firerate;
        GameObject firedBullet = Instantiate(gobj,shootPoint.position,Quaternion.identity);
        Vector2 fireDir = shootPoint.position - transform.position;
        firedBullet.GetComponent<Rigidbody2D>().AddForce(fireDir * bullet_Speed, ForceMode2D.Impulse);
        // firedBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(fireDir.x * bullet_Speed * Time.unscaledDeltaTime, fireDir.y);
    }
    // void CheckIfTimeToFire()
    // {
    //     Transform Player = GameObject.FindGameObjectWithTag("Player").transform;
    //     if (Time.time > nextFire)
    //     {
    //         // int x =Random.Range(0,enemies.Length);
    //         int r = Random.Range(0, 10);
    //         if (r >= 0 && r < 8)
    //         {
    //             GameObject clone = Instantiate(bullets[0], transform.position + transform.forward, Quaternion.identity);
    //             rb = clone.GetComponent<Rigidbody2D>();
    //             // target = GameObject.FindObjectOfType<Cat>();
    //             moveDirection = (Player.position - transform.position).normalized * moveSpeed;
    //             // print(moveDirection.y);
    //             rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    //             nextFire = Time.time + fireRate;
    //         }
    //         else
    //         {
    //             GameObject clone = Instantiate(bullets[1], transform.position + transform.forward, Quaternion.identity);
    //             rb = clone.GetComponent<Rigidbody2D>();
    //             // target = GameObject.FindObjectOfType<Cat>();
    //             moveDirection = (Player.position - transform.position).normalized * moveSpeed;
    //             // print(moveDirection.y);
    //             rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    //             nextFire = Time.time + fireRate;
    //         }
    //     }
    // }
	void CheckIfTimeToFire(){
		// TimeStamp = fireRate + Time.time;
		// moveDirection = ShootPoint.position - transform.position;
		// GameObject fired_bullet

	}

}
