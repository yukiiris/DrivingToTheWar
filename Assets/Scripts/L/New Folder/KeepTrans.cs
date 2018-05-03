using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrans : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if(!EventButton.buttons[10]){
			gameObject.GetComponent<MeshRenderer> ().material.color = new Color (1, 1, 1, 1);
			transform.GetChild (0).gameObject.GetComponent<MeshRenderer> ().material.color = new Color (1, 1, 1, 0);
		}
	}
}
