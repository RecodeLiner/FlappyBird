using System;
using UnityEngine;

public class CoinTrigger : Initable<Coin>
{
    private void Awake()
    {
        Init(CoinSetup.Model);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Bird>())
            Model.AddCoin();
    }
}
