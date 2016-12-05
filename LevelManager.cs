using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			LoadNextScene ();
		}
	}

	public void LoadNextScene () {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousScene () {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex - 1);
	}
}
