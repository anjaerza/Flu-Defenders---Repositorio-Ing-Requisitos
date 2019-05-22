using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public GameObject objetivo;
    private float velocidad = 3.5f;
    public float dano=0;
    public float velo = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direccion;
        if (objetivo != null)
        {
            direccion = objetivo.transform.position - this.transform.position;
            this.transform.position += velocidad * direccion * Time.deltaTime;
        }

        else
        {
            Destroy(this.gameObject);
        }


    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.gameObject != null)
        {
            if (otro.gameObject.tag == "Enemigo")
            {   
                otro.gameObject.GetComponent<Unidad>().RecibeDano(dano);
                otro.gameObject.GetComponent<Unidad>().Vel=(otro.gameObject.GetComponent<Unidad>().Vel)*(velo/100);
                otro.gameObject.GetComponent<Animator>().Play("damage");
                otro.gameObject.GetComponent<Animator>().Play("New Animation");
                Destroy(this.gameObject);
            }
        }


    }

    public void ActivarBala(Torrecita torre)
    {
        objetivo = torre.Enemigo;
    }
}
