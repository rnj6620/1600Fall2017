using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuuriandViktor : MonoBehaviour {

	
	void Start () {
		Couple();
		Skate();
		Engaged();
	}
	
	
	void Couple () {
		print (this.name + " are the perfect couple");
	}
	void Skate () {
		print (this.name + " skate together");
	}
	void Engaged () {
		print (this.name + " are engaged");
	}
}
