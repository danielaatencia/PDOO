using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oleadas : MonoBehaviour
{
   
        public GameObject ruta;
        private int indice;
        private Vector3 posicionInicial;
        private Vector3 posicionSiguiente;
        private float velocidad = 10;
        private float DistanciaPunto = 5f;


        // Start is called before the first frame update
        void Start()
        {
            posicionInicial = this.transform.position;
            posicionSiguiente = ruta.transform.GetChild(0).position;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 direccion;
            direccion = posicionSiguiente - this.transform.position;
            direccion.z = 0;
            this.transform.position += direccion * velocidad * Time.deltaTime;

            if (direccion.magnitude <= DistanciaPunto)
            {
                if (indice + 1 < ruta.transform.childCount)
                {
                    indice++;
                    posicionInicial = ruta.transform.GetChild(indice).position;
                }
                else
            {
                indice = 0;
                this.transform.position = posicionInicial;
                posicionSiguiente = ruta.transform.GetChild(0).position;

            }
            }

        }
    }

