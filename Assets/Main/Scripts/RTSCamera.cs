using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSCamera : MonoBehaviour {
	public float MoveSpeed = 8f;
	public float ZoomSpeed = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horInput = Input.GetAxis ("Horizontal");
		float verInput = Input.GetAxis ("Vertical");

		float zoomInput = Input.GetAxis ("Mouse ScrollWheel");

		Vector3 move = new Vector3 (horInput, 0f, verInput);
		move *= Time.deltaTime;
		move *= MoveSpeed;
		transform.position += move;

		Vector3 zoom = new Vector3 (0, 0, zoomInput);
		zoom *= ZoomSpeed;
		transform.Translate (zoom, Space.Self);
	}
}
