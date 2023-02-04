using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMainBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.up * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject, 0.5f);
    }
}
