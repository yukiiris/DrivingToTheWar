using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandmom : MonoBehaviour {
	public Dialog dialog;
	LogManager log;
	public GameObject arrow;
	int count = 0;
	bool mu = true;
	// Use this for initialization
	void Start () {
		dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();
		log = GameObject.Find("LogManager").GetComponent<LogManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (mu)
		{
			arrow.SetActive(true);
		}
		else
		{
			arrow.SetActive(false);
		}
	}

	private void OnMouseDown()
	{
		if (count == 0)
		{
			StartCoroutine(f());
		}
		else
		{
			log.show(" 哎，也不知道她几时能回来......", 2);
		}
	}

	IEnumerator f()
	{
		mu = false;
		log.show("“您好，请问这里曾住着一位医师吗？”", 2);
		yield return new WaitForSeconds(2);
		dialog.show("嗯。小姑娘，你是谁呀？我怎么没见过你？", new Vector3(100, 0, 0));
		yield return new WaitForSeconds(3);
		log.show("“我只是个路过的行人，村子里的麦子里长了蝗虫，我想来看看能不能找到驱虫药的配方。”", 2);
		yield return new WaitForSeconds(2);
		dialog.show("这样啊......你随意看看吧，我这个老婆子也帮不上什么忙", new Vector3(100, 0, 1));
		count++;
		mu = true;
		EventButton.buttons [18] = true;
		EventButton.ifNoteChange = true;
	}
}
