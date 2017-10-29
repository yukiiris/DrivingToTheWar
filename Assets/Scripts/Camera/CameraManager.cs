using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour {

	public static float moveSpeed = 0.2f;
	public static Transform trans;
	private static float delta = 0;
	public static bool moveRight = false;
	public static bool moveLeft = false;
	static public GameObject toUnload;
	static public GameObject toLoad;
	static public string Sub;
	static public float delayTime;
	static public bool isChanging = false;
	public GameObject black;
	public Text text;
	// Use this for initialization

	private void Awake()
	{
		//trans = GameObject.FindGameObjectWithTag("MainCamera").transform;
		SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
	}

	void Start()
	{
		trans = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}

	public static void change(GameObject toLoad, GameObject toUnload)
	{
		CameraManager.toLoad = toLoad;
		CameraManager.toUnload = toUnload;
	}

	// Update is called once per frame
	void Update()
	{
		if (isChanging)
		{
			black.SetActive(true);
			text.text = "";
			StartCoroutine(ch());
			isChanging = false;
		}
		if (moveLeft)
		{
			delta += moveSpeed;
			moveToLeft();
			if (delta - 3 > 0.05)
			{
				moveLeft = false;
				delta = 0;
			}
		}
		if (moveRight)
		{
			delta += moveSpeed;
			moveToRight();
			if (delta - 3 >0.05f)
			{
				moveRight = false;
				delta = 0;
			}
		}

	}
	IEnumerator ch()
	{
		black.SetActive(true);
		Fade.FadeIn(black);
		yield return new WaitForSeconds(0.2f);
		toUnload.SetActive(false);
		toLoad.SetActive(true);
		Fade.FadeOut(black);
		yield return new WaitForSeconds(0.2f);
		black.SetActive(false);
	}


	public static void moveToRight()
	{
		trans.position = new Vector3(trans.position.x + moveSpeed, trans.position.y, trans.position.z);
	}

	public static void moveToLeft()
	{
		trans.position = new Vector3(trans.position.x - moveSpeed, trans.position.y, trans.position.z);
	}

	public static void moveTo(int x)
	{

	}
}
