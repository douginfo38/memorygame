using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUI : MonoBehaviour {

	public void ChangeScene(string sceneName){
		switch (sceneName) {
		case "abertura":
			SceneManager.LoadScene (sceneName);
			break;

		case "objetivos":
			SceneManager.LoadScene (sceneName);
			break;

		case "selecao":
			SceneManager.LoadScene (sceneName);
			break;

		case "jogo":
			SceneManager.LoadScene (sceneName);
			break;
		}

}

	public void fim(){
		SceneManager.LoadScene ("abertura");
	}

	public void Exit(){
		Application.Quit();
	}
}