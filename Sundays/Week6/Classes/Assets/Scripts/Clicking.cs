using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour{
	private int _counter;
	private static int _shared;
	[SerializeField]private int _hp;

	public int Hp { 
		get { 
			return _hp; 
		}
	}
	private void OnMouseDown() {
		_counter++;
		Debug.Log("Counter: " + _counter);

		_shared++;
		Debug.Log("Shared: " + _shared);
	}

	public void DecreseHp() {
		_hp--;
		Debug.Log("Hp: " + _hp);
		if (_hp == 0) {
			Destroy(gameObject);
		}
	}
}
