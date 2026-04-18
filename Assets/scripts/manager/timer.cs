using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{



	// Update is called once per frame
	void Update()
	{

		GameManager.Times += 1.0f * Time.deltaTime;
		GameManager.TimeS = Mathf.FloorToInt(GameManager.Times);
		if (GameManager.lives == 0)
		{
			Time.timeScale = 0;
		}
	}
}
