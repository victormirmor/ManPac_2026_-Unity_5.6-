using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
	string TagPlayer = "Player";
	public Transform Pu3rta;

	// detectar triggers
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag(TagPlayer))
		{
			Pu3rta.Translate(Vector3.up * Time.deltaTime, Space.World);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag(TagPlayer))
		{

		}
	}
}
