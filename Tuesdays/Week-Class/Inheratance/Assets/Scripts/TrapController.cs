using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour{
	[SerializeField] private Trap[] trapList;
    [SerializeField] private Transform[] spawnPoints;

	void Start(){
		int rand;

		foreach (Transform t in spawnPoints) {
			rand = Random.Range(0, trapList.Length);
			Trap randTrap = trapList[rand];
			Instantiate(randTrap,t.position, t.rotation);
		}
        
    }
	
}
