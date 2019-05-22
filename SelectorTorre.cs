using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorTorre : MonoBehaviour {

    public GameObject[] torres= new GameObject[3];
    private GameObject torreSelecionada;
    private int num = 0;

    public int Num
    {
        get
        {
            return num;
        }

        set
        {
            num = value;
        }
    }

    public GameObject TorreSelecionada
    {
        get
        {
            return torreSelecionada;
        }

        set
        {
            torreSelecionada = value;
        }
    }

    // Use this for initialization

    // Update is called once per frame
    void Update () {

        TorreSelecionada = torres[Num];
		
	}

    public void SeleccionTorre(int tipo)
    {
        Num = tipo;
    }
}
