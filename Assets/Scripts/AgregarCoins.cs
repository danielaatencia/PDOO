using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarCoins : MonoBehaviour
{

    public int Moneda = 1000;

    private void OnDestroy()
    {
        GameController.Coin += Moneda;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
