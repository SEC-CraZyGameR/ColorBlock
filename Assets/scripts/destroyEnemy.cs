using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class destroyEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "enemy") {
			SceneManager.LoadScene ("DeathScene");
		}
		if (other.gameObject.tag == "danger") {
			Destroy (other.gameObject);
		}
	}
}
