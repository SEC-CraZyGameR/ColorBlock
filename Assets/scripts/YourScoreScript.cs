using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class YourScoreScript : MonoBehaviour {
	private TextMeshProUGUI yourscore;

	// Use this for initialization
	void Start () {
		yourscore = GetComponent<TextMeshProUGUI> ();
		yourscore.text = "Your Score : "+PlayerPrefs.GetInt ("score").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
