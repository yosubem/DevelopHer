using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour, IDamagable{
	[SerializeField] int speed;
	[SerializeField] int maxHP;
	int currHP;

	private void Awake() {
		currHP = maxHP;
	}


	public int Speed { get { return speed; } }
	public int CurrHP { get { return currHP; } }
	public void Die() {
		this.gameObject.SetActive(false);
		this.gameObject.GetComponentInParent<PlayerController>().SwitchCharacter();
	}

	public void TakeDamage(int howMuch) {
		currHP -= howMuch;
		if (currHP <= 0) {
			Die();
		}
	}

	public abstract void Movement();

	public abstract void ApplyDamage(IDamagable damagable);

	public abstract void SpecialAbility();
}
