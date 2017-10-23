using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If01Finish : MonoBehaviour {

	public bool ifEnd = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (EventButton.buttons [0] &&EventButton.buttons [1] &&EventButton.buttons[2]&&EventButton.buttons[3]) {
			GetComponent<Explore> ().enabled = false;
			ifEnd = true;
		}
	}

	void OnMouseDown(){
		if (ifEnd) {
			transform.GetChild (0).gameObject.SetActive (true);
			GetComponent<C_01Finish> ().enabled = true;
			this.enabled = false;
		}
	}


}
