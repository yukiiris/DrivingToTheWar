using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWords : MonoBehaviour {
	private Explore[] words;
	private int i = 0;
	public int endNum=0;


	// Use this for initialization
	void Start () {
		words = GetComponents<Explore> ();
	}
	
	void OnMouseUp(){
			if (i < endNum-1) {
				words [i].enabled = false;
				i++;
				words [i].enabled = true;
			}
			else if (i == endNum-1) {
				this.enabled = false;
			}


	}
}
