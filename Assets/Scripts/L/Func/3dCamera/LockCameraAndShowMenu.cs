using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson{
public class LockCameraAndShowMenu : MonoBehaviour {
		public GameObject fps;
		public GameObject menu;
		public GameObject cur;
		public GameObject camlock;
		private LongTimePress ltp;
		private bool flag = true;
		// Use this for initialization
		void Start () {
			ltp = GetComponent<LongTimePress> ();
		}
	
		// Update is called once per frame
		void Update () {
			if(ltp.ifLongTimePress&&flag){
				this.CamLock ();
				//camlock.SetActive (true);
			}
		}

		public void CamLock(){
			fps.GetComponent<FPSCon> ().mouselock = false;
			//fps.GetComponent<FPSCon> ().enabled = false;
			menu.SetActive (true);
			cur.SetActive (false);
			camlock.SetActive (true);
			flag = false;
		}

		public void Unlock(){
			fps.GetComponent<FPSCon> ().enabled = true;
			fps.GetComponent<FPSCon> ().mouselock = true;
			menu.SetActive (false);
			cur.SetActive (true);
			flag = true;
		}
		public void unlock(){
			camlock.SetActive (false);
		}
	}	
}