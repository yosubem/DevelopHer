using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControler : MonoBehaviour{
	[SerializeField] private Trap[] trapList;
    [SerializeField] private Transform[] spawnPoints;
	// Start is called before the first frame update
	void Start(){
		int rand;

		foreach (Transform t in spawnPoints) {
			rand = Random.Range(0, trapList.Length);
			Trap randTrap = trapList[rand];
			Instantiate(randTrap,t.position, t.rotation);
		}
        
    }
	
    // Update is called once per frame
    void Update()
    {
        
    }
}
