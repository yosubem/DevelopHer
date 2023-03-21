using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public abstract class Trap : MonoBehaviour, IDamagable{
	public LayerMask whatIDamage;
	[SerializeField] protected int _damage;
	[SerializeField] protected int _maxHp;
	private int _currHp;

	public void Awake() {
		_currHp = _maxHp;
	}
	public abstract void ApplyDamage(IDamagable damagable);

	public void Die() {
		Destroy(gameObject);
	}

	public void TakeDamage(int howMuch) {
		_currHp -= howMuch;
		if(_currHp <= 0) {
			Die();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		//Debug.Log(whatIDamage);
		//Debug.Log(collision.collider.gameObject.layer);
		//Debug.Log(whatIDamage & (1 << collision.collider.gameObject.layer));
		if ((whatIDamage & (1 << collision.collider.GetComponent<PlayerController>().CurrCharacter.gameObject.layer)) != 0){
			ApplyDamage(collision.collider.gameObject.GetComponent<PlayerController>().CurrCharacter);
			TakeDamage(1);
			Debug.Log("Ouch");
		} else {
			Debug.Log("Not ouch");
			Die();
		}
	}
}
