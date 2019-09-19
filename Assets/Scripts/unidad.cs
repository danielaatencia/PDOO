using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unidad : MonoBehaviour
{
    public GameObject ruta;
    private int indice;
    private Vector3 posicion_Siguiente;
    private float velocidad = 1;
    private float distancia_Punto = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        void Start()
        {
            posicion_Siguiente = ruta.transform.GetChild(0).position;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = posicion_Siguiente - this.transform.position;
        this.transform.position += direccion * velocidad * Time.deltaTime;
        if (direccion.magnitude <= distancia_Punto)
        {
            if (indice+1 < ruta.transform.childCount)
            {
                indice++;
                posicion_Siguiente = ruta.transform.GetChild(indice).position;
                Debug.Log("xs" + posicion_Siguiente.x + "ys" + posicion_Siguiente.y);
            }

        }
    }
}
