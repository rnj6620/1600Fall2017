using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour {

	int age = 16;
	int gold = 500;
	int level = 15;
	int pizzaslice = 5;
	int fish = 3;

	// Use this for initialization
	void Start () {
		if(age > 18 && level > 10)
		{
			print("You are welcome to enter this dungeon.");
		}
		if(level > 10 && gold > 200)
		{
			print("You are broke noob!");
		}
		if(pizzaslice > 1 && fish > 1)
		{
			print("Hmm... Fish on Pizza...");
		}
		if(age > 13 || level > 25)
			{
				print("You can go to the next dungeon");
			}
		if(gold > 1000 || level > 30)
		{
			print("Would you like to see the shops?");
		}
		if(pizzaslice < 1 || fish < 1 && gold > 300)
		{
			print("Would you like more food?");
		}
		if(level < 30 && age < 18 && gold < 1000)
		{
			print("This dungeon is too advanced for you. Try playing a different dungeon.");
		}
		if(level > 8 && pizzaslice < 10)
		{
			print("Pizza will help you level up!");
		}
		if(age < 21 && gold < 3000 || level < 40)
		{
			print("Are you sure you should be in here?");
		}
		if(fish > 10 || level < 30)
		{
			print("Got any fish?");
		}
	}

	
}
