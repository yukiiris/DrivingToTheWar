using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explore : MonoBehaviour {

	public LogManager manager;
	public int i = 0;
	public string[] words;
	public float time = 4;
	public Text text;
	public bool isNotCycle = false;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("LogManager").GetComponent<LogManager>();
		//word = new string[i];
		text = GameObject.FindGameObjectWithTag("text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (!text.text.Equals("") && text.text != null)
		{
			return;
		}
		string word = words[i];
		if (i == (words.Length - 1))
		{
			if (!isNotCycle)
			{
				i = 0;
			}
		}
		else
		{
			i++;
		}
		manager.show(word, time);	
	}
}
