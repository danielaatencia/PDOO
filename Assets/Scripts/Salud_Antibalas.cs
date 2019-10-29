using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud_Antibalas : MonoBehaviour
{
    [SerializeField]
    private int salud_Maxima = 20;
    public int salud = 20; // Establece la salud de la unidad.
    public float retraso_muerte = 5f; // Genera un retraso antes de la desaparicion de la unidad, actualmente sin ser usado, sera reemplazado por la animacion de muerte.
    public bool esta_Muerto = false;

    void Update()
    {
        if (salud <= 0)
        {
            retraso_muerte -= Time.deltaTime; // Activa el contador de muerte, sera empleado por la animacion de muerte.
            esta_Muerto = true;
        }
        if (retraso_muerte <= 0)
        {
            Destroy(this.gameObject); //Intento de desaparicion de las unidades derrotadas, genera errores, desactivado hasta encontrar una solucion o alternativa.
        }
    }
}
