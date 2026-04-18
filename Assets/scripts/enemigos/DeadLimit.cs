using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class DeadLimit : MonoBehaviour
{
    #region Variables Originales
    [Header("Player")]
    [SerializeField] string TagJugador;
    [SerializeField] Vector3 Destino;


    [Header("Game Datos")]
    public float waitTime = 3;
    public Text levelText;
    GameObject Player;
    #endregion

    #region Nuevas Variables de Efectos
    [Header("Efectos")]
    [SerializeField] GameObject efectoParticulas;
    [SerializeField] AudioClip sonidoMuerte;
    AudioSource audioSource;
    #endregion

    void Awake()
    {
        levelText.text = "";
        Player = GameObject.FindGameObjectWithTag(TagJugador);
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == TagJugador)
        {
            // --- EFECTOS ---
            if (efectoParticulas != null)
            {
                Instantiate(efectoParticulas, Player.transform.position, Quaternion.identity);
            }
            if (sonidoMuerte != null && audioSource != null)
            {
                audioSource.PlayOneShot(sonidoMuerte);
            }
            // ---------------

            GameManager.lives--;

            if (GameManager.lives < 0)
            {
                Debug.Log("perdiste el juego");
                levelText.text = "Perdiste el juego";
                Player.SetActive(false);
            }
            else
            {
                Player.SetActive(false);
                levelText.text = "lives: " + GameManager.lives.ToString();
                Invoke("DeadL", waitTime);
            }
        }
    }

    private void DeadL()
    {
        Player.transform.position = Destino;
        Player.SetActive(true);
        levelText.text = "";
    }
}