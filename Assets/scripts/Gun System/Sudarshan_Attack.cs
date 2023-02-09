using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sudarshan_Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = -200;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
