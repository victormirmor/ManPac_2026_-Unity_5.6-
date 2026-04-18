#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour {
	public Dropdown DropdownQuality, DropdownShadows, DropdownVsync, DropdownantiAliasing;
	void Start(){
		DropdownantiAliasing.value = PlayerPrefs.GetInt("antiAliasing");		
		DropdownQuality.value = PlayerPrefs.GetInt("Quality");
		DropdownShadows.value = PlayerPrefs.GetInt("Shadows");
		DropdownVsync.value = PlayerPrefs.GetInt("Vsync");
		
	}

	void OnDisable(){
		PlayerPrefs.SetInt("antiAliasing", DropdownantiAliasing.value);
		PlayerPrefs.SetInt("Quality",DropdownQuality.value);
		PlayerPrefs.SetInt("Shadows", DropdownShadows.value);
		PlayerPrefs.SetInt("Vsync",DropdownVsync.value);
    }

	public void Get_Quality (int Level){		
		if(Level==0){ QualitySettings.SetQualityLevel(0,false);}
		if(Level==1){ QualitySettings.SetQualityLevel(1,true) ;}
		if(Level==2){ QualitySettings.SetQualityLevel(2,true) ;}
		if(Level==3){ QualitySettings.SetQualityLevel(3,true) ;}
	}

	public void ShadowsLevel(int Level){
		if (Level == 0){QualitySettings.shadows = ShadowQuality.Disable;}
		if (Level == 1){QualitySettings.shadows = ShadowQuality.HardOnly;}
		if (Level == 2){QualitySettings.shadows = ShadowQuality.All;}
	Debug.Log(QualitySettings.shadows);
	}

	public void Vsync(int Vsync){
	if (Vsync == 0){QualitySettings.vSyncCount = 0;}
	if (Vsync == 1){QualitySettings.vSyncCount = 1;}
	if (Vsync == 2){QualitySettings.vSyncCount = 2;}
	Debug.Log(QualitySettings.vSyncCount);
	}

	public void Set_antiAliasing(int Level){
	if (Level == 0){QualitySettings.antiAliasing = 0;}
	if (Level == 1){QualitySettings.antiAliasing = 2;}
	if (Level == 2){QualitySettings.antiAliasing = 4;}
	if (Level == 3){QualitySettings.antiAliasing = 8;}
	Debug.Log(QualitySettings.antiAliasing);
	}
}
