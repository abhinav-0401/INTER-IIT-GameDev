using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrored_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform ActiveCharacter;
    Vector2 MirrorPos;
    float inputx, inputy;
    [SerializeField] SpriteRenderer spr;

    // Update is called once per frame
    private void Update() {
        MirrorPos.x = -1 * ActiveCharacter.position.x;
        MirrorPos.y = -1 * ActiveCharacter.position.y;

        inputx = ActiveCharacter.gameObject.GetComponent<Main_Movement>().x;
        // inputy = ActiveCharacter.gameObject.GetComponent<Main_Movement>().y;
        if(inputx > 0){
            spr.flipX = false;
        }
        if(inputx < 0){
            spr.flipX = true;
        }
        // if(Input.GetAxisRaw("Horizontal")!=0){
        // transform.rotation = ActiveCharacter.rotation;
        // }
        transform.rotation = ActiveCharacter.rotation;
        // transform.forward = (-ActiveCharacter.forward);
        transform.position = MirrorPos;
    }
  
}
