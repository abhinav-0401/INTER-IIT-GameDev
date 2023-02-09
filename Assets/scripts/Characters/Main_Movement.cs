using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float Speed = 10f;
    [SerializeField] Rigidbody2D Character_RB;
    Vector2 newPos;
    public float x, y;
    [SerializeField] SpriteRenderer spr;
    [SerializeField] Animator anim;
    
    void FixedUpdate()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        // Debug.Log(gameObject.name);
        newPos.x = x;
        newPos.y = y;
        if(x<0){
            spr.flipX = true;
        }
        if(x>0){
            spr.flipX = false;
        }
        // if (x > 0)
        // {
        //     transform.rotation = Quaternion.Euler(0, 0, -90);
        // }
        // else if (x < 0)
        // {
        //     transform.rotation = Quaternion.Euler(0, 0, 90);
        // }
        // else if (y > 0)
        // {
        //     transform.rotation = Quaternion.Euler(0, 0, 0);
        // }
        // else if (y < 0)
        // {
        //     transform.rotation = Quaternion.Euler(0, 0, 180);
        // }

        Character_RB.MovePosition(Character_RB.position + newPos * Speed * Time.unscaledDeltaTime);

    }
}
