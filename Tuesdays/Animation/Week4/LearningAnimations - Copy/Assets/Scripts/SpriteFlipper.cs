using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour{

	private SpriteRenderer playerSprite; 
	// Start is called before the first frame update
	void Start(){
		playerSprite= GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update(){
		if (Input.GetKey(KeyCode.D)) {
			playerSprite.flipX = false;
		}else if (Input.GetKey(KeyCode.A)) {
			playerSprite.flipX = true;
		}
	}
}
