using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TArrow : MonoBehaviour {

	public TangramManager manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		manager.puzzles[manager.n - 1].SetActive(false);
		manager.f();
		manager.puzzles[manager.n].SetActive(true);
		if (manager.n == 3)
		{
			manager.tangrams[3].transform.Rotate(new Vector3(0, 0, -90));
			manager.tangrams[4].transform.Rotate(new Vector3(0, 0, 180));
		}
		gameObject.SetActive(false);
	}
}
