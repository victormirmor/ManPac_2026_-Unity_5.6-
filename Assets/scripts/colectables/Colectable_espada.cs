using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colectable_espada : MonoBehaviour{
    
    //publics
    [SerializeField] float waitTime;
    [SerializeField] AudioClip _EnemyChange;
    [SerializeField] GameObject colectable;
	[SerializeField]string TagEspada = "Espada"; 
	[SerializeField]string TagPlayer = "Jugador";
	[SerializeField] Image Estado;
	[SerializeField]Sprite No; 
	[SerializeField]Sprite Si;

	//Privates
	FXManager FXManager;
	GameManager gameManager;
    Collider ColectableCollider/*,EspadaCollider*/;
    Renderer ColectableRenderer, EspadaRenderer;
	GameObject Espada;
  	

		void Awake(){
        	Espada = GameObject.FindGameObjectWithTag(TagEspada);
        	//EspadaCollider = Espada.GetComponent<Collider>();
        	ColectableCollider = colectable.GetComponent<Collider>(); 
        	EspadaRenderer = Espada.GetComponent<Renderer>();
        	ColectableRenderer = colectable.GetComponent<Renderer>();
        	FXManager = FindObjectOfType<FXManager>();
        	gameManager=FindObjectOfType<GameManager>();
			Estado.sprite = No;
      	}

    	private void OnTriggerEnter(Collider other){
      		if (other.tag == TagPlayer){
			Debug.Log ("Player detectado(Espada)");
      		FXManager.SoundPlay(_EnemyChange);
      		gameManager.IsCoin = true;
        	StartCoroutine(VidaEnemy());
        	//EspadaCollider.enabled = true;
        	EspadaRenderer.enabled = true;
        	ColectableCollider.enabled = false;
        	ColectableRenderer.enabled = false;
      	}
	}
             
	IEnumerator VidaEnemy(){
		Estado.sprite = Si;
      yield return new WaitForSeconds(waitTime);
		Estado.sprite = No;
      Debug.Log("tiempo acabado");
      //EspadaCollider.enabled = false;
      EspadaRenderer.enabled = false;
      gameManager.IsCoin = false;
      Destroy(colectable);
      }
	}
