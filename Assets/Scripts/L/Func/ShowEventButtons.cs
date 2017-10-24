using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEventButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showEventButtons(){

		for (int i = 0; i < EventButton.buttons.Length; i++) {
			print (i);
			print (EventButton.buttons [i]);
		}
	}
}
