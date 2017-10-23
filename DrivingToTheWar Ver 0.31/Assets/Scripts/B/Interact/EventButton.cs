using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButton : MonoBehaviour {

	public static bool[] buttons = { false, false, false, false };
	// Use this for initialization
	private void Awake()
	{
		for (int i = 0; i < 5; i++)
		{
			//buttons[i] = false;
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		print(0);
//		print (buttons[0]);
//		print(1);
//		print (buttons[1]);
//		print(2);
//		print (buttons[2]);
//		print(3);
//		print (buttons[3]);
	}
}
