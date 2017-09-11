using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class If : MonoBehaviour {

	public Text input;
	public string password = "Loser";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
		}
	}
}
