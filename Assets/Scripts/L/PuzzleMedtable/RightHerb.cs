using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHerb : MonoBehaviour {
	public GameObject rm;
	public int[] randomnum;
	public int[] coldrex;
	public int[] pesticide;

	// Use this for initialization
	void Start () {
		randomnum = rm.GetComponent<RandomNum> ().randomNum;
		coldrex = new int[] {randomnum[1],randomnum[6],randomnum[3],randomnum[4],randomnum[0],randomnum[2],randomnum[5]};
		pesticide = new int[] {randomnum[5],randomnum[3],randomnum[0],randomnum[2],randomnum[1],randomnum[6],randomnum[4]};
		print (ifListequalArray(new List<int>(new int[]{1,2,3}),new int[]{1,2,3}));
	}

	void Update () {
		if (HerbsList.herblist.Count == 7) {
			ifColdrexRight ();
		}
	}

	public bool ifColdrexRight(){
		if (ifListequalArray(HerbsList.herblist, coldrex)) {
			print ("right!");
			return true;
		} else
			return false;
	} 

	public bool ifListequalArray(List<int> list,int[] array){
		bool ifequal = true;
		for (int i = 0; i < array.Length; i++) {
			if(list[i]!=array[i]){
				ifequal = false;
			}
		}
		return ifequal;
	}
}
