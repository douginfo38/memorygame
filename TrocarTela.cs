using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarTela : MonoBehaviour {

	public void jogar(){
		SceneManager.LoadScene ("cena1");
	}

	public void fim(){
		SceneManager.LoadScene ("abertura");
	}

	public void Exit(){
		Application.Quit();
	}
}
