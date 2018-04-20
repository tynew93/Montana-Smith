using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LevelAdvance : MonoBehaviour{

	public GameObject vcam1;
	public GameObject vcam2;
	public GameObject levelTransitionPrefab;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player") && vcam1.activeSelf) {
			vcam1.SetActive (false);
			vcam2.SetActive (true);
			Destroy (levelTransitionPrefab);
		} 
	}
}
