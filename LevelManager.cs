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

	void LoadNextScene () {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentIndex + 1);
	}
}
