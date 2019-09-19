using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2: MonoBehaviour
{

    public float velocidad;
    private Waypoints wpoints;

    private int contador;

    void Start()
    {
        wpoints = GameObject.FindGameObjectWithTag("Waypoints2").GetComponent<Waypoints>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, wpoints.waypoints[contador].position, velocidad * Time.deltaTime);

        if(Vector3.Distance(transform.position, wpoints.waypoints[contador].position) < 0.1f)
        {
            contador++;
        }
    }
}
