using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static int lives, Coins, Points, TimeS;
	public static float Times;
	public static GameManager gameManager;
	public bool IsCoin;

	void Awake()
	{
		if (gameManager != null)
		{
			Destroy(this);
		}
		else
		{
			gameManager = this;
			DontDestroyOnLoad(this);
		}
	}
	void Update()
	{
	}

}
