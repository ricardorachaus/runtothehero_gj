using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	SpriteRenderer rend;
	
	private void Start () {
		rend = GetComponent<SpriteRenderer>();
	}

	private IEnumerator Fade() {
		for (float f = 1f; f >= -0.05f; f -= 0.05f) {
			Color color = rend.material.color;
			color.a = f;
			rend.material.color = color;
			yield return new WaitForSeconds(0.05f);
		}
	}

	public void StartFading() {
		StartCoroutine(Fade());
	}
	
}
