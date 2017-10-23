using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfPrint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<UseItem> ().ifUse) {
			EventButton.buttons[2] = true;
			GetComponent<C_PrintWarpass> ().enabled = true;
		}
	}
}
