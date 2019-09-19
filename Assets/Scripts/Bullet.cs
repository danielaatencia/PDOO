using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 20;

    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Enemigo");
        objetivo = go.transform;
        // rotate the projectile to aim the target:
        myTransform.LookAt(objetivo);
    }

    // Update is called once per frame
    void Update()
    {
        // distance moved since last frame:
        float seguirObjetivo = velocidad * Time.deltaTime;
        // translate projectile in its forward direction:
        myTransform.Translate(Vector3.forward * seguirObjetivo);
    }
}
