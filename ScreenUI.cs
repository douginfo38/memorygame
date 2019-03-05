using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenUI : MonoBehaviour {

	[Header("SPLASH")]
	[SerializeField]
	private Image splash;
	public bool ativarSplash;
	public int tempoSegundos;

	[Header("ABERTURA")]
	[SerializeField]
	private Image abertura;
	public GameObject botoesAbertura;

	[Header("OBJETIVOS")]
	[SerializeField]
	private Image objetivos;
	public GameObject botoesObjetivos;

	[Header("FASE 1")]
	[SerializeField]
	private Image fase1;

	[Header("CREDITOS")]
	[SerializeField]
	private Image credito;

	[Header("GAME OVER")]
	[SerializeField]
	private Image gameover;

	[Header("FINAL")]
	[SerializeField]
	private Image final;

	[Header("NONE")]
	[SerializeField]
	private Image erro;

	//Inicialização da classe
	void Start () {
		if (ativarSplash == true) {
			StartCoroutine ("SplashScreen");
		} else {
			if (abertura != null) {
				abertura.gameObject.SetActive (true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Contador do tempo do Splash Screen
	private IEnumerator SplashScreen () {
		yield return new WaitForSeconds (tempoSegundos);
		ativarSplash = false;
		splash.gameObject.SetActive (false);
		StopCoroutine("SplashScreen");
	}

	//Metodo para trocar as telas do jogo
	public void ChangeScreen(string name){	
		switch (name) {
		case "abertura":
			abertura.gameObject.SetActive (true);
			break;

		case "fase1":
			fase1.gameObject.SetActive (true);
			break;

		case "objetivos":
			botoesAbertura.SetActive (false);
			botoesObjetivos.SetActive (true);
			objetivos.gameObject.SetActive (true);
			break;

		case "creditos":
			credito.gameObject.SetActive (true);
			break;

		case "gameover":
			gameover.gameObject.SetActive (true);
			break;

		case "final":
			final.gameObject.SetActive (true);
			break;
		}
	}
}
