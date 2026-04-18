using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
	
    [SerializeField] string TagPlayer="Player";
    [SerializeField] SphereCollider ColiderCoin;
    [SerializeField] GameObject thisCoin;
    [SerializeField]int Points=10;    
	public AudioClip _Coin;

	FXManager FXManager;    
    GameManager GameManager; 

	void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
			Debug.Log ("player detectado(Coin)");
        GameManager.Points+=Points;
        GameManager.Coins--;
       thisCoin.SetActive(false);
       ColiderCoin.enabled=false;
       FXManager.SoundPlay(_Coin);
       }
    }  
    void Update() {
      SearchManagers();
    }
    void Awake(){
      SearchManagers();
      GameManager.Coins++;
    } 
    

    void SearchManagers() {      
        if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();
        if(FXManager==null){
        FXManager=FindObjectOfType<FXManager>();
        }
      }   
    }
}
