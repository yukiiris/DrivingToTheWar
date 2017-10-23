using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour {

	private SpriteRenderer rend;
	private Color col;
	private Color begin;
	public float a = 0.3f;
	public float delta = 0.01f;
	private bool ifIncrease = true;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
		col = rend.color;
		begin = col;
	}
	
	// Update is called once per frame
	public void changeAlpha () {
		if(ifIncrease){
			col.a += delta;
			rend.color = col;
		}
		if (col.a >= a) {
			ifIncrease = false;
		}
		if(!ifIncrease&& col.a >= begin.a){
			col.a -= delta;
			rend.color = col;
		}
		if (col.a < begin.a) {
			ifIncrease = true;
		}


	}
}
