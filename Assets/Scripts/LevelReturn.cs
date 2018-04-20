using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReturn : MonoBehaviour {

	public GameObject vcam1;
	public GameObject vcam2;
	public GameObject levelAdvance;
	private int currentLevel;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player") && vcam2.activeSelf) {
			{
				vcam1.SetActive (true);
				vcam2.SetActive (false);
				gameObject.SetActive (false);
				levelAdvance.SetActive (true);
				PlayerPrefs.SetInt ("level", PlayerPrefs.GetInt("level") - 1);
			}
		}
	}
}