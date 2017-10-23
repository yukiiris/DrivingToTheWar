using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNum : MonoBehaviour {

	public List<int> randomNum = new List<int> ();
	public int size;
	public int range;

	// Use this for initialization
	void Start () {
		int i = 1;
		int m = 0;
		bool ifagain = false;
		randomNum.Add(Random.Range (0, range));

		while (i < size) {
			if (!ifagain) {
				randomNum.Add (Random.Range (0, range));
			} else {
				randomNum [i] = Random.Range (0, range);
				ifagain = false;
			}
			while (m < i) {
				if (randomNum [m] == randomNum [i]) {
					ifagain = true;
				}
				++m;
			}
			if (ifagain == false) {
				++i;
			} 
			m = 0;
		}
		i = 0;
		while(i<size){
			print (i);
			print (randomNum [i]);
			i++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
