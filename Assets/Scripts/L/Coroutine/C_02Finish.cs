using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_02Finish : MonoBehaviour {
	public LogManager manager;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EventButton.buttons [20]) {
			gameObject.GetComponent<Explore> ().enabled = false;
		}
	}

	void OnMouseDown(){
		if (EventButton.buttons [20]) {
			StartCoroutine (Finish ());
		}
	}

	IEnumerator Finish(){
		manager.show ("一切都准备好了，是时候继续前行了。",2f);
		yield return new WaitForSecondsRealtime (2f);
		SceneChanger.Change("02_", "TFP");
		yield return null;
	}
}
