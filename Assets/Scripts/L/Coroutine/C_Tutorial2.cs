using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Tutorial2 : MonoBehaviour {
	public LogManager manager;
	public GameObject left;
	public GameObject right;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (Tutorial2());
	}

	IEnumerator Tutorial2(){
		left.SetActive (true);
		right.SetActive (true);
		Fade.FadeIn (left);
		Fade.FadeIn (right);
		manager.show ("四处找找需要的东西吧。",2f);
		yield return new WaitForSecondsRealtime(2f);
		Destroy (gameObject);
		yield return null;
	}

}
