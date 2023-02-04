using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [SerializeField] private float SPEED = 0.1f;
    private Rigidbody2D body;
    private Vector2 moveDirection, lastMoveDirection, position;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        position = transform.position;
        rotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
        HandleRotationInput(); 
    }

    void HandleMovementInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            position.y += SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.y -= SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            position.x -= SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += SPEED * Time.deltaTime;
        }

        transform.position = position;
    }

    void HandleRotationInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotation.z = 0;
            transform.eulerAngles = rotation;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rotation.z = 180;
            transform.eulerAngles = rotation;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation.z = 90;
            transform.eulerAngles = rotation;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation.z = 270;
            transform.eulerAngles = rotation;
        }
    }
}
