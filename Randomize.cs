using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour {
	private int sorteio;
	private ArrayList vetor = new ArrayList();
	private List<int> sorteio1 = new List<int>();

	public int Sorteio(int minInt, int maxInt){
		int result = Random.Range (minInt, maxInt);
		return result;
	}

	public List<int> SorteioSemRepeticao(int min, int max){

		int auxcont = 0;
		int total = max - min;

		while (auxcont < total) {

			int rand = Random.Range (min,max);
			bool inserir = true;

			if (sorteio1.Count > 0) {
				foreach (int numero in sorteio1) {
					if (numero == rand)
						inserir = false;
				}
			}

			if (inserir == true){
				sorteio1.Add (rand);
				auxcont++;
			}
		}

		return sorteio1;
	}

	public ArrayList SorteioSemRepeticaoVetor(int min, int max, int qtd){

		int auxcont = 0;

		while (auxcont < qtd) {

			int rand = Random.Range (min,max);
			bool inserir = true;

			if (vetor.Count > 0) {
				for (int i=0; i < auxcont; i++) {
					if (vetor[i].Equals(rand))
						inserir = false;
				}
			}

			if (inserir == true){
				vetor.Add(rand);
				auxcont++;
			}
		}

		return vetor;
	}
}
