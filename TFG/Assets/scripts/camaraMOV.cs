using UnityEngine;
using System.Collections;

public class camaraMOV : MonoBehaviour {

    public bool movPermitido;

    public Transform camaraTrans;
    public Transform personajeTrans;

    public float maximoX = 3f;
    public float minimoX = -3f;

    //direccion del giro, 0 es derecha 1 es izquierda

    public int direccionGiro;


    // Use this for initialization
    void Start()
    {
        movPermitido = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //comparar posicion del personaje con el de la camara
        movPermitido = compararPosicion();

        //si el personaje se sale del rango de movimiento libre
        if (movPermitido & direccionGiro == 0)//diro derecha
        {
            //nueva posicion de la camara
            Vector3 newPos = new Vector3(personajeTrans.position.x - maximoX, camaraTrans.position.y, -10f);
            camaraTrans.position = newPos;
        }else
        if (movPermitido & direccionGiro == 1)//giro izquierda
        {
            //nueva posicion de la camara
            Vector3 newPos = new Vector3(personajeTrans.position.x - minimoX, camaraTrans.position.y, -10f);
            camaraTrans.position = newPos;
        }

    }

    //mirar si se sale del rango
    bool compararPosicion()
    {
        //se sale por la derecha
        if (personajeTrans.position.x - camaraTrans.position.x > maximoX)
        {
            direccionGiro = 0;
            return true;        
        }
        // se sale por la izquierda
        else if(personajeTrans.position.x - camaraTrans.position.x < minimoX)
        {
            direccionGiro = 1;
            return true;
        }
        return false;
    }
}