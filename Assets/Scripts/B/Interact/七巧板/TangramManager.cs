using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramManager : MonoBehaviour {
	public int a = 0;
	public int n = 1;
	public GameObject[] puzzle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (a == 7 && n <= 3)
		{
			puzzle[n].SetActive(false);
			n++;
			puzzle[n].SetActive(true);
			a = 0;
		}
		if (n == 4)
		{
			puzzle[n].SetActive(false);
		}
	}
}
