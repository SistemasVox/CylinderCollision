using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
	[SerializeField]
    private Text textoPontuacao;
	
    private int pontos = -1;


     public void AdionarPontos()
    {
        this.pontos++;
        Debug.Log(this.pontos);
        this.textoPontuacao.text = this.pontos.ToString();
    }
}
