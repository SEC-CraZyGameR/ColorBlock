using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyPrefabs : MonoBehaviour {
	private float speed =10.0f;
	int comp = 50;

	void Update () {
		int scr = PlayerPrefs.GetInt ("score");
		if (scr>comp) {
			speed += .25f;
			comp += 50;
		}
		transform.Translate (new Vector3 (0, -1f, 0) * speed * Time.deltaTime);

	}
	void OnMouseDown()
	{
		if (gameObject.tag == "danger") {
			SceneManager.LoadScene ("DeathScene");
		}
		Destroy (gameObject);
		scoreManager.Instance.count ();
	}
}
