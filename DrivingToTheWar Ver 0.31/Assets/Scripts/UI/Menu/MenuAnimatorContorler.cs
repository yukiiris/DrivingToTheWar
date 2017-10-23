using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimatorContorler : Statem {

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
		}
		public override void Execute (Statem statem)
		{
			if (statem.GetComponent<MenuAnimatorContorler> ().omt.ifTouch) {
				statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOff", false);
				statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOpen", true);
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

		}
		public override void Execute (Statem statem)
		{
			if(statem.GetComponent<MenuAnimatorContorler> ().ani.GetCurrentAnimatorStateInfo(0).normalizedTime>=1){
				print (0);
				statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOpen", false);
				statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOn", true);
				statem.ChangeState (new OnState());
			}
		}
		public override void Exit (Statem statem)
		{

		}

		class OnState:StateM{
			public override void Enter (Statem statem)
			{
				statem.GetComponent<MenuAnimatorContorler> ().audioController.SetActive (true);
				statem.GetComponent<MenuAnimatorContorler> ().exit.SetActive (true);

			}
			public override void Execute (Statem statem)
			{
				if (statem.GetComponent<MenuAnimatorContorler> ().omt.ifTouch) {
					statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOn", false);
					statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifClose", true);
					statem.ChangeState (new CloseState());
				}

			}
			public override void Exit (Statem statem)
			{
				statem.GetComponent<MenuAnimatorContorler> ().audioController.SetActive (false);
				statem.GetComponent<MenuAnimatorContorler> ().exit.SetActive (false);
			}
		}

		class CloseState:StateM{
			public override void Enter (Statem statem)
			{

			}
			public override void Execute (Statem statem)
			{
				if(statem.GetComponent<MenuAnimatorContorler> ().ani.GetCurrentAnimatorStateInfo(0).normalizedTime>=1){
					print (0);
					statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifClose", false);
					statem.GetComponent<MenuAnimatorContorler> ().ani.SetBool ("ifOff", true);
					statem.ChangeState (new OffState());
				}

			}
			public override void Exit (Statem statem)
			{

			}
		}
	}



}
