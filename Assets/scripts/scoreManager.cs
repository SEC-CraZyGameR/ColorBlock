using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	public static scoreManager Instance{ set; get;}
	public Text scoreText;
	int score = 0;


	// Use this for initialization
	private void Awake()
	{
		Instance = this;

	}
	void Start () {
		PlayerPrefs.SetInt ("score", 0);
		AdManager.Instance.ShowBanner ();
	}
	
	// Update is called once per frame
	public void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	public void count()
	{
		score++;
		PlayerPrefs.SetInt ("score", score);
		scoreText.text = score.ToString ();
		//Debug.Log ("count");
		if (score > PlayerPrefs.GetInt ("highscore")) {
			PlayerPrefs.SetInt ("highscore", score);
		}
	}
}
