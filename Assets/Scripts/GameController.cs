using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{

    public static int Coin = 1000;
    public string coinString = "Coins";

    public Text TextCoin;

    public static GameController Gamecontroller;

    private void Awake()
    {
        Gamecontroller = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextCoin != null)
        {
            TextCoin.text = coinString + Coin.ToString();
        } 
    }
}
