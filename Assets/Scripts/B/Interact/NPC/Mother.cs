using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour {
	int count = 0;
	LogManager log;
	Dialog dialog;
	// Use this for initialization
	void Start () {
		dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();
		log = GameObject.Find("LogManager").GetComponent<LogManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (count == 0)
		{
			StartCoroutine(f());
		}
		else
		{
			log.show(" 她十分专心地干着手上的活儿，还是不要去打扰她了", 2);
		}
	}

	IEnumerator f()
	{
		log.show("您好，我是路过的行人，您的女儿看上去生病了，有什么可以帮到您的吗", 2);
		yield return new WaitForSeconds(2);
		dialog.show("谢谢您的好意，不过医师离开了，这里没人会配置退烧药。就让她好好休息吧，过几天她会好起来的", new Vector3(100, 100, 0));
		yield return new WaitForSeconds(3);
		log.show("如果我找到了药水会拿来的", 2);
		yield return new WaitForSeconds(2);
		dialog.show("感激不尽", new Vector3(100, 100, 1));
		count++;
	}
}
