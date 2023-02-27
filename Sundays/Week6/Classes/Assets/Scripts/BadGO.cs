using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGO : MonoBehaviour{
	public Clicking square;
	public Clicking circle;
	public void OnMouseDown() {
		square.DecreseHp();
		circle.DecreseHp();
	}

	

}
