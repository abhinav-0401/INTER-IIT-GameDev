using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] float bullet_Speed = 100f;
    float Time_Stamp = 0.0f, fire_rate = 0.1f;

    [SerializeField] Animator anim;
    private void FixedUpdate() {
        if(Input.GetMouseButtonDown(0)){
            if(Time.time > Time_Stamp)
            Fire(bulletPrefab, shootPoint, fire_rate, bullet_Speed);
        }
    }
    public void Fire(GameObject gobj, Transform shootPoint, float firerate, float bullet_Speed){
        anim.SetTrigger("Attack");
        Time_Stamp = Time.time + firerate;
        GameObject firedBullet = Instantiate(gobj,shootPoint.position,Quaternion.identity);
        Vector2 fireDir = shootPoint.position - transform.position;
        firedBullet.GetComponent<Rigidbody2D>().AddForce(fireDir * bullet_Speed, ForceMode2D.Impulse);
        // firedBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(fireDir.x * bullet_Speed * Time.unscaledDeltaTime, fireDir.y);
    }
}
