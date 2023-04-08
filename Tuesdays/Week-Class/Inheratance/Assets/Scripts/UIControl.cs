using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour{
	[SerializeField] private string _characterName;
    [SerializeField] private TMPro.TextMeshPro _hp;
    [SerializeField] private PlayableCharacter _character;

	private void Start() {
		_character.HPChangeHandler += OnHit;
	}

	private void OnHit(int hp) {
		_hp.text = _characterName + ": " + hp;
	}

	private void OnDestroy() {
		_character.HPChangeHandler -= OnHit;
	}

}
