using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {
	public int x;
	public int y;
	// Use this for initialization
	void Start () {
		print (x-y);
		print (y-x);
		print (x+y);
		print (x*y);
		print (x/y);
		print (x*y+30);
		print (x++);
		print (++x);
		print (y++);
		print (++y);
	}
	
}
