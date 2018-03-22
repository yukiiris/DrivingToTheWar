using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHerbs : MonoBehaviour {
	public GameObject rm;
	public GameObject[] herbs = new GameObject[18];
	public int[] randomNum;
	private bool iffirst = true;

	// Use this for initialization
	void Start () {
		rm = GameObject.FindGameObjectWithTag ("random");
		randomNum = rm.GetComponent<RandomNum> ().randomNum;
	}

	void Update(){
		if (iffirst) {
			for (int i = 0; i < 9; i++) {
//				print (i);
//				print (ifExist (randomNum, i));
				if (ifExist (randomNum, i)) {
					herbs [i * 2].SetActive (true);
					herbs [i * 2 + 1].SetActive (true);
				}
			}
			iffirst = false;
		}
	}

	static public bool ifExist(int[] array,int num){
		bool isExist = false;
		for (int i = 0; i < array.Length; i++) {
			if (array [i] == num) {
				isExist = true;
			}
		}
		return isExist;
	}


}
