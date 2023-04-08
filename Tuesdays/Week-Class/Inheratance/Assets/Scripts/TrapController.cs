using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour{
    [SerializeField] private Transform[] spawnPoints;
	[SerializeField] private Trap _trapPrefab;
	private List<Trap.TrapDelegate> _trapBehaviours;
	[SerializeField] TrapSprite[] _trapSprites;
	[SerializeField] LayerMask[] _damageTarget;
	
	void Start(){
		_trapBehaviours = new List<Trap.TrapDelegate>();
		_trapBehaviours.Add(TrapBehaviours.DoDamage);
		_trapBehaviours.Add(TrapBehaviours.TeleportBack);
		_trapBehaviours.Add(TrapBehaviours.ChangeCharacter);
		
		Trap newTrap;
		int randNum;
		foreach(Transform t in spawnPoints) {
			randNum = Random.Range(0, _trapBehaviours.Count);
			newTrap = TrapFactory(_trapPrefab, _trapBehaviours[randNum], _trapSprites[randNum], _damageTarget[randNum]);
			newTrap.transform.position = t.position;
		}
        
    }

	private void OnValidate() {
		if(_trapSprites.Length != 3) {
			Debug.LogError("The trapSprites array should have exactly 3 elements.", this);
		}
	}


	public Trap TrapFactory(Trap trap, Trap.TrapDelegate trapBehaviour, TrapSprite sprite, LayerMask layer){
		Trap newTrap = Instantiate(trap);
		newTrap.TrapBehaviour = trapBehaviour;
		SpriteRenderer sr = newTrap.GetComponent<SpriteRenderer>();
		sr.sprite = sprite.Sprite;
		sr.color = sprite.Color;

		return newTrap;
	}
	
}
