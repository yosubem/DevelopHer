using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{
	// Update is called once per frame
	void Update(){
		//Checking if the player pressed A or D, if so move the object (the maze) in that direction (left or right,respectively) 
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(Vector3.forward, 30f * Time.deltaTime);	//Vector3.forward = Moving on the z axis 
		}else if (Input.GetKey(KeyCode.D)){
			transform.Rotate(Vector3.forward, -30f * Time.deltaTime);
		}

		//Doing the same thing just with W or S (up or down)
		if (Input.GetKey(KeyCode.W)){
			transform.Rotate(Vector3.right, 30f * Time.deltaTime);		//Vector3.rigt = Moving on the x axis
		}else if (Input.GetKey(KeyCode.S)){
			transform.Rotate(Vector3.right, -30f * Time.deltaTime);	   
		}


	}
}
