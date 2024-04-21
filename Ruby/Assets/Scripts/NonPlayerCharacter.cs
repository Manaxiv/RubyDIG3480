using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NonPlayerCharacter : MonoBehaviour
{
	public float displayTime = 4.0f;
	public GameObject dialogBox;
	float timerDisplay;

	AudioSource audioSource; 
	public AudioClip greeting;

	public void PlaySound(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}

	void Start()
	{
		audioSource = GetComponent<AudioSource>(); 
		dialogBox.SetActive(false);
		timerDisplay = -1.0f;
	}

	void Update()
	{
		if (timerDisplay >= 0)
		{
			timerDisplay -= Time.deltaTime;
			if (timerDisplay < 0)
			{
				dialogBox.SetActive(false);
			}
		}
	}

	public void DisplayDialog()
	{
		timerDisplay = displayTime;
		dialogBox.SetActive(true);

		if(greeting != null)
        {
			PlaySound(greeting);
		}
	}
}
