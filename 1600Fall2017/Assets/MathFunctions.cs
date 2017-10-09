using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		myScore = ReturnNum (health, ammo);
		myPassword = ReturnPassword(myPassword);
		myUserName = ReturnUser(myUserName);
	}
	
	public int myScore = 100;
	public int health;
	public int ammo;

	public string myPassword = "CoolStuff";
	public string myUserName = "Noctis";

	int ReturnNum (int _num1, int _num2) {
		return _num1 + _num2;
	}

	string ReturnPassword (string _login) {
		if(_login == "ou812") {
		return "Password Correct";
		} else {
			return "Incorrect";
		}
		}
	string ReturnUser (string _name) {
		if(_name == "Prompto") {
		return "Welcome Prompto";
		} else {
			return "Who are You?";
		}
	}
}
