using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trap : MonoBehaviour, IDamagable{
	public LayerMask whatIDamage;
	public abstract void ApplyDamage(IDamagable damagable);

	public void Die() {
		throw new System.NotImplementedException();
	}

	public void TakeDamage(int howMuch) {
		throw new System.NotImplementedException();
	}
}
