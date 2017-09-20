using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viktor : MonoBehaviour {

	
	void Start () {
		Naked();
		Love();
		God();
	}
	
	
	void Naked () {
		print (this.name + " is naked");
	}
	void Love () {
		print (this.name + " loves Yuuri");
	}
	void God () {
		print (this.name + " is a skating god");
	}
}
