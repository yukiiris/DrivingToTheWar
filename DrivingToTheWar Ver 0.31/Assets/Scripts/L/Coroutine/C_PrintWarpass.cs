using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PrintWarpass : MonoBehaviour {
	public LogManager manager;

	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (PrintWarpass ());
	}
	IEnumerator PrintWarpass(){
		transform.GetChild (0).gameObject.SetActive (true);
		Fade.FadeIn (transform.GetChild (0).gameObject,0.8f);
		transform.GetChild (1).gameObject.SetActive (true);
		Fade.FadeIn (transform.GetChild (1).gameObject,0.8f);
		manager.show ("在空白的通行证上印上了我的个人信息，这样我就能合法进入战地了。",3f);
		yield return new WaitForSecondsRealtime (2f);

		transform.GetChild (1).gameObject.GetComponent<C_MoveToNotebook> ().enabled = true;
		yield return null;
		Fade.FadeOut (transform.GetChild (0).gameObject, 0.8f);
		yield return new WaitForSecondsRealtime (2f);
		Destroy (transform.GetChild (0).gameObject);
		yield return null;

	}
}
