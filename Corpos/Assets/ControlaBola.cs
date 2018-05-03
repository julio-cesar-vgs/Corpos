using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaBola : MonoBehaviour {

	//Variáveis a serem expostas no Unity
	public float velocidade;

	//Variáveis Globais reservadas ao processamento
	private Rigidbody corpo;

	// Use this for initialization
	void Start () {
		corpo = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 movimento = new Vector3 (horizontal, 0.0f, vertical);
		corpo.AddForce(movimento * velocidade);
	}

	void OnTriggerEnter(Collider outro) {
		if(outro.gameObject.CompareTag("Caixa")) {
			outro.gameObject.SetActive(false);
		}
	}
}
