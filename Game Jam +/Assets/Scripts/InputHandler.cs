using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
	
	public GameManager manager;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			manager.Change();
		}
	}
}
