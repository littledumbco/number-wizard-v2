using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	// creating a couple of number variables
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 9;

	public Text guessText;
	public Text guessesLeft;
	
	// Use this for initialization
	void Start () {
		
		// start the game function
		StartGame ();
	}
	
	void StartGame () {
		// setting the value of the variables
		max = 1000;
		min = 1;
		guess = 500;
		// fixes the rounding problem of stopping at 999
		max = max +1;
	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	public void GuessLower (){
		max = guess;
		NextGuess ();
	}

	void NextGuess () {
		guess = (max + min) / 2;
		guessText.text = guess.ToString ();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}

	void Update () {
		// Added in a way to display the number of guesses the computer has left to the user
		guessesLeft.text = "Guesses Remaining: " + maxGuessesAllowed.ToString ();
	}
}