using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonAni : MonoBehaviour {
	public float dis = 0.02f;
	void OnMouseDown(){
		transform.Translate (0,-dis,0);
	}

	void OnMouseUp(){
		transform.Translate (0,dis,0);
	}
}
