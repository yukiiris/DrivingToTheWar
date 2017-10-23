using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverAni : MonoBehaviour {

	public string name;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (animator.GetBool ("ifOn") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f&&animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == name) {
			animator.SetBool ("ifOn", false);
		}

	}

	void OnMouseOver(){
		animator.SetBool ("ifOn", true);
	}


}
