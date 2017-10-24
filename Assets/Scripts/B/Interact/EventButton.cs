using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButton : MonoBehaviour {

	public static bool ifNoteChange = false;
	public static int notePage = 0;

	/// <summary>
	/// <para>0.reportid 1.key 2.puzzlefive 3.warpass 4.wall 5.tip</para> 
	/// </summary>
	public static bool[] buttons = { false, false, false, false, false, false };

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
	}
}
