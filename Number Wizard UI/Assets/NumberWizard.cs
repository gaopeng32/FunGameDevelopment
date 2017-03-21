using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int maxGuessesAllowed; 

	public Text text;

	// Use this for initialization
	void Start () {
		startGame ();
	}

	void startGame() {
		max = 1000;
		min = 1;
		maxGuessesAllowed = 10;

		nextGuess ();
	}


	public void guessHigher() {
		min = guess + 1;
		nextGuess();
	}

	public void guessLower() {
		max = guess - 1;
		nextGuess();
	}

	
	void nextGuess() {
//		guess = (max + min) / 2;
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString();

		maxGuessesAllowed--;
		if (maxGuessesAllowed <= 0) {
			// User win
			Application.LoadLevel("Win");
		}
	}
}
