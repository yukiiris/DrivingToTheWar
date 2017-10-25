using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFindTip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(EventButton.buttons[5]){
			Destroy (GetComponent<Interact> ());
			GetComponent<Explore> ().enabled = true;
			
		}
	}
}
