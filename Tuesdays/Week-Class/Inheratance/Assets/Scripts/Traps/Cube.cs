using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Trap {
	public override void ApplyDamage(IDamagable damagable) {
		damagable.TakeDamage(_damage);
	}
}
