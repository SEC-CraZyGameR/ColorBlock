using UnityEngine;
using System.Collections;

public class spawnerScript : MonoBehaviour {

	public GameObject[] cube;
	int cubeNo;
	private float delayTimer = .5f;
	float timer;
	int cmp = 50;
	void Start () {
	
		timer = delayTimer;

	}
	

	void Update () {
		int scr = PlayerPrefs.GetInt ("score");
		if (scr > cmp) {
			timer -= .05f;
			cmp += 50;
		}
	
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 pos = new Vector3 (Random.Range (-1.8f,1.8f), transform.position.y, transform.position.z);
			cubeNo = Random.Range (0, 5);
			Instantiate (cube[cubeNo], pos, transform.rotation);
			timer = delayTimer;
		}

	}
}
