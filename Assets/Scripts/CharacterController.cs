using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private BulletMainBehaviour bulletMainPrefab;
    [SerializeField] private Transform launchOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Object bullet = Instantiate(bulletMainPrefab, launchOffset.position, transform.rotation);
            if (bullet)
            {
                Destroy(bullet, 0.5f);
            }
        }
    }
}
