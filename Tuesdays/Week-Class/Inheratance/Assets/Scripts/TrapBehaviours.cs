using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviours{
	public static void DoDamage(PlayerController player, Trap trap){
		player.CurrCharacter.TakeDamage(trap.Damage);
	}

	/// <summary>
	/// Teleport the player back a random place (from the last 5 that they were at).
	/// The first element in the stack is the position of that trap, we don't want
	/// it to count as one of the last 5 places that the player was at. 
	/// That is why we do one last Pop after the loop.
	/// </summary>
	public static void TeleportBack(PlayerController player, Trap trap){
		int randPlace = Random.Range(0, 5);
		
		for(int i = 0; i < randPlace; i++){
			player.PlayerMovementHistory.Pop();
		}

		player.RB2D.MovePosition(player.PlayerMovementHistory.Pop());
	}


	public static void ChangeCharacter(PlayerController player, Trap trap){
		player.SwitchCharacter();
	}
}
