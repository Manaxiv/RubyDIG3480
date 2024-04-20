using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
	public AudioClip coinCollectedClip;
	public CoinManager cm;

	void OnTriggerEnter2D(Collider2D other)
	{
		RubyController controller = other.GetComponent<RubyController>();

		if (other.gameObject.CompareTag("Ruby"))
		{
			cm.coinCount++;
			controller.PlaySound(coinCollectedClip);
			Destroy(gameObject);
		}
	}
}

