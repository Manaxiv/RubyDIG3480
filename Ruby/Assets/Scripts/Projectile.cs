using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	Rigidbody2D rigidbody2d;

	public GameObject blast;

	void Awake()
	{
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if(transform.position.magnitude > 1000.0f)
		{
			Destroy(gameObject);
		}
	}

	public void Launch(Vector2 direction, float force)
	{
		rigidbody2d.AddForce(direction * force);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		EnemyController e = other.collider.GetComponent<EnemyController>();
		BoxBreaker b = other.collider.GetComponent<BoxBreaker>();
		if (e != null)
		{
			e.Fix();
		}
        if (b != null)
        {
			b.Shatter();
        }

		GameObject projectileObject = Instantiate(blast, rigidbody2d.position, Quaternion.identity);

		Destroy(gameObject);
	}
}
