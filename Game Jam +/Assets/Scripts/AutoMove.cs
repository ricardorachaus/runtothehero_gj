using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {

	public bool toLeft;
	public float speed;

	private float signal;
	private Rigidbody2D rb;

	private void Start() {
		signal = toLeft ? -1 : 1;
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update() {
		Move();
	}

	private void Move() {
		rb.velocity = new Vector2(signal * speed, rb.velocity.y);
	}

}
