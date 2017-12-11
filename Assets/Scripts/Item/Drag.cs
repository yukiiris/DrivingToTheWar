using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {
	private Vector3 mousePos;

	void Start () {
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
	}

	void OnMouseDrag(){
		Vector3 vector = Camera.main.ScreenToWorldPoint(mousePos);
		transform.position = new Vector3(vector.x, vector.y, transform.position.z);
	}

	void Update () {
		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
	}
}
