using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nueva_Oleada : MonoBehaviour
{
    public static ArrayList NuevaOleada = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        GameObject unidad = GameObject.Find("unidad_01");
        GameObject temporal;
        Vector3 incremento = new Vector3(0, 1);
        Vector3 posicionInicial = unidad.transform.position;

        for (int i = 0; i < 10; i++)
        {
            temporal = (GameObject)Instantiate(unidad, posicionInicial + incremento, Quaternion.identity);
            posicionInicial = temporal.transform.position;
            NuevaOleada.Add(temporal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
