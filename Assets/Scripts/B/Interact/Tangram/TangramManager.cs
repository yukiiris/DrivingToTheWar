using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramManager : MonoBehaviour {
	public int a = 0;
	public int n = 1;
	public GameObject[] puzzles;
	public Tangram[] tangrams;
	public GameObject tangram;
	public GameObject arrow;
	public GameObject sheild;
	Vector3[] positions = new Vector3[6];
	// Use this for initialization
	
	void Start () {
		int i = 0; 
		foreach (Tangram tangram in tangrams)
		{
			positions[i] = tangram.transform.position;
			i++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (a == 6 && n <= 3)
		{
			//puzzles[n].SetActive(false);
			n++;
			//f();
			//puzzles[n].SetActive(true);
			arrow.SetActive(true);
			a = 0;
		}
		if (n == 4)
		{
			//puzzles[n].SetActive(false);
			sheild.SetActive(false);
			tangram.SetActive(false);
		}
	}

	public void f()
	{
		int i = 0;
		foreach (Tangram tangram in tangrams)
		{
			tangram.GetComponent<Drag>().enabled = true;
			tangram.transform.position = positions[i];
			tangram.flag = true;
			i++;
		}
	}
}
