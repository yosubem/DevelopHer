using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour{
	[SerializeField] private GameObject text;
	[SerializeField] private PlayerController playerController;

	public void OnTriggerEnter2D(Collider2D collision) {
		text.SetActive(true);
		playerController.enabled = false;
	}
}
