using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [SerializeField] private float SPEED = 0.1f;
    private Rigidbody2D body;
    private Vector2 moveDirection, lastMoveDirection, position;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= SPEED * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += SPEED * Time.deltaTime;
        }

        transform.position = position;
    }
}
