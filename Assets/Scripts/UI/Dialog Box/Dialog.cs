using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Dialog : MonoBehaviour {

	public GameObject dialog;
	public  GameObject[] dialogs = new GameObject[6];
	public  Text text;
	public float width;
	public bool isShow = false;
	int wordCount = 16;
	private Dialog instance;
	private string context;
	private Vector3 position;
	private float time;
	private Vector3[] oldPosition = new Vector3[6];
	// Use this for initialization

	private void Awake()
	{
		int i = 0;
		foreach (GameObject d in dialogs)
		{
			oldPosition[i] = d.GetComponent<RectTransform>().anchoredPosition3D;
			i++;
		}
		width = dialogs[1].GetComponent<RectTransform>().sizeDelta.x;

	}

	void Start () {
		//setCount(30);
	}

	public void show(string context, Vector3 position, float time = 3f)
	{
		if (dialogs[0].active == true)
			return;
		this.context = context;
		this.time = time;
		this.position = position;
		isShow = true;
	}

	public void setCount(int count)
	{
		wordCount = count;
	}

	public Dialog getInstance()
	{
		return instance;
	}

	// Update is called once per frame
	void Update () {
		if (isShow)
		{
			ajust();
			StartCoroutine(showDialog(position, context, time));
			isShow = false;
		}

		if (Black.isActive)
		{
			disappear();
		}
	}

	public void ajust()
	{
		for (int i = 1; i < dialogs.Length; i++)
		{
			dialogs[i].GetComponent<RectTransform>().sizeDelta = new Vector2(wordCount * 14 + 36, 35);
		}
		text.rectTransform.sizeDelta = new Vector2(wordCount * 14, 177);
		Vector3 v = dialogs[0].GetComponent<RectTransform>().anchoredPosition3D;
		width = dialogs[1].GetComponent<RectTransform>().sizeDelta.x;
		dialogs[0].GetComponent<RectTransform>().anchoredPosition3D =
			new Vector3(dialogs[1].GetComponent<RectTransform>().anchoredPosition3D.x - width / 2 - 35, v.y, v.z);
	}



	public IEnumerator showDialog(Vector3 position, string words, float time)
	{
		int i = words.Length / wordCount + 1; 
		text.text = words;
		dialog.GetComponent<RectTransform>().anchoredPosition3D = position;
		dialogs[0].GetComponent<RectTransform>().anchoredPosition3D =
			new Vector3(dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.x, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.y - 20 * (i - 1), dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.z);
		
		for (int j = 0; j <= i; j++)
		{
			dialogs[j].SetActive(true);
		}
		dialogs[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(dialogs[1].GetComponent<RectTransform>().anchoredPosition3D.x + 0.01f, dialogs[1].GetComponent<RectTransform>().anchoredPosition3D.y, dialogs[1].GetComponent<RectTransform>().anchoredPosition3D.z);;
		dialogs[i].SetActive(true);
		dialogs[i].GetComponent<RectTransform>().sizeDelta = new Vector2((words.Length % wordCount) *14 + 36, 35);
		dialogs[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.x, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.y + 0.1f, dialogs[0].GetComponent<RectTransform>().anchoredPosition3D.z);


		Vector3 v = dialogs[i].GetComponent<RectTransform>().anchoredPosition3D;
		//print(dialogs[i].GetComponent<RectTransform>().anchoredPosition3D.x);
		dialogs[i].GetComponent<RectTransform>().anchoredPosition3D = new Vector3(v.x - (width - dialogs[i].GetComponent<RectTransform>().sizeDelta.x) / 2, v.y, v.z);
		//print(dialogs[1].GetComponent<RectTransform>().anchoredPosition3D.x);
		

		yield return new WaitForSeconds(time);
		for (int j = 0; j <= i; j++)
		{
			dialogs[j].SetActive(false);
		}
		text.text = "";
		int k = 0;
		foreach (GameObject d in dialogs)
		{
			d.GetComponent<RectTransform>().anchoredPosition3D = oldPosition[k];
			k++;
		}
	}

	public void disappear()
	{
		for (int j = 0; j <= 5; j++)
		{
			dialogs[j].SetActive(false);
		}
		text.text = "";
	}

	public IEnumerator f()
	{
		int t = 2;
		yield return 0;
		//showDialog(new Vector3(10, 0, 0), "你好，我是克里斯托，来自中国", 2.2f);
		yield return new WaitForSeconds(t);
		Debug.Log(t);
		for (int j = 0; j <= 5; j++)
		{
			dialogs[j].SetActive(false);
		}
		text.text = "";
	}
	private static int getMax(string[] word)
	{
		int length = word[0].Length;
		foreach (string s in word)
		{
			length = length > s.Length ? length : s.Length;
		}
		return length;
	}


}
