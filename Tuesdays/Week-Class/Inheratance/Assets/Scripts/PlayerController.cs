using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
	[SerializeField] private PlayableCharacter[] characterList;
	private int _directionX;
	private int _directionY;
	[SerializeField] private Rigidbody2D _rb2D;
	int num;
	PlayableCharacter currCharacter;
	private Stack<Vector3> _playerMovementHistory;


	public PlayableCharacter CurrCharacter { get { return currCharacter; } }
	public Stack<Vector3> PlayerMovementHistory { get { return _playerMovementHistory; } }
	public Rigidbody2D RB2D { get { return _rb2D; } }
	
	void Start(){
		_playerMovementHistory = new Stack<Vector3>();

		for (int i = 0; i < characterList.Length; i++) {
			characterList[i].gameObject.SetActive(false);
		}

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
	
	private void FixedUpdate() {
		_rb2D.velocity = Vector2.zero;
		float x = CurrCharacter.Speed * _directionX;
		float y = CurrCharacter.Speed * _directionY;
		_rb2D.velocity = new Vector2(x, y);
		PlayerMovementHistory.Push(_rb2D.position);

	}

	public void SwitchCharacter() {
		currCharacter.gameObject.SetActive(false);
		do {
			num += 1;
			if (num >= characterList.Length) {
				num = 0;
			}

			currCharacter = characterList[num];
		} while (currCharacter.CurrHP <= 0);
		
		currCharacter.gameObject.SetActive(true);
	}
}
