using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrincipal : MonoBehaviour {
	private SceneUI sceneUI;
	private int cardSelect1;
	private int cardSelect2;

	private Randomize sorteio;
	private Palavras tema;


	//private List<int> listCards = new List<int>();
	private ArrayList listCards = new ArrayList();
	private string[] listaPalavras = new string[24];

	private int[] numeros; 
	public Card[] cards;
	private short contCard;
	public EventSystem events;
	public GameObject GO; 

	[Header("PONTUAÇÃO")]
	public Text txtClicks;
	public Text txtErros;
	public Text txtAcertos;
	private int clicks;
	private int acertos;
	private int erros;


	void Start () {
		clicks = 0;
		acertos = 0;
		erros = 0;
		numeros = new int[5];
		tema = GetComponent<Palavras>();
		sceneUI = GetComponent < SceneUI>();
		sorteio = GetComponent<Randomize>();
		contCard = 0;
		listCards = sorteio.SorteioSemRepeticaoVetor(0,25,12); //AUMENTAR PARA 47

		//numeros = listCards.ToArray ();
		int i = 0;
		for (int l = 0; l < 2; l++) {
			foreach (int numero in listCards) {

				if (l == 0) {
					listaPalavras [i] = tema.paronimos1 [numero];
				}else{
					listaPalavras [i] = tema.paronimos2 [numero];
				}

				//Debug.Log (listCards [i].ToString ());
				Debug.Log (listaPalavras [i].ToString ());
				i += 1;
			}

		}
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

	public void ButtonClick(){
		int auxId = int.Parse(events.currentSelectedGameObject.name);

		Debug.Log ("auxId ="+ auxId.ToString ());

		if (cards [auxId].active == true) {
			contCard += 1;
			clicks += 1;
			setClicks (clicks);

			if (contCard == 1) {

				cardSelect1 = auxId;
				cards [cardSelect1].clickable = true;
				cards [cardSelect1].ChangeSprite (1,listaPalavras[cardSelect1]);
				cards [cardSelect1].active = false;

			} else if (contCard == 2) {

				cardSelect2 = auxId;
				cards [cardSelect2].clickable = true;
				cards [cardSelect2].ChangeSprite (1,listaPalavras[cardSelect2]);
				cards [cardSelect2].active = false;
				contCard = 0;
				CheckAcertos (listaPalavras[cardSelect1],listaPalavras[cardSelect2]);			
			} else {
				Debug.Log ("AAA");
			}
		} else {
			Debug.Log ("BBB");
		}
	}

	private void CheckAcertos(int card){
		events.enabled = false;

		if (card == 0) {

		} else {
			StartCoroutine ("CheckErro");
		}

		/*for (int i = 0; i <= 25; i++) {

			//lista.ToString ();
			//lista.IndexOf [2];
			if (i == card) {
				cards [i].ChangeSprite ();
				break;
			}*/

	}

	IEnumerator CheckErro(){
		yield return new WaitForSeconds(2f);
		events.enabled = true;
		cards [cardSelect1].active = true;
		cards [cardSelect1].ChangeSprite (0,"MEMORIA");
		cards [cardSelect1].clickable = false;	
		cards [cardSelect2].active = true;
		cards [cardSelect2].ChangeSprite (0,"MEMORIA");
		cards [cardSelect2].clickable = false;
		//cardSelect1 = 99;
		//cardSelect2 = 99;
		StopCoroutine("CheckErro");
	}
}
