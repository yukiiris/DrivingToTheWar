using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookAniCon : MonoBehaviour {

	private Animator ani;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(EventButton.ifNoteChange){
			ani.SetBool ("ifChange",true);
			EventButton.ifNoteChange = false;
		}
		if (ani.GetCurrentAnimatorClipInfo (0) [0].clip.name == "notechange"&&ani.GetCurrentAnimatorStateInfo (0).normalizedTime>=1f) {
			ani.SetBool ("ifChange",false);
		}
	}
}
