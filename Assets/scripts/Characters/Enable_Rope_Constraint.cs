using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Rope_Constraint : MonoBehaviour
{
    [SerializeField] GameObject Character_1, Character_2;
    // private void Update() {
    //     if(Input.GetKeyDown(KeyCode.O)){
    //         Enable_Rope(Character_1);
    //     }
    //     if(Input.GetKeyDown(KeyCode.P)){
    //         Enable_Rope(Character_2);
    //     }
    // }
    public void Enable_Rope(GameObject obj){
        GameObject obj_1, obj_2;
        if(obj == Character_1){
            obj_1 = Character_1;
            obj_2 = Character_2;
        }
        else{
            obj_1 = Character_2;
            obj_2 = Character_1;
        }
        obj_1.GetComponent<Main_Movement>().enabled = true;
        obj_2.GetComponent<Main_Movement>().enabled = false;

        obj_1.GetComponent<Character_Switch>().enabled = true;
        obj_2.GetComponent<Character_Switch>().enabled = false;

        obj_1.GetComponent<EdgeCollider2D>().enabled = true;
        obj_2.GetComponent<EdgeCollider2D>().enabled = false;

        obj_1.GetComponent<Rendering_Rope_Line>().enabled = true;
        obj_2.GetComponent<Rendering_Rope_Line>().enabled = false;

        obj_1.GetComponent<Rope_Constraint>().enabled = false;
        obj_2.GetComponent<Rope_Constraint>().enabled = true;

        obj_1.GetComponent<Mirrored_Movement>().enabled = false;
        obj_2.GetComponent<Mirrored_Movement>().enabled = false;

        obj_1.GetComponent<LineRenderer>().enabled = true;
        obj_2.GetComponent<LineRenderer>().enabled = false;
    }
}
