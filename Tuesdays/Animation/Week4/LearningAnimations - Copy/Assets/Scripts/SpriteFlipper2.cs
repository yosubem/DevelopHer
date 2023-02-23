using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper2 : MonoBehaviour{

	private SpriteRenderer playerSprite; 
	// Start is called before the first frame update
	void Start(){
		playerSprite= GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update(){
		if (Input.GetKey(KeyCode.LeftArrow)) {
			playerSprite.flipX = false;
		}else if (Input.GetKey(KeyCode.RightArrow)) {
			playerSprite.flipX = true;
		}
	}
}
