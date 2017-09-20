using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuuri : MonoBehaviour {


	void Start () {
		Skate();
		Eat();
		Cry();
	}
	
	
	void Skate () {
		print(this.name + " Skates");
	}
	void Eat () {
		print(this.name + " Eats");
	}
	void Cry () {
		print(this.name + " Cries");
	}
}
