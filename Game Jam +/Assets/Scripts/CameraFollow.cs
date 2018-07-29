using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float dampTime = 0.15f;

    private Camera cam;
    private Vector3 velocity = Vector3.zero;
 
    private void Start() {
        cam = GetComponent<Camera>();
    }

     void FixedUpdate () {
         Smooth();
     }

     private void Smooth() {
        Vector3 point = cam.WorldToViewportPoint(target.position);
        Vector3 delta = target.position - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
        Vector3 destination = transform.position + delta;
        Vector3 position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        position.y = cam.transform.position.y;
        transform.position = position;
     }

}
