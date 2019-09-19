using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int salud = 20;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Bala"))
        {
            salud -= 2;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (salud == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
