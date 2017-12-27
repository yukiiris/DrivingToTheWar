using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
	public class Farmer : MonoBehaviour
	{
		Dialog manager;
		public GameObject fps;
		public GameObject ca;
		public GameObject con;
		bool isEnd;

		// Use this for initialization
		void Start()
		{
			
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