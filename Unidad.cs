using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unidad : MonoBehaviour {

    public GameObject ruta;
    private int indice;
    private Vector3 posicion_inicial;
    private Vector3 posicion_siguiente;
    private float vel = 1;
    private float distancia_punto = 0.5f;
    private float vida=1;
    public Image vidaperdida;

	// Use this for initialization
	void Start () {

        posicion_inicial = this.transform.position; 
        posicion_siguiente = ruta.transform.GetChild(0).position;
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = posicion_siguiente - this.transform.position;

        this.transform.position += dir * vel * Time.deltaTime;

        if(dir.magnitude<= distancia_punto)
        {
            if(indice+1<ruta.transform.childCount)
            {
                indice++;
                posicion_siguiente = ruta.transform.GetChild(indice).position;
                Debug.Log("xs" + posicion_siguiente.x + "ys" + posicion_siguiente.y);
            }

            else
            {
                indice = 0;
                this.transform.position = posicion_inicial;
                posicion_siguiente = ruta.transform.GetChild(0).position;
            }
        }
        if (vida == 0 || vida<0)
        {
            Destroy(this.gameObject);

        }

	}

    public void RecibeDano(float dano)
    {
        if (vida > 0)
        {
            vida = vida - dano;
            vidaperdida.fillAmount = vida;
        }
    }


}
