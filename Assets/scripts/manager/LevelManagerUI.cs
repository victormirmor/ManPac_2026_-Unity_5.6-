using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerUI : MonoBehaviour
{

	[Header("Game Datos")]
	[SerializeField] int Initial_Lifes = 3, Life;
	[SerializeField] int Score;
	[SerializeField] int coins;
	[SerializeField] int _Time;
	[Header("textos")]
	[SerializeField] Text Points;
	[SerializeField] Text Lives;
	[SerializeField] Text Times;
	[SerializeField] Text VidasRestantes;
	[Header("Dependencias")]
	public float waitTime = 3;

	void Update()
	{
		Life = GameManager.lives;
		Score = GameManager.Points;
		coins = GameManager.Coins;
		_Time = GameManager.TimeS;

		Lives.text = Life.ToString();
		Times.text = _Time.ToString();
		Points.text = Score.ToString();
	}
	void Awake()
	{
		Debug.Log(coins);
		if (GameManager.lives <= 0)
		{
			GameManager.lives = Initial_Lifes;
		}
		Life = GameManager.lives;
		Lives.text = Life.ToString();
		Points.text = Score.ToString();
		VidasRestantes.text = "te quedan : " + Life + " vidas";
		Invoke("Vidas", waitTime);
	}

	public void Vidas()
	{
		VidasRestantes.text = "";
	}
}
