using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {
		public int age;
		public int health;
		public int level;
		public int height;
		public int mana;
		public int grade;
		public int temperature;
	void Start(){	
		if (age>=18){
			print("You are old enough.");
		}else{
			print("You are not old enough. :(");
		}
		if (health>50){
			print("You have enough health");
		}else{
			print("You should use a potion");
		}
		if (level>=10){
			print("You can enter the dungeon.");
		}else{
			print("You are not a high enough level. Come back When You're a level 10.");
		}
		if (height>72){
			print("You are really tall");
		}else{
			print("You are not very tall");
		}
		if (mana>51){
			print("You have enough Mana");
		}else{
			print("You should use a potion");
		}
		if (grade>=9){
			print("You are a high school student");
		}else{
			print("You are a grade schooler");
		}
		if (temperature>=80){
			print("It is very hot outside");
		}
		if(temperature<80 && temperature>=50){
			print("It is nice outside.");
		}if(temperature<50 && temperature>30){
			print("It is chilly outside");
		}if(temperature<=30){
			print("It is freezing outside");
		}
	}
	
}