using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdvance : MonoBehaviour{

	public GameObject vcam1;
	public GameObject vcam2;
	public GameObject levelReturn;
	private int currentLevel;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player") && vcam1.activeSelf) {
			vcam1.SetActive (false);
			vcam2.SetActive (true);
			gameObject.SetActive (false);
			levelReturn.SetActive (true);
			PlayerPrefs.SetInt ("level", PlayerPrefs.GetInt("level") + 1);
		} 
	}
}
