using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Solder : MonoBehaviour {

	// Use this for initialization
	public Dialog manager;
	public LockCameraAndShowMenu l;
	public LogManager log;
	int count = 0;
	void Start () {
		manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
		log = GameObject.Find("LogManager").GetComponent<LogManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		StartCoroutine(f());
	}

	IEnumerator f()
	{
		if (l.flag == false && count == 0)
		{
			manager.show("我在等人......如果可以的话，我一辈子也不想离开这里。", new Vector3(0, 1, 1));
			yield return new WaitForSeconds(1f);
			log.show("能为祖国冲锋陷阵是至高无上的荣耀", 1);
			count++;
		}
		else if (!l.flag && count == 1)
		{
			log.show("或许您说的对吧", 1);
			count++;
		}
		else if (l.flag && count == 0)
		{
			log.show("我应该去和他说说话", 1);
		}
		else
		{
			print(count);
			manager.show("让我再多看一眼这里的风景吧", new Vector3(0, 1, 1));
		}
	}
}
