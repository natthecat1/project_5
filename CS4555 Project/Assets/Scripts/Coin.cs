using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float maxCoin = 100;
    [SerializeField] public float currentCoin;

    public CoinBar coinBar;

    void Start()
    {
        currentCoin = 0;
        coinBar.SetMoney(currentCoin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCoin(float coins)
    {
        currentCoin += coins;
        coinBar.SetMoney(currentCoin);
    }
}
