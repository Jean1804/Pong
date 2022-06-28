using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public float velocidad = 30.0f;


	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidad;
	}

    private void OnCollisionEnter2D(Collision2D micolision)
    {
        if(micolision.gameObject.name == "Raqueta Izquierda")
        {
            int x = 1;

            int y = direccionY(transform.position, micolision.transform.position);

            Vector2 direccion = new Vector2(x, y);

            GetComponent<Rigidbody2D>().velocity = direccion * velocidad;
        }

        if(micolision.gameObject.name == "Raqueta Derecha")
        {
            int x = -1;

            int y = direccionY(transform.position, micolision.transform.position);

            Vector2 direccion = new Vector2(x, y);

            GetComponent<Rigidbody2D>().velocity = direccion * velocidad;
        }

    }

    int direccionY(Vector2 posicionBola, Vector2 posicionRaqueta)
    {
        if(posicionBola.y > posicionRaqueta.y)
        {
            return 1;
        }
        else if(posicionBola.y < posicionRaqueta.y)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }



    // Update is called once per frame
    void Update () {
		
	}
}
