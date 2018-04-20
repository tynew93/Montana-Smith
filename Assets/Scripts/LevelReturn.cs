using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReturn : MonoBehaviour {

	public GameObject[] vcams;
	private int currentLevel;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player") && vcams [currentLevel].activeSelf) {
			vcams [currentLevel].SetActive (false);
			--currentLevel;
			vcams [currentLevel].SetActive (true);
			gameObject.SetActive (false);
		}
	}
}
