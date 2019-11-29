using UnityEngine;
using System.Collections;

public class ControleCamera : MonoBehaviour {

	public GameObject jogador;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - jogador.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 posicao = new Vector3 (jogador.transform.position.x, jogador.transform.position.y, jogador.transform.position.z);
		transform.position = posicao + offset;
	}
}
