using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame updatepubl
    public float speed, radius_effective;
    public TimeManager TM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Explode(mousePos, radius_effective);
            TM.DoSlowMo();
        }   
    }
    
    void Explode(Vector2 pos, float radius){
        Collider2D[] objects = Physics2D.OverlapCircleAll(pos, radius);
        foreach(Collider2D obj in objects){
            Vector2 dir = (Vector2)obj.transform.position - pos;
            obj.GetComponent<Rigidbody2D>().AddForce(dir * speed, ForceMode2D.Impulse);
        }
    }
}