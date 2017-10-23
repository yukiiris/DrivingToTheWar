using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour {
	public float y = 0.01f;
	public float bound1 = 0.25f;
	public float bound2 = -0.25f;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		Debug.Log (transform.position.y);
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		pos.y = pos.y + y;
		transform.position = pos;

		if(transform.position.y>bound1||transform.position.y<bound2){
			y = y * (-1);
		}
		}

}
