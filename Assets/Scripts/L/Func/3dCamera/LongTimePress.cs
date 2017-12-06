using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongTimePress : MonoBehaviour {
	public bool ifLongTimePress = false;
	public int timer = 0;
	public int timeMax;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1")){
			timer++;
			if(timer>timeMax){
				ifLongTimePress = true;
				timer = timeMax+1;
			}
		}
		else{
			timer = 0;
			ifLongTimePress = false;
		}
	}
}
