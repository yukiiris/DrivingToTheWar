using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayerandColz : MonoBehaviour {

	private int layer;
	public int deltaLayer = 1;



	void Start () {
		layer = GetComponent<SpriteRenderer> ().sortingOrder;
	}
	

	void OnMouseDown(){
			GetComponent<SpriteRenderer> ().sortingOrder = layer + deltaLayer;
		}


	void OnMouseUp(){
			GetComponent<SpriteRenderer> ().sortingOrder = layer;
		}

}
