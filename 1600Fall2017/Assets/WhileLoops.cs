using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

	int pizzaOnTheTable = 4;
	// Use this for initialization
	void Start () {
		while(pizzaOnTheTable > 0)
		{
			print("I think I'll have another slice!");
			pizzaOnTheTable--;
		}
	}
	
	
}
