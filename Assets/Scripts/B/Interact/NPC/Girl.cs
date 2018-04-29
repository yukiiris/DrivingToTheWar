using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour {
	public UseItem item;
	public LogManager log;
	public Dialog dialog;
	int count = 0;
	// Use this for initialization
	void Start () {
		log = GameObject.Find("LogManager").GetComponent<LogManager>();
		dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		if (item.ifUse && count == 0)
		{
			log.show("我把药喂给她了，现在她的体温降下去不少，希望她能赶快好起来", 2);
			count++;
		}
		else if (EventButton.buttons[12] && count == 1)
		{
			StartCoroutine(g());
			count++;
		}
		
	}

	IEnumerator f()
	{
		log.show("是你给我找来的药吗，谢谢你，我感觉好多了", 2);
		yield return new WaitForSeconds(2);
		dialog.show("不客气，你还有什么需要的吗", new Vector3(100, 100, 0));
		yield return new WaitForSeconds(3);
		log.show("姐姐可以陪我玩一会儿吗", 2);
		yield return new WaitForSeconds(2);
		dialog.show("好啊", new Vector3(100, 100, 1));
		count++;
	}

	IEnumerator g()
	{
		log.show("你真厉害，不过我也很厉害哦，我和隔壁的医师姐姐学过医术呢", 2);
		yield return new WaitForSeconds(2);
		dialog.show("真的吗？那你知道驱虫药水的配方吗", new Vector3(100, 100, 0));
		yield return new WaitForSeconds(3);
		log.show("当然，我把它夹在这本红色的书里了，现在送给你吧", 2);
		yield return new WaitForSeconds(2);
		dialog.show("这可真是帮了大忙了", new Vector3(100, 100, 1));
		count++;
	}

}
