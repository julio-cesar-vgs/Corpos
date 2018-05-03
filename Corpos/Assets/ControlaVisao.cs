using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaVisao : MonoBehaviour {

	public GameObject bola;
	private Vector3 desloca;

	// Use this for initialization
	void Start () {
		desloca = transform.position - bola.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = bola.transform.position + desloca;
	}
}
