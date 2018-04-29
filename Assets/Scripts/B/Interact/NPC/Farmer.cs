using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
	public class Farmer : MonoBehaviour
	{
		public LockCameraAndShowMenu l;
		Dialog manager;
		LogManager log;
		//public GameObject fps;
		public GameObject ca;
		public GameObject con;
		bool isEnd;
		//int count = 0;

		// Use this for initialization
		void Start()
		{
			manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
			log = GameObject.Find("LogManager").GetComponent<LogManager>();
			//StartCoroutine(rotate(1));
			con.GetComponent<FPSCon>().toZero = true;
			l.CamLock();
			StartCoroutine(f());
		}

		// Update is called once per frame
		void Update()
		{
			//ca.transform.eulerAngles = new Vector3(0, 0, 0);
//			print(con.transform.eulerAngles);
		}

		private void OnMouseDown()
		{
			
			StartCoroutine(rotate(0.5f));
			if (isEnd)
			{
				isEnd = false;
				manager.show("医师原来就住在右边的房子里，现在里面就只住了她奶奶了，或许你能去拜访一下，看看能不能找到驱虫水配方吧", new Vector3(-18, 0, -24), 2);
			}
		}

		IEnumerator f()
		{
			log.show("您好，我是一名记者，现在要赶往前线了。您能卖给我一些干粮吗？", 2);
			yield return new WaitForSeconds(2f);
			manager.show("抱歉，我们的粮食都吃完了，而贮藏的麦子里藏了些蝗虫，再这样下去所有村民都要挨饿了，我正在烦恼这事呢", new Vector3(0, 1, 1));
			yield return new WaitForSeconds(1f);
			log.show("有什么我可以帮忙的吗", 2f);
			yield return new WaitForSeconds(2f);
			manager.show("以前我们这里还有一位会配驱虫药水的女医师，但她现在去战场上当医生了，我想给她写信但现在邮差们也都去参军了。你要是能顺路找她要到药水就好了", new Vector3(0, 1, 1));
			yield return new WaitForSeconds(3f);
			log.show("原来如此，我会想想办法的", 2);
			con.GetComponent<FPSCon>().toZero = false;
		}

		IEnumerator g()
		{
			log.show("这是我按照配方做的驱虫药", 2);
			yield return new WaitForSeconds(2f);
			manager.show("呼......总算是解决了。您等一下，我现在就去做一点食物给您", new Vector3(0, 1, 1));
		}

		private IEnumerator rotate(float m)
		{
			float i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
			float j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;
	
			while ((Mathf.Abs(i) > 0.5) || Mathf.Abs(j) > 0.5)
			{
				if (Mathf.Abs(i) > 0.5)
				{
					ca.transform.Rotate(-(Mathf.Abs(i) / i) * m, 0, 0);
					i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
				}
				if (Mathf.Abs(j) > 0.5)
				{
					con.transform.Rotate(0, (Mathf.Abs(i) / i) * m, 0);
					j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;
				}
				yield return new WaitForSeconds(0.001f);
			}
			isEnd = true;
		}
	}
}