using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	bool hasWinner;

	void OnTriggerEnter2D(Collider2D collider){
		if (!hasWinner) {
			if (collider.transform.parent.name == "CarPlayer1") {
				LevelController.instance.SetWinner (1);
				hasWinner = true;
			} else if (collider.transform.parent.name == "CarPlayer2") {
				LevelController.instance.SetWinner (2);
				hasWinner = true;
			}
		}
	}
}
