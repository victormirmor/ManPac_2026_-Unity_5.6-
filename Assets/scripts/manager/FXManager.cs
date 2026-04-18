using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour {

	public AudioSource AudioS;

	public void SoundPlay (AudioClip Audio) {
		
		AudioS.clip=Audio;
		AudioS.Play ();

	}
}
