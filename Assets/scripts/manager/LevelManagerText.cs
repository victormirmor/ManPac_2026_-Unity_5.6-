using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerText: MonoBehaviour{
    public Text ganastes;
    public float waitTime=3;
    public string NextLevel, MainMenu="MainMenu";
    GameManager gamanager;
    bool GameStart;
    
    void Awake(){
        if (gamanager==null){
        gamanager = FindObjectOfType<GameManager>();
         }
    }

   void Update(){
       StartOtro();
	}

public void NextBola(){
    ganastes.text="lives:"+GameManager.lives.ToString();
        ganastes.text=" ";
    }
    public void ganaste(){
        ganastes.text=""; 
    }

    public void StartOtro(){
        if (GameManager.Coins==0 && GameStart== true){
            if(NextLevel!=MainMenu){
                ganastes.text = "Siguiente Nivel";
                GameStart=false;
                Invoke ("ganaste" ,waitTime); 
            }
            
            if(NextLevel==MainMenu){
                ganastes.text = "Juego terminado";
            }
                  
        }if(GameManager.Coins!=0){
            GameStart=true;
            ganastes.text=""; 
        }
	}  
}
    

 
