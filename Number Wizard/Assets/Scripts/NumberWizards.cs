using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame ();
	}

	void startGame() {
		max = 1000;
		min = 1;

		print ("=============================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		nextGuess ();
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess + 1;
			nextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess - 1;
			nextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			startGame();
		}
	}

	
	void nextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow = higher, down = lower, return = equal");
	}
}
