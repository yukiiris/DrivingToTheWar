using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour {
	int count = 0;
	LogManager log;
	Dialog dialog;
	public UseItem item;
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
		print(EventButton.buttons[9]);
		if (count == 0 && !item.ifUse)
		{
			StartCoroutine(f());
		}
		else if (count == 1 && !item.ifUse)
		{
			log.show("她十分专心地干着手上的活儿，还是不要去打扰她了", 2);
		}
		else if (item.ifUse && count == 1)
		{
			EventButton.buttons[9] = true;
			StartCoroutine(g());
		}
		else if (item.ifUse && count == 2 && EventButton.buttons[10])
		{
			EventButton.buttons[12] = true;
			StartCoroutine(h());
		}
	}

	IEnumerator f()
	{
		log.show("您好，我是路过的行人，您的女儿看上去生病了，有什么可以帮到您的吗", 2);
		yield return new WaitForSeconds(2);
		dialog.show("谢谢您的好意，不过医师离开了，这里没人会配置退烧药。就让她好好休息吧，过几天她会好起来的", new Vector3(100, 150, 0));
		yield return new WaitForSeconds(3);
		log.show("如果我找到了药水会拿来的", 2);
		yield return new WaitForSeconds(2);
		dialog.show("感激不尽", new Vector3(100, 150, 1)); 
		count++;
	}

	IEnumerator g()
	{
		dialog.show("您给我女儿找来了药吗", new Vector3(100, 150, 0));
		yield return new WaitForSeconds(3);
		log.show("是的，她应该快好了", 2);
		yield return new WaitForSeconds(2);
		dialog.show("真是太感激您了！我......请您再帮我一个忙，帮我把这件衣服送去给村口的那名士兵吧，我还有些事要忙......", new Vector3(100, 150, 1));
		count++;
	}

	IEnumerator h()
	{
		log.show("那位士兵给了我这个", 2);
		yield return new WaitForSeconds(2);
		dialog.show("他......哎，好心的女士，这片花瓣送给你，希望您一路顺风", new Vector3(100, 150, 0));
		yield return new WaitForSeconds(3);
		log.show("谢谢，不过是举手之劳", 2);
		//yield return new WaitForSeconds(2);
		//dialog.show("真是太感激您了！我......请您再帮我一个忙，帮我把这件衣服送去给村口的那名士兵吧，我还有些事要忙......", new Vector3(100, 100, 1));
		count++;
	}
}
