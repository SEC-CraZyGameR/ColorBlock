using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BN : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject HelpMenu;
	public GameObject creditsMenu;
	public GameObject soundMenu;
	public GameObject play;
	public GameObject quit;
	public GameObject panel1;

	bool helpClick = false;
	bool creditClick = false;
	bool soundClick = false;

	void Start () {
		PlayerPrefs.SetInt ("score", 0);
		AdManager.Instance.ShowBanner ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	public void Play()
	{
		SceneManager.LoadScene ("GameScene");
	}
	public void Quit()
	{
		Application.Quit ();
	}
	public void Help()
	{
		if (helpClick == false) {
			//mainMenu.SetActive (false);
			play.SetActive(false);
			quit.SetActive (false);
			HelpMenu.SetActive (true);
			helpClick = true;
		}
		else if (helpClick == true) {
			//mainMenu.SetActive (true);
			play.SetActive(true);
			quit.SetActive (true);
			HelpMenu.SetActive (false);
			helpClick = false;
		}
		soundMenu.SetActive (false);
		creditsMenu.SetActive (false);
		creditClick = false;
		soundClick = false;
	}
	public void Credits()
	{
		if (creditClick == false) {
			//mainMenu.SetActive (false);
			play.SetActive(false);
			quit.SetActive (false);
			creditsMenu.SetActive (true);
			creditClick = true;
		}
		else if (creditClick == true) {
			//mainMenu.SetActive (true);
			play.SetActive(true);
			quit.SetActive (true);
			creditsMenu.SetActive (false);
			creditClick = false;
		}
		soundMenu.SetActive (false);
		HelpMenu.SetActive (false);
		helpClick = false;
		soundClick = false;

	}
	public void Sound()
	{
		if (soundClick == false) {
			//mainMenu.SetActive (false);
			play.SetActive(false);
			quit.SetActive (false);
			soundMenu.SetActive (true);
			soundClick = true;
		}
		else if (soundClick == true) {
			//mainMenu.SetActive (true);
			play.SetActive(true);
			quit.SetActive (true);
			soundMenu.SetActive (false);
			soundClick = false;
		}
		creditsMenu.SetActive (false);
		HelpMenu.SetActive (false);
		creditClick = false;
		helpClick = false;

	}
	public void ClickPlay()
	{
		panel1.SetActive (false);
	}
}
