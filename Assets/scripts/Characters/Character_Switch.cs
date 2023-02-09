using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Switch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject otherCharacter;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            character_switch();
        }
        
    }

    void character_switch(){
        otherCharacter.GetComponent<Main_Movement>().enabled = true;
        GetComponent<Main_Movement>().enabled = false;
        otherCharacter.GetComponent<Character_Switch>().enabled = true;
        GetComponent<Character_Switch>().enabled = false;
        otherCharacter.GetComponent<Mirrored_Movement>().enabled = false;
        GetComponent<Mirrored_Movement>().enabled = true;

    }

    
   
}
