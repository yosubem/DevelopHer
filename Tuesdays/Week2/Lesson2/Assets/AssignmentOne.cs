using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOne : MonoBehaviour
{
	void Start(){
		simpleOperation(9);
		simpleCondition(9);
		simpleCondition(3);
		simpleSwitch(9);
		simpleSwitch(314);
		simpleSwitch(7);
		simpleSwitch(42);
	}

	//Method accepts an intger, adds 5 and then prints the result.
	private void simpleOperation(int num){
		num += 5;
		Debug.Log(num);
	}   

	//Method accepts an integer. If its 3, prints "Horray!", else prints "Ugh!"
	private void simpleCondition(int num){
		if(num == 3){
			Debug.Log("Horray! the number is 3");
		}else{
			Debug.Log($"Ugh! The number was {num}");
		}
	}

	//Method accepts an integer, checks if it is one of the options and prints something
	private void simpleSwitch(int num){
		switch(num){
			case 314:
				Debug.Log("Did somebody say Pi?");
				break;
			case 7:
				Debug.Log("Lucky number 7");
				break;
			case 42:
				Debug.Log("The meaning of life");
				break;
		}
	}
}
