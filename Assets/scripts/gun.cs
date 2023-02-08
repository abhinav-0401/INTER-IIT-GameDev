using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
	[SerializeField]
	public GameObject[] bullets;
	// GameObject bullet;

	float fireRate;
	float nextFire;
	// public Transform Player;
	float moveSpeed = 7f;

	Rigidbody2D rb;
	Vector2 moveDirection;

	// Use this for initialization
	void Start () {
		fireRate = 0.8f;
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		Transform Player=GameObject.FindGameObjectWithTag("Player").transform;
		if (Time.time > nextFire) {
			// int x =Random.Range(0,enemies.Length);
        	int r=Random.Range(0,10);
			if(r>=0&&r<8)
        {
			GameObject clone= Instantiate (bullets[0], transform.position+transform.forward, Quaternion.identity);
			rb = clone.GetComponent<Rigidbody2D> ();
			// target = GameObject.FindObjectOfType<Cat>();
			moveDirection = (Player.position - transform.position).normalized * moveSpeed;
			// print(moveDirection.y);
			rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
			nextFire = Time.time + fireRate;
		}
		else
        {
			GameObject clone= Instantiate (bullets[1], transform.position+transform.forward, Quaternion.identity);
			rb = clone.GetComponent<Rigidbody2D> ();
			// target = GameObject.FindObjectOfType<Cat>();
			moveDirection = (Player.position - transform.position).normalized * moveSpeed;
			// print(moveDirection.y);
			rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
			nextFire = Time.time + fireRate;
		}
		}
	}
}
