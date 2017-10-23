using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCommon : Statem {

	public float myX;
	public float myY;
	public bool ifClick = false;
	public bool ifUse = false;

	void Start () {
		
		currentState = new UnPickState ();
		myX = gameObject.transform.position.x;
		myY = gameObject.transform.position.y;
	}

	void OnMouseUp(){
		ifClick = false;
	}

	void OnMouseDown(){
		ifClick = true;
	}
	
	class UnPickState : StateM {
		public override void Enter (Statem statem)
		{

		}

		public override void Execute (Statem statem)
		{
			if (statem.gameObject.transform.position.x > 6.5f && statem.GetComponent<ItemCommon> ().ifClick == true) {
				statem.ChangeState (new UnUseState ());
			} 
			else if (statem.GetComponent<ItemCommon> ().ifClick == false) {
				statem.gameObject.transform.position = new Vector3 (statem.GetComponent<ItemCommon> ().myX, statem.GetComponent<ItemCommon> ().myY, -1);
			}
		}

		public override void Exit (Statem statem)
		{
			
		}
	}

	class UnUseState : StateM {
		public override void Enter (Statem statem)
		{

		}

		public override void Execute (Statem statem)
		{
			if(statem.GetComponent<ItemCommon> ().ifClick == false && statem.gameObject.transform.position.x > 6.5f && statem.gameObject.transform.position.x < 9.5f && statem.gameObject.transform.position.y < 5.3f && statem.gameObject.transform.position.y > -1.3f){
				statem.GetComponent<ItemCommon> ().myX = statem.gameObject.transform.position.x ;
				statem.GetComponent<ItemCommon> ().myY = statem.gameObject.transform.position.y ;
			}
			if (statem.GetComponent<ItemCommon>().ifClick == false && statem.GetComponent<ItemCommon>().ifUse == false && (statem.gameObject.transform.position.x < 6.5f|| statem.gameObject.transform.position.x >9.6f|| statem.gameObject.transform.position.y < -1.3f || statem.gameObject.transform.position.y > 5.3f))
			{
				statem.gameObject.transform.position = new Vector3(statem.GetComponent<ItemCommon>().myX, statem.GetComponent<ItemCommon>().myY, -1);
			}
		}

		public override void Exit (Statem statem)
		{

		}
	}
		
}
