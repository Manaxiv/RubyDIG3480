using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class CoinManager : MonoBehaviour
{
	public int coinCount;
	public int coinsMax;

	GameObject[] coins;
	public TMP_Text coinCountText;

	void Start()
	{
		
		coins = GameObject.FindGameObjectsWithTag("Coin");

		coinsMax = coins.Length;
	}

	void Update()
	{
		coinCountText.text = ": " + coinCount + " / " + coinsMax.ToString();
	}
}
