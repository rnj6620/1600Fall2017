using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

	int pizzaOnTheTable = 4;
	int cookiesOnPlate = 10;
	// Use this for initialization
	void Start () {
		while(pizzaOnTheTable > 0)
		{
			print("I think I'll have another slice!");
			pizzaOnTheTable--;
			//Makes sure Unity doesn't crash
		}
		while(cookiesOnPlate > 0)
		{
			print("Cookies!");
			cookiesOnPlate--;
		}
	}
	
	
}
