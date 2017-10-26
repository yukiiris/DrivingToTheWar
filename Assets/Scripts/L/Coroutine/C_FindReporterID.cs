using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_FindReporterID : MonoBehaviour {
	public LogManager manager;
	public GameObject g1;
	public GameObject g2;

	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (FindReporterID ());
	}
		
	IEnumerator FindReporterID(){
		manager.show ("总算在最后这一本书中找到了记者证，希望我以后不要这么对三落四了。",3f);
		Fade.FadeOut (g1,0.8f);
		yield return null;
		GetComponent<C_MoveToNotebook> ().enabled = true;
		yield return new WaitForSecondsRealtime (0.5f);
		Destroy (g1);
		Destroy (g2);
		EventButton.ifNoteChange = true;
		yield return null;


	}

}
