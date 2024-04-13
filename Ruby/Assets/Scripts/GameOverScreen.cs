using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
	public TMP_Text robotsFixed;

	public void Setup(int robotsFixedScore)
	{
		gameObject.SetActive(true);
		robotsFixed.text = "Robots Fixed : " + robotsFixedScore.ToString();

	}

	public void RestartButton()
	{
		SceneManager.LoadScene("MainScene");
	}
}
