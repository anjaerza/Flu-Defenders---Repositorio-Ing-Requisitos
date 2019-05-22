using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVida : MonoBehaviour {

    private GameObject monstruo;
    public GameObject vidat;
    public GameObject vidap;
    float escala = .001f;
    SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        sr = vidap.GetComponent<SpriteRenderer>();

        monstruo = this.transform.parent.gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(sr.transform.localScale.x>0)
        {
            sr.transform.localScale -= new Vector3(escala, 0);
            vidap.transform.position = monstruo.transform.position - new Vector3(.3f -sr.bounds.size.x/2,-.4f);
            vidat.transform.position = monstruo.transform.position - new Vector3(.05f ,-.4f);
        }
	}
}
