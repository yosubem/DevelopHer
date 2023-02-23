using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour{
	[SerializeField] private PlayableCharacter[] characterList;
	private int _directionX;
	private int _directionY;
	private Rigidbody2D rb2D;
	int num;
	PlayableCharacter currCharacter;


	void Start(){
		num = Random.Range(0, characterList.Length);
		currCharacter = characterList[num];
		currCharacter.gameObject.SetActive(true);
	}

	void Update() {
		//Basic movement
		_directionX = 0;
		_directionY = 0;
		if (Input.GetKey(KeyCode.D)) {
			_directionX += 1;
		}

		if (Input.GetKey(KeyCode.A)) {
			_directionX -= 1;
		}

		if (Input.GetKey(KeyCode.W)) {
			_directionY += 1;
		}

		if (Input.GetKey(KeyCode.S)) {
			_directionY -= 1;
		}

		//Switching character
		if(Input.GetKeyDown(KeyCode.Space)) {
			SwitchCharacter();

		}
	}
	/*
	private void FixedUpdate() {
		float x = speed * _directionX;
		float y = speed * _directionY;
		rb2D.velocity = new Vector2(x, y);
	}*/

	//TODO:Fix bug: Does not respond on first press
	private void SwitchCharacter() {
		currCharacter.gameObject.SetActive(false);
		if (num == characterList.Length) {
			num = 0;
		}
		currCharacter = characterList[num];
		currCharacter.gameObject.SetActive(true);
		num += 1;

	}
}
