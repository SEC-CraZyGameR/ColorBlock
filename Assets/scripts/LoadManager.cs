using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadManager : MonoBehaviour {
	public GameObject loadScreen;
	public Slider slider;
	public GameObject mainMenu;
	public Text progressText;

	public void LoadLevel(int sceneIndex)
	{
		StartCoroutine (LoadAsynchronously (sceneIndex));
	}
		
	IEnumerator LoadAsynchronously(int sceneIndex)
	{

		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

		while(!operation.isDone)
		{
			float progress = Mathf.Clamp01 (operation.progress/.9f);
			slider.value = progress;
			progressText.text = (int)progress * 100 + "%";
			//Debug.Log ((int)progress*100);
			mainMenu.SetActive (false);
			loadScreen.SetActive (true);

			yield return null;
		}
	}
}
