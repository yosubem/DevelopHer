using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTileBehaviour : MonoBehaviour{
	public GameObject stoneParticles;
	private void OnDisable() {
		Instantiate(stoneParticles, transform.position, Quaternion.identity);
	}
}
