using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If : MonoBehaviour {

	public Text input;
	public bool canPlayGame = false;
	public string password = "Loser";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
		 	canPlayGame = true;
		}	else {
			print("The password is incorrect.");
		}

		if(canPlayGame) {
			print("Can Play Game.");
		}	else {
			print("Can't play game yet, Enter a correct password.");
		}
	}
}
