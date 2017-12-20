using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson{
public class FPSCameraControl : MonoBehaviour {
		public GameObject fps;
		public bool iflock = true;
		// Use this for initialization
		private void Start()
		{
			fps.GetComponent<LockCameraAndShowMenu>().CamLock();
		}

		void OnMouseDown(){
			if (iflock) {
				fps.GetComponent<LockCameraAndShowMenu> ().CamLock ();
			} else {
				fps.GetComponent<LockCameraAndShowMenu> ().Unlock ();
			}
		}
	}
}