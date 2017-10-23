using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTouch : MonoBehaviour {

	public bool ifTouch;

	void OnMouseDown()
	{
		ifTouch = true;
	}
	void OnMouseDrag(){
		ifTouch = false;
	}
	void OnMouseUp(){
		ifTouch = false;
	}
}
