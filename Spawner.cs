using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spawner : MonoBehaviour {

    public GameObject enemigo;
    public float tiempo = 3f;
    public Transform[] puntoSpawn;
    public int maxEnemigos=15;
    public int contEnemigos=0;
    private GameObject[] listaenemigos;


	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawn", tiempo, tiempo);
        InvokeRepeating("DetectarEnemigos",10,3);
		
	}

    void Update()
    {
       

        
    }

    // Update is called once per frame
    void Spawn () {

        int spawnPointIndex = Random.Range(0, puntoSpawn.Length);

        if (contEnemigos < maxEnemigos)
        {
            Instantiate(enemigo, puntoSpawn[spawnPointIndex].position, puntoSpawn[spawnPointIndex].rotation);
            contEnemigos++;
        }

	}

    void DetectarEnemigos()
    {
        listaenemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        if (listaenemigos.Length == 0)
            SceneManager.LoadScene("Victoria");
    }
}
