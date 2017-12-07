using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockCameraCursor : MonoBehaviour {
	private float amount = 0;
	public GameObject cam;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		amount = (float)cam.GetComponent<LongTimePress> ().timer / (float)cam.GetComponent<LongTimePress> ().timeMax;
		if(amount<0.2f){
			amount = 0;
		}
		GetComponent<Image> ().fillAmount = amount;
	}
}
