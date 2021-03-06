﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PajaroZombie : MonoBehaviour {

    [SerializeField] private Text marcador;
    [SerializeField] private float fuerza = 10f;
    [SerializeField] ParticleSystem explosion;
    [SerializeField] AudioSource sonidoMuerte;
    [SerializeField] AudioSource sonidoPaso;
    [SerializeField] float tiempoFinalizaPartida = 3f;
    private Rigidbody rb;

    private void Start()
    {
        GameConfig.Arrancajuego();
        rb = GetComponent<Rigidbody>();
        ActualizarMarcador();
        
    }

    void Update () {
		if(Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * fuerza);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        sonidoMuerte.Play();
        GameConfig.ParaJuego();
        Invoke("FinalizarPartida", tiempoFinalizaPartida);
        this.gameObject.SetActive(false);
        Instantiate(explosion, transform.position, Quaternion.identity);
    }

    private void FinalizarPartida()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        sonidoPaso.Play();
        GameConfig.SetPuntuacion(GameConfig.GetPuntuacion() + 1);
        ActualizarMarcador();
    }

    private void ActualizarMarcador()
    {
        marcador.text = "Puntación: " + GameConfig.GetPuntuacion().ToString();
    }
}
