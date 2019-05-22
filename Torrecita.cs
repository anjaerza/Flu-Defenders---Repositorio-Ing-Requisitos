using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torrecita : MonoBehaviour {

    private GameObject enemigo;
    private bool esta_activa;
    public float distancia_umbral = 2;
    public GameObject balita;
    public bool verificador = false;

    public bool Esta_activa
    {
        get
        {
            return esta_activa;
        }

        set
        {
            esta_activa = value;
        }
    }

    public GameObject Enemigo
    {
        get
        {
            return enemigo;
        }

        set
        {
            enemigo = value;
        }
    }

    // Use this for initialization
    void Start () {

        InvokeRepeating("Disparar", 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        
        if(Enemigo!=null)
        {
            Debug.DrawLine(this.transform.position, enemigo.transform.position, Color.cyan);

           
        }

	}

    void OnTriggerStay2D(Collider2D unidad) 
    {

        if (unidad != null && unidad.tag=="Enemigo")
        {
            verificador = true;
            Enemigo = unidad.gameObject;
        }
            
        
    }

    

    void Disparar()
    {
        GameObject obj = Instantiate(balita, this.transform.position, Quaternion.identity);
        Bala bala = obj.GetComponent<Bala>();
        bala.ActivarBala(this);
    }

    
}
