using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGWeaponSwitch : MonoBehaviour {

	public string [] weapons;
	
	public void MyWeaponSwitch (int i) {
		switch (weapons[i])
		{
			case "Katana":
				print("Katana");
				break;
			case "Sword":
				print("Sword");
				break;
			case "GreatSword":
				print("Great Sword");
				break;
			case "Axe":
				print("Axe");
				break;
			case "GreatAxe":
				print("Great Axe");
				break;
			case "Bow":
				print("Bow");
				break;
			case "LongBow":
				print("Long Bow");
				break;
			case "Dagger":
				print("Dagger");
				break;
			case "Crossbow":
				print("Crossbow");
				break;
			case "Chakram":
				print("Chakram");
				break;
			default:
				print("You're about to fight this enemy barehanded!");
				break;
		}
	}
}
