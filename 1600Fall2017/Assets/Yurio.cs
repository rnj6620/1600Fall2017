using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yurio : MonoBehaviour {

	
	void Start () {
		Brat();
		Winner();
		Cat();
	}
	
	
	void Brat () {
		print (this.name + " is always angry");
	}
	void Winner () {
		print (this.name + " wins a gold medal");
	}
	void Cat () {
		print (this.name + " thinks he's a ferocious tiger");
	}
}
