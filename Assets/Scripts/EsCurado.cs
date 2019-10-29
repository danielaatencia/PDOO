using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsCurado : MonoBehaviour
{

    [SerializeField]
    private float tiempo_de_espera = 2f;
    private float contador = 0;
    [SerializeField]
    private int tasa_de_curacion = 1;
    [SerializeField]
    private bool esta_curandose = false;
    private float distancia_umbral = 4f;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (contador > 0) { contador -= Time.deltaTime; }
        esta_curandose = curanderoCerca();
        if (esta_curandose == true && contador <= 0)
        {
            Salud curarse = GetComponent<Salud>();
            curarse.Curar(1);
            contador = tiempo_de_espera;
        }
    }

    bool curanderoCerca()
    {
        GameObject[] curanderos = GameObject.FindGameObjectsWithTag("Curacion");
        GameObject temp;
        foreach (object item in curanderos)
        {
            temp = (GameObject)item;
            if (Vector3.Distance(temp.transform.position, this.transform.position) < distancia_umbral)
            {
                return true;
            }
        }
        return false;
    }
}
