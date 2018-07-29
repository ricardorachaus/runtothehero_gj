using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool isDead;
	public bool won;
	public float deathPosition;
	public float winPosition;

	private void Start() {
		isDead = false;
		won = false;
	}

	private void Update() {
		CheckIfPlayerIsDead();
		CheckIfPlayerWon();
	}

	private void CheckIfPlayerIsDead() {
		if (transform.position.y < deathPosition) {
			isDead = true;
		}
	}

	private void CheckIfPlayerWon() {
		if (transform.position.x >= winPosition) {
			won = true;
		}
	}
}
