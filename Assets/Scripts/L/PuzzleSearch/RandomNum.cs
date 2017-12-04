using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNum : MonoBehaviour {

	public int[] randomNum;
	public int size;
	public int length;

	// Use this for initialization
	void Start () {
		randomNum [0] = Random.Range (0, size);

		int i = 1;
		int m = 0;
		length = randomNum.Length;
		bool ifagain = false;
		while (i < length) {
			randomNum [i] = Random.Range (0, size);
			while (m < i) {
				if (randomNum [m] == randomNum [i]) {
					ifagain = true;
				}
				++m;
			}
			if (ifagain == false) {
				++i;
			} else {
				ifagain = false;
			}
			m = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
