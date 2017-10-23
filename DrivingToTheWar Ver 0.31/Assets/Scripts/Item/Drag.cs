using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {
	private Vector3 mousePos;

	void Start () {
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y,9);
	}
	void OnMouseDrag(){
		transform.position = Camera.main.ScreenToWorldPoint (mousePos);
	}

	void Update () {
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y,9);
	}
}
