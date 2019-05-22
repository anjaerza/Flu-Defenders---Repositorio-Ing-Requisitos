using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {

    private GameObject torre;

    public GameObject Torre
    {
        get
        {
            return torre;
        }

        set
        {
            torre = value;
        }
    }

    private void Update()
    {
        Torre = GameObject.Find("Interfaz").GetComponent<SelectorTorre>().TorreSelecionada;
    }

    void OnMouseDown()
    {
        GameObject temporal;
        Vector3 pos = this.transform.position;
        pos.y = pos.y + .4f;
        temporal = Instantiate(Torre);
        temporal.transform.position = pos;
        temporal.layer = 5;
        Destroy(this.gameObject);
    }

}
