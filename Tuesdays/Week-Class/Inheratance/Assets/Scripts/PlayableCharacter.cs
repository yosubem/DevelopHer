using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour, IDamagable{
	[SerializeField] int speed;
	[SerializeField] int maxHP;
	int currHP;
	public delegate void HPDelegate(int hp);
	public event HPDelegate HPChangeHandler; 

	public int Speed { get { return speed; } }
	public int CurrHP { get { return currHP; } }
	
	private void Awake() {
		currHP = maxHP;
	}

	public void Die() {
		this.gameObject.SetActive(false);
		this.gameObject.GetComponentInParent<PlayerController>().SwitchCharacter();
	}

	public void TakeDamage(int howMuch) {
		currHP -= howMuch;
		HPChangeHandler(currHP); //Raising the event
		if (currHP <= 0) {
			Die();
		}
	}

	public abstract void Movement();

	public abstract void ApplyDamage(IDamagable damagable);

	public abstract void SpecialAbility();
}
