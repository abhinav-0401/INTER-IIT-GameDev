using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRope_Orb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            GameObject.Find("FireRope Manager").GetComponent<Enable_Rope_Constraint>().Enable_Rope(other.gameObject);
            Debug.Log("collision detected");
            Destroy(gameObject);
        }
    }
}
