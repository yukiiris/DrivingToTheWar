using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_FindReporterID : MonoBehaviour {
	public LogManager manager;

	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (FindReporterID ());
	}
		
	IEnumerator FindReporterID(){
		manager.show ("总算在最后这一本书中找到了记者证，希望我以后不要这么对三落四了。",3f);
		Fade.FadeOut (transform.parent.GetChild(1).gameObject,0.8f);
		yield return new WaitForSecondsRealtime (1f);
		GetComponent<C_MoveToNotebook> ().enabled = true;
		StopCoroutine (FindReporterID ());
		Destroy (transform.parent.GetChild(2).gameObject);
		yield return new WaitForSecondsRealtime (1f);
		Destroy (transform.parent.GetChild (1).gameObject);
		yield return null;


	}

}
