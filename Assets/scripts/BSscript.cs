using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BSscript : MonoBehaviour {
	private TextMeshProUGUI bs;

	void Start () {
		bs = GetComponent<TextMeshProUGUI> ();
		bs.text = PlayerPrefs.GetInt ("highscore").ToString();
	}
}
