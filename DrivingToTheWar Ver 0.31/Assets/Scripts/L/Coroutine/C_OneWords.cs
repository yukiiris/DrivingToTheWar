using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_OneWords : MonoBehaviour {
	public LogManager manager;
	public string words;
	public float time;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (OneWords ());
	}
	
	IEnumerator OneWords(){
		manager.show (words,time);
		yield return null;
	
	}
}
