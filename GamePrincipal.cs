using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrincipal : MonoBehaviour {
	private SceneUI sceneUI;


	void Start () {
		sceneUI = GetComponent < SceneUI>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayGame(){
		sceneUI.ChangeScene ("selecao");
	}

	public void CloseGame(){
		sceneUI.fim ();
	}

	public void StartGame(){
		sceneUI.ChangeScene ("jogo");
	}
}
