using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {

	void Swim () {
		print(this.name + " Swim");
}

	void Start()
	{
		Swim