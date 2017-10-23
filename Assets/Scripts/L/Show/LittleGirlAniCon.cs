using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleGirlAniCon : Statem {

	private Animator ani;
	public bool isChange = false;
	public string name;
	public int winkTime;
	public int i = 0;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
		currentState = new OffState ();
	}

	class OffState:StateM{
		public override void Enter (Statem statem)
		{
		}
		public override void Execute (Statem statem)
		{
			if (statem.GetComponent<LittleGirlAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.9f && statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == 1f) {
				statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",-1f);
			}

			if (statem.GetComponent<LittleGirlAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime <= 0.1f && statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == -1f) {
				statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",1f);
			}

			if(statem.GetComponent<LittleGirlAniCon>().isChange){
				statem.GetComponent<LittleGirlAniCon>().ani.SetBool("isChange",true);
				statem.ChangeState (new OnState());
				
			}
		}
		public override void Exit (Statem statem)
		{
			statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",1f);
		}
	}

	class OnState:StateM{
		public override void Enter (Statem statem)
		{
		}
		public override void Execute (Statem statem)
		{
			if(statem.GetComponent<LittleGirlAniCon>().ani.GetCurrentAnimatorClipInfo(0)[0].clip.name==statem.GetComponent<LittleGirlAniCon>().name){
				if (statem.GetComponent<LittleGirlAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime >= 0.9f && statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == 1f) {
					statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",0f);
				}

				if (statem.GetComponent<LittleGirlAniCon> ().i < statem.GetComponent<LittleGirlAniCon> ().winkTime&& statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == 0f) {
					statem.GetComponent<LittleGirlAniCon> ().i++;
				}
				if (statem.GetComponent<LittleGirlAniCon> ().i >= statem.GetComponent<LittleGirlAniCon> ().winkTime&& statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == 0f) {
					statem.GetComponent<LittleGirlAniCon> ().i = 0;
					statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",-1f);
				}


				if (statem.GetComponent<LittleGirlAniCon> ().ani.GetCurrentAnimatorStateInfo (0).normalizedTime <= 0.05f && statem.GetComponent<LittleGirlAniCon> ().ani.GetFloat ("speed") == -1f) {
					statem.GetComponent<LittleGirlAniCon> ().ani.SetFloat ("speed",1f);
				}


			}
		}
		public override void Exit (Statem statem)
		{
		}
	}
}
