using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colll : MonoBehaviour
{
 private Pontuacao pontuacao;
 
     private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();

    }

   void OnCollisionEnter(Collision theCollision){
	   
		this.pontuacao.AdionarPontos();
  		Debug.Log("Hit the wall");
		
	 }
}
