using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		public GameObject player;
        private void OnTriggerEnter2D(Collider2D other)
        {
			if (other.tag == "Player" && PlayerPrefs.GetInt("level") == 1)
            {
				player.transform.position = new Vector2 (-9.75f, -1.87f);
            }

			if (other.tag == "Player" && PlayerPrefs.GetInt("level") == 2)
			{
				player.transform.position = new Vector2 (28.71f, -6.861f);
			}
        }
    }
}
