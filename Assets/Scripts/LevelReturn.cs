using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReturn : MonoBehaviour {

	public GameObject vcam1;
	public GameObject vcam2;



	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag ("Player") && !vcam1.activeSelf) {
			{
				vcam1.SetActive (true);
				vcam2.SetActive (false);
			}
		}
	}
}