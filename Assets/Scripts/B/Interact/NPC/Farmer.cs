using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
	public class Farmer : MonoBehaviour
	{
		public LockCameraAndShowMenu l;
		Dialog manager;
		//public GameObject fps;
		public GameObject ca;
		public GameObject con;
		bool isEnd;

		// Use this for initialization
		void Start()
		{
			//l.flag = false;
		}

		// Update is called once per frame
		void Update()
		{

		}

		private void OnMouseDown()
		{
			
			StartCoroutine(rotate());
			if (isEnd)
			{
				manager = GameObject.Find("DialogManager").GetComponent<Dialog>();
				manager.show("asddsfDS", new Vector3(-18, 0, -24), 2);
			}
		}

		IEnumerator f()
		{
			manager.show("抱歉，我们的粮食都吃完了，而贮藏的麦子里藏了些蝗虫，再这样下去所有村民都要挨饿了，我正在烦恼这事呢", new Vector3(0, 1, 1));
			yield return new WaitForSeconds(1f);
			manager.show("以前我们这里还有一位会配驱虫药水的女医师，但她现在去战场上当医生了，我想给她写信但现在邮差们也都去参军了。你要是能顺路找她要到药水就好了", new Vector3(0, 1, 1));
		}

		private IEnumerator rotate()
		{
			float i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
			float j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;
	
			while ((Mathf.Abs(i) > 0.5) || Mathf.Abs(j) > 0.5)
			{
				if (Mathf.Abs(i) > 0.5)
				{
					ca.transform.Rotate(-(Mathf.Abs(i) / i) * 0.5f, 0, 0);
					i = ca.transform.eulerAngles.x > 180 ? ca.transform.eulerAngles.x - 360 : ca.transform.eulerAngles.x;
				}
				if (Mathf.Abs(j) > 0.5)
				{
					con.transform.Rotate(0, (Mathf.Abs(i) / i) * 0.5f, 0);
					j = con.transform.eulerAngles.y > 180 ? con.transform.eulerAngles.y - 360 : con.transform.eulerAngles.y;
				}
				yield return new WaitForSeconds(0.001f);
			}
			isEnd = true;
		}
	}
}