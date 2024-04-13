using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIRobotCounter : MonoBehaviour
{
	GameObject[] robots;
	public TMP_Text robotCountText;

	void Update()
	{
		robots = GameObject.FindGameObjectsWithTag("Broken");

		robotCountText.text = "Robots Broken : " + robots.Length.ToString();
	}
}
