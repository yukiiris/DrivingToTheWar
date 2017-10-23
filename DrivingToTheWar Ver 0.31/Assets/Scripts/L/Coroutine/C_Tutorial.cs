using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Tutorial : MonoBehaviour {
	public LogManager manager;
	public GameObject book;
	public GameObject bookblock;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		StartCoroutine (Tutorial());
	}



	IEnumerator Tutorial(){
		manager.show ("今天是出发去前线采访的日子，心情还有些激动。",4f);
		yield return new WaitForSecondsRealtime(2f);
		manager.show ("先把笔记本拿上，看看我昨天写的备忘录里记了些什么吧。",4f);
		yield return new WaitForSecondsRealtime(2f);
		manager.show ("（拖动笔记本到右方道具栏下端）",2f);
		Fade.FadeOut (transform.GetChild(1).gameObject,0.8f);
		bookblock.SetActive(false);
		book.SetActive(true);
		transform.GetChild (2).gameObject.SetActive (true);
		yield return new WaitForSecondsRealtime(1f);
		GetComponent<IfNoteOn> ().enabled = true;
		Destroy (transform.GetChild(0).gameObject);
		Destroy (transform.GetChild (1).gameObject);
		this.enabled = false;
		yield return null;
		}
}


