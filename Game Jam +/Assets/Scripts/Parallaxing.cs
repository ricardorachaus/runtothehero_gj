using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

	public float smoothing = 1f;
	public Transform[] backgrounds;

	private Transform cam;
	private Vector3 previousCameraPosition;
	private float[] parallaxScales;

	private void Awake() {
		cam = Camera.main.transform;
	}

	
	private void Start () {
		previousCameraPosition = cam.position;
		parallaxScales = new float[backgrounds.Length];

		for (int i = 0; i < backgrounds.Length; i++) {
			parallaxScales[i] = backgrounds[i].position.z * -1;
		}
	}
	
	private void Update () {
		for(int i = 0; i < backgrounds.Length; i++) {
			float parallax = (previousCameraPosition.x - cam.position.x) * parallaxScales[i];
			float backgroundTargetPositionX = backgrounds[i].position.x + parallax;
			Vector3 backgroundTargetPosition = new Vector3(backgroundTargetPositionX, backgrounds[i].position.y, backgrounds[i].position.z);
			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPosition, smoothing * Time.deltaTime);
		}

		previousCameraPosition = cam.position;
	}
}
