using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaBola : MonoBehaviour
{

    //Variáveis a serem expostas no Unity
    public float velocidade;

    //Variáveis Globais reservadas ao processamento
    private Rigidbody corpo;

    //
    public Text txtVencedor;

    //variavel para controlar o score do jgoo
    private int contador;

    public Text txtContador;

    public void ajustaPlacar()
    {
        txtContador.text = "Placa: " + contador.ToString();
        if (contador == 8)
        {
            txtVencedor.text = "Voce ganhou";
        }
        else if (contador == 7)
        {
            txtVencedor.text = "Falta um";
        }
    }


    // Use this for initialization
    void Start()
    {
        corpo = GetComponent<Rigidbody>();
        contador = 0;
        ajustaPlacar();
        txtVencedor.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(horizontal, 0.0f, vertical);
        corpo.AddForce(movimento * velocidade);
    }

    void OnTriggerEnter(Collider outro)
    {
        if (outro.gameObject.CompareTag("Caixa"))
        {
            outro.gameObject.SetActive(false);
            contador += 1;
            ajustaPlacar();
        }
    }
}
