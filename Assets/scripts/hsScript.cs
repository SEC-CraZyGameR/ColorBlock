using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class hsScript : MonoBehaviour {

	private TextMeshProUGUI hs;

	// Use this for initialization
	void Start () {
		hs = GetComponent<TextMeshProUGUI> ();
		hs.text ="High Score : " + PlayerPrefs.GetInt ("highscore").ToString ();
	}
}
