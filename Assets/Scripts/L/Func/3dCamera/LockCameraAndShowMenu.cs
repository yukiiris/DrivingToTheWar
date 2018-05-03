using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityStandardAssets.Characters.FirstPerson{
public class LockCameraAndShowMenu : MonoBehaviour {
		public GameObject dialog;
		public GameObject fps;
		public GameObject menu;
		public GameObject cur;
		public GameObject camlock;
		private LongTimePress ltp;
		public bool flag = true;
		// Use this for initialization
		void Start () {
			ltp = GetComponent<LongTimePress> ();
			dialog = GameObject.Find ("dialog");
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

		public void mLock()
		{
			fps.GetComponent<FPSCon>().mouselock = false;
			//fps.GetComponent<FPSCon> ().enabled = false;
			menu.SetActive(false);
			cur.SetActive(false);
			camlock.SetActive(false);
			flag = false;
		}

		public void munLock()
		{
			fps.GetComponent<FPSCon>().mouselock = false;
			//fps.GetComponent<FPSCon> ().enabled = false;
			menu.SetActive(true);
			cur.SetActive(false);
			camlock.SetActive(true);
			flag = true;
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
			this.closedialog();
		}

		public void closedialog(){
			for (int i = 0; i < 6; i++) {
				dialog.transform.GetChild (i).gameObject.SetActive (false);
			}

			dialog.transform.GetChild (6).gameObject.GetComponent<Text> ().text = "";
		}
	}	
}