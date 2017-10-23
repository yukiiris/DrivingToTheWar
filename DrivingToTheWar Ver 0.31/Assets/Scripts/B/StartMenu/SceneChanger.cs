using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	static public string toUnload;
	static public string toLoad;
	static public string Sub;
	static public float delayTime;
	static bool isChanging = false;
	public GameObject black;
	//public static GameObject itemBlock;

	static public void Change(string tounload, string toload, string sub = "", float delaytime = 0.4f)
	{
		if (!isChanging)
		{
			toUnload = tounload;
			toLoad = toload;
			Sub = sub;
			delayTime = delaytime;
			if (delayTime < 0.1f) delayTime = 0.4f;
			isChanging = true;
		}
	}

	private void Awake()
	{
		//itemBlock = GameObject.FindGameObjectWithTag("ItemBlock");
		//itemBlock.SetActive(false);
	}
	// Use this for initialization
	void Start()
	{	
		//StartCoroutine(ch());
	}

	private void Update()
	{
		if (isChanging)
		{
			black.SetActive(true);
			StartCoroutine(ch());
			isChanging = false;
		}
	}


	IEnumerator ch()
	{
		Fade.FadeIn(black);
		yield return new WaitForSeconds(0.5f);
		SceneManager.UnloadSceneAsync(toUnload);
		yield return new WaitForSeconds(delayTime + 1f);
		Fade.FadeOut(black);
		SceneManager.LoadScene(toLoad, LoadSceneMode.Additive);
		isChanging = false;
		yield return new WaitForSeconds(0.4f);
		black.SetActive(false);
	}
}