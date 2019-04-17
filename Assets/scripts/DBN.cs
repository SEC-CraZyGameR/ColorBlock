using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class DBN : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	

	}
	public void Quit()
	{
		Application.Quit ();
	}
	public void playAgain()
	{
		SceneManager.LoadScene ("GameScene");
	}
	public void Home()
	{
		SceneManager.LoadScene ("MenuScene");
	}
}
