using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 1f;
	public float respawnDelay = 2f;
	public GameObject platformPrefab;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
			Invoke ("Fall", fallDelay);
	}

	void Fall ()
	{
		rb2d.isKinematic = false;
		Invoke ("Respawn", respawnDelay);
	}

	void Respawn()
	{
		Destroy (gameObject);
		Instantiate (platformPrefab);
	}
}
