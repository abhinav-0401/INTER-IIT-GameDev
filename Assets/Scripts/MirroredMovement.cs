using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirroredMovement : MonoBehaviour
{
    private GameObject player;
    private Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Square");
        SetMirroredPosition(player);
    }

    // Update is called once per frame
    void Update()
    {
        SetMirroredPosition(player);
    }

    void SetMirroredPosition(GameObject mirroredPlayer)
    {
        position.x = -mirroredPlayer.transform.position.x;
        position.y = mirroredPlayer.transform.position.y;
        transform.position = position;
    }
}
