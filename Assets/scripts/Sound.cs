using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
	public GameObject mute;
	public GameObject unmute;


	void Start () {
		
		if (AudioListener.pause == true) {
			unmute.SetActive (true);
			mute.SetActive (false);
		} 
		else if (AudioListener.pause == false) {
			mute.SetActive (true);
			unmute.SetActive (false);
		}
	}
		
	public void Mute()
	{
		AudioListener.pause = true;
		unmute.SetActive (true);
		mute.SetActive (false);
	}
	public void Unmute()
	{
		AudioListener.pause = false;
		mute.SetActive (true);
		unmute.SetActive (false);

	}
}
