using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class Rope_Constraint : MonoBehaviour
{
    public Transform ActivePlayerTransform;
    Vector2 offsetVector;
    
    private void Start()
    {
        offsetVector = (Vector2)transform.position - (Vector2)ActivePlayerTransform.position;
        
    }
    private void Update()
    {
        transform.position = ActivePlayerTransform.position + new Vector3(offsetVector.x, offsetVector.y, 0);
    }

   
}
