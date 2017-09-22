using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makkachin : MonoBehaviour {

	
	void Start () {
		Dog();
		Cute();
		SteamBuns();
	}
	
	
	void Dog () {
		print (this.name + " is a puppy");
	}
	void Cute () {
		print (this.name + " is very cute");
	}
	void SteamBuns (){
		print (this.name + " nearly dies by choking on a steam bun");
	}
}
