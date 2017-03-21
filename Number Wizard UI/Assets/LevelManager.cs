using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name) {
		Debug.Log ("Level load requested for " + name);
		Application.LoadLevel(name);
	}

	public void quitRequest(string name) {
		Debug.Log ("I want to quit!");
		Application.Quit();
	}
}
