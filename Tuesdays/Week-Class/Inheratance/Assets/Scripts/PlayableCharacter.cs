using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour, IDamagable{
	int speed;
	int maxHP;
	int currHP;
	public void Die() {
		throw new System.NotImplementedException();
	}

	public void TakeDamage(int howMuch) {
		throw new System.NotImplementedException();
	}

	public abstract void Movement();

	public abstract void ApplyDamage(IDamagable damagable);

	public abstract void SpecialAbility();
}
