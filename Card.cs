using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
	public int id;
	public bool active = true;
	public bool clickable = false;
	public Sprite[] image;
	private Image SPR;
	private Text texto;
	public bool start = false;
	public int selTema;

	void Start () {
		SPR = GetComponent<Image> ();
		texto = GetComponentInChildren<Text> ();
	}

	void Update(){
		if (start == true) {
				if (selTema == 1) {
					SPR.sprite = image [2];
					texto.text = "HOMÔNIMOS";
				} else {
					SPR.sprite = image [0];
					texto.text = "PARÔNIMOS";
				}
				start = false;	
		}
	}
	
	public void ChangeSprite(int nsprite, string palavra){

		if (active == true && clickable == true) {
			SPR.sprite = image [nsprite];
			texto.text = palavra;

			/*if (nsprite == 0) {
				texto.color= new Color (1f, 1f, 1f, 1f);
			} else {
				texto.color= new Color (0f, 0f, 0f, 1f);
			}*/
		}
	}
}
