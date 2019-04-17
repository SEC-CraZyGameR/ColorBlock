using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCon : MonoBehaviour {
	public Animator anim;
	public GameObject OnClick;
	public GameObject offClick;
	public GameObject h;
	public GameObject c;
	public GameObject s;
	public GameObject play;
	public GameObject quit;

	void Start () {
		anim.enabled = false;
	}
	
	public void clickon()
	{
		offClick.SetActive (true);
		OnClick.SetActive (false);
		anim.enabled = true;
		anim.Play ("TrayAnimation");
	}

	public void clickoff(){
		offClick.SetActive (false);
		OnClick.SetActive (true);
		anim.Play ("BackTray");
		h.SetActive (false);
		c.SetActive (false);
		s.SetActive (false);
		play.SetActive (true);
		quit.SetActive (true);
	}
}
