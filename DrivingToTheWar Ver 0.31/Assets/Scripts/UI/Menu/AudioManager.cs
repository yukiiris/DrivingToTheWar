using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static bool isStop = false;
	public static bool isDecrease = false;
	public static bool isIncrease = false;
	public static float rollOff = 0.05f;
	public GameObject manager;
	public static bool[] status;
	public static AudioSource[] sources;

	private float delta = 0.25f;

	private void Awake()
	{
		sources = GetComponents<AudioSource>();
		status = new bool[sources.Length];

		for (int i = 0; i < sources.Length; i++)
		{
			if (sources[i].volume != 0)
			{
				status[i] = true;
			}
			else
			{
				status[i] = false;
			}
		}
	}

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (isStop)
		{
			StartCoroutine(stop());
			isStop = false;
		}
		if (isDecrease)
		{
			decrease();
			isDecrease = false;
		}
		if (isIncrease)
		{
			increase();
			isIncrease = false;
		}
	}

	public IEnumerator f()
	{
		yield return new WaitForSeconds(4);

		stop();
	}

	public void decrease()
	{
		foreach (AudioSource au in sources)
		{
			if (au.volume != 0)
			{
				au.volume -= delta;
			}
		}
	}

	public void increase()
	{
		for (int i = 0; i < sources.Length; i++)
		{
			if (status[i])
			{
				sources[i].volume += delta;
			}
		}
	}

	public IEnumerator stop()
	{
		foreach (AudioSource au in sources)
		{
			if (au.volume != 0)
			{
				au.volume -= rollOff;
				yield return new WaitForSeconds(0.1f);
			}
		}
	}
}