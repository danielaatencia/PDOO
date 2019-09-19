using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bala;
    public bool aparecer = false;
    public float tiempoReaparicion;
    public float frecuencia;

    void Start()
    {
        InvokeRepeating("Aparicion", tiempoReaparicion, frecuencia);
    }

    public void Aparicion()
    {
        Instantiate(bala, transform.position, transform.rotation);
        if (aparecer)
        {
            CancelInvoke("Aparicion");
        }
    }
}
