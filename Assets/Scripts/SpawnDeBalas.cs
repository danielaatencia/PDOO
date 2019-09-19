using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeBalas : MonoBehaviour
{

    public GameObject bala;
    public bool aparecer = false;
    public float tiempoReaparicion;
    public float frecuencia;
    //test de deteccion
    public GameObject enemigo;
    private float distancia_umbral = 4;

    void Start()
    {
        InvokeRepeating("Aparicion", tiempoReaparicion, frecuencia);
    }

    public void Aparicion()
    {
        //test de deteccion
        float dist = (enemigo.transform.position - this.transform.position).magnitude;
        if (dist <= distancia_umbral)
        //test de deteccion
        {
            Instantiate(bala, transform.position, transform.rotation);
        if (aparecer)
        {
            CancelInvoke("Aparicion");
        }
        }
    }
}
