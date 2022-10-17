using System;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public static event Action CoinPickUp;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Bird>())
            CoinPickUp?.Invoke();
    }
}
