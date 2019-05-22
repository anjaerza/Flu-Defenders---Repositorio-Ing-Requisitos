using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasaEnemigo : MonoBehaviour {

    public int enemigosQuePasan=0;
    private int maximoEnemigos = 3;
    public string escena;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (enemigosQuePasan == maximoEnemigos)
        {
            SceneManager.LoadScene(escena);
        }   
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemigo") { 
            Destroy(collision.gameObject);

            enemigosQuePasan++;
        }
    }
}


