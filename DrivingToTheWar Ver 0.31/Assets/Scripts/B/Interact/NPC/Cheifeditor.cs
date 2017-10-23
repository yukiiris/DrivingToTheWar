using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheifeditor : MonoBehaviour {

	public Dialog manager;
	int[] words = { 0, 0, 0, 0 };
	public GameObject pass;
	//public bool isShow = false;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
//		print(EventButton.buttons[0]);
//		print(EventButton.buttons[1]);
//		print(EventButton.buttons[2]);
//		print(EventButton.buttons[3]);
		//事件零：拿到记者证
		//事件一：拿到车钥匙
		//事件二：打印通行证
		//事件三：拿到通行证

		//0000、0001、0010、0011
		//0100、0101、0110、0111
		//1000、1001、1010、1011
		//1100、1101、1110、1111

		//0001、0010、0011
		//0101、0110、0111
		//1001、1010、1011
		//1101、1110、1111
		if (!EventButton.buttons[3])//没收拾完铅字架
		{
			if (words[0] == 0)
			{
				manager.show("去把铅字架收拾好，然后来我这拿通行证。", new Vector3(-400, 100, 0));
				words[0]++;
			}
			else if (words[0] == 1)
			{
				manager.show("收拾完了吗？", new Vector3(-400, 100, 0));
				words[0] = 0;
			}
			return;
		}
		//0010、0011
		//0110、0111
		//1010、1011
		//1110、1111
		if (EventButton.buttons[3] && !EventButton.buttons[2])//收拾完铅字架，没拿到车钥匙
		{
			if (!pass.active)
			{
				pass.SetActive(true);
			}
			if (words[1] == 0)
			{
				manager.show("既然申请到了去前线采访的任务，那就好好干。这是批下来的通行证，拿去把你的信息印上去吧。", new Vector3(-400, 100, 0));
				words[1]++;
			}
			else if (words[1] == 1)
			{
				manager.show("快点去印刷台印好你的信息。", new Vector3(-400, 100, 0));
				words[1] = 0;
			}
			return;
		}

		//0010
		//0110、0111
		//1010
		//1110、1111
		if (!EventButton.buttons[1] && EventButton.buttons[2] && EventButton.buttons[3])
		{
			print(11);
			manager.show("好好想想他会把密码设置成什么，别来问我。", new Vector3(-400, 100, 0));
			return;
		}
		//0010
		//0110
		//1010
		//1110、1111
		if (!EventButton.buttons[0] && EventButton.buttons[1] && EventButton.buttons[3])
		{
			manager.show("你的记者证带上了吗？", new Vector3(-400, 100, 0));
			return;
		}
		if (EventButton.buttons[0] && EventButton.buttons[1] && EventButton.buttons[2] && EventButton.buttons[3])
		{

			if (words[2] == 0)
			{
				manager.show("如何鼓舞我们英勇的战士，如何表彰他们的亲属？这是你时刻应该考虑的问题。……出发吧。谨记你的职责。", new Vector3(-400, 100, 0));
				words[2]++;
			}
			else if(words[2] == 1)
			{
				manager.show("赶快出发，别耽搁了。", new Vector3(-400, 100, 0));
				words[2] = 0;
			}
		}
	}
}
