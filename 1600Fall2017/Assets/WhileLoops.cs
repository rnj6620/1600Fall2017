using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

	int pizzaOnTheTable = 4;
	int cookiesOnPlate = 10;
	int bulletsInInventory = 2;
	int mana = 40;
	int enemyHealth = 90;
	int weaponStrength = 100;
	int armorStrength = 30;
	int bread = 4;
	int life = 10;
	int warmth = 30;
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
		while(bulletsInInventory < 100)
		{
			print("I need more bullets!");
			bulletsInInventory++;
		}
		while(mana < 50)
		{
			print("My mana is low!");
			mana++;
		}
		while(enemyHealth > 0)
		{
			print("We need to kill him!");
			enemyHealth--;
		}
		while(weaponStrength > 30)
		{
			print("Don't fail me now!");
			weaponStrength--;
		}
		while(armorStrength < 40)
		{
			print("My armor is Failing!");
			armorStrength++;
		}
		while(bread > 0)
		{
			print("I guess I'll make a sandwich");
			bread--;
		}
		while(life < 100)
		{
			print("I can't die like this!");
			life++;
		}
		while(warmth < 90)
		{
			print("I will freeze!");
			warmth++;
		}
	}
	
	
}
