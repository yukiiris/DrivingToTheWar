using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour {
	public UseItem item;
	public LogManager log;
	public Dialog dialog;
	public GameObject tangram;
	public GameObject shield;
	public GameObject arrow;
	public GameObject book;
	bool mu= true;
	int count = 0;
	bool flag = false;
	// Use this for initialization
	void Start () {
		log = GameObject.Find("LogManager").GetComponent<LogManager>();
		dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		if (item.ifUse && count == 0)
		{
			log.show("我把药喂给她了，现在她的体温降下去不少，去告诉她的母亲这个好消息吧。", 2.3f);
			count++;
		}
		if (mu)
		{
			arrow.SetActive(true);
		}
		else
		{
			arrow.SetActive(false);
		}
		if (flag && count == 2)
		{
			tangram.SetActive(true);
			shield.SetActive(true);
			flag = false;
		}
	}

	void OnMouseDown()
	{
		if(!item.ifUse){
			log.show("床上躺着一个小女孩，她看起来发烧了。可怜的孩子......", 2);
		}
		if (EventButton.buttons[12] && count == 1)
		{
			gameObject.GetComponent<LittleGirlAniCon> ().isChange = true;
			StartCoroutine(f());
		}

		if (EventButton.buttons[12] && count == 2 && !flag && !tangram.active)
		{
			StartCoroutine(g());
		}
		if (EventButton.buttons[12] && count == 3)
		{
			log.show("她刚刚退烧，还是卧床休息比较好。", 2);
			count++;
		}
	}

	IEnumerator f()
	{
		mu = false;
		dialog.show("是你给我找来的药吗，谢谢你，我感觉好多了", new Vector3(-200, 100, 0));
		yield return new WaitForSeconds(3);
		log.show("“不客气，你还有什么需要的吗？”", 2);
		yield return new WaitForSeconds(2);
		dialog.show("姐姐可以陪我玩一会儿吗", new Vector3(-200, 100, 0));
		yield return new WaitForSeconds(3);
		log.show("“好啊。”", 2);
		yield return new WaitForSeconds(2);
		count++;
		flag = true;
		mu = true;
	}

	IEnumerator g()
	{
		mu = false;
		log.show("你真厉害，不过我也很厉害哦，我和隔壁的医师姐姐学过医术呢", 2);
		yield return new WaitForSeconds(2);
		log.show("“真的吗？那你知道驱虫药水的配方吗。”", 2);
		yield return new WaitForSeconds(2);
		log.show("当然，我把它夹在这本红色的书里了，你可以随便看哦", 2);
		book.SetActive (true);
		yield return new WaitForSeconds(2);
		log.show("“这可真是帮了大忙了。”", 1);
		yield return new WaitForSeconds(1);
		count++;
		mu = true;
	}

}
