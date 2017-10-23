using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAniCon : Statem {

	private Animator ani;
	private OnMouseTouch omt;
	public GameObject audioController;
	public GameObject exit;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
		omt = GetComponentInParent<OnMouseTouch> ();
		currentState = new OffState ();
	}

	class OffState:StateM{
		public override void Enter (Statem statem)
		{
			statem.GetComponent<MenuAniCon> ().ani.SetFloat ("speed",0f);
		}
		public override void Execute (Statem statem)
		{
			if (statem.GetComponent<MenuAniCon> ().omt.ifTouch) {
				statem.GetComponent<MenuAniCon> ().ani.SetBool ("ifOn", true);
				statem.ChangeState (new OpenState());
			}

		}
		public override void Exit (Statem statem)
		{
		}
	}

	class OpenState:StateM{
		public override void Enter (Statem statem)
		{
			statem.GetComponent<MenuAniCon> ().ani.SetFloat ("speed",1f);
		}
		public override void Execute (Statem statem)
		{
			if(statem.GetComponent<MenuAniCon> ().ani.GetCurrentAnimatorClipInfo(0)[0].clip.name=="openmenu"){
				if(statem.GetComponent<MenuAniCon> ().omt.ifTouch&&statem.GetComponent<MenuAniCon> ().ani.GetFloat("speed")==1f){
					statem.GetComponent<MenuAniCon> ().ani.SetFloat ("speed",-1f);

				}
				if(statem.GetComponent<MenuAniCon> ().omt.ifTouch&&statem.GetComponent<MenuAniCon> ().ani.GetFloat("speed")==0){
					statem.GetComponent<MenuAniCon> ().ani.SetFloat ("speed",-1f);
					statem.GetComponent<MenuAniCon> ().audioController.SetActive (false);
					statem.GetComponent<MenuAniCon> ().exit.SetActive (false);

				}
				if (statem.GetComponent<MenuAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.9f&&statem.GetComponent<MenuAniCon> ().ani.GetFloat("speed")==1f) {
					statem.GetComponent<MenuAniCon> ().ani.SetFloat ("speed", 0);
					statem.GetComponent<MenuAniCon> ().audioController.SetActive (true);
					statem.GetComponent<MenuAniCon> ().exit.SetActive (true);
				}
				if (statem.GetComponent<MenuAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime<=0.1f&&statem.GetComponent<MenuAniCon> ().ani.GetFloat("speed")==-1f) {
					statem.GetComponent<MenuAniCon> ().ani.SetBool ("ifOn", false);
					statem.ChangeState (new OffState());
				}
				
			}
		}
		public override void Exit (Statem statem)
		{

		}

	}
}