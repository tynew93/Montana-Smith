using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelAdvance : MonoBehaviour {

	public GameObject vcam1;
	public GameObject vcam2;
	private int score;

	void Start()
	{
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
        score = PlayerPrefs.GetInt("Score");
		print (score);
		if (other.CompareTag ("Player") && vcam1.activeSelf && score >= 7) {
			vcam1.SetActive (false);
			vcam2.SetActive (true);
			gameObject.SetActive (false);
		} 
	}
}
