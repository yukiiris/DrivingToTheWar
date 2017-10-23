using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopWords : MonoBehaviour {
	private Explore[] words;
	private int i = 0;
	private int endNum=0;


	// Use this for initialization
	void Start () {
		words = GetComponents<Explore> ();
		endNum = words.Length;
	}

	void OnMouseUp(){
		if (i < endNum-1) {
			words [i].enabled = false;
			i++;
			words [i].enabled = true;
		}
		else if (i == endNum-1) {
			words [i].enabled = false;
			i=0;
			words [i].enabled = true;
		}


	}
}
