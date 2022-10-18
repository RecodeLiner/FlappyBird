using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Bird>())
            CoinEvent.Instance.InvokeCoinEvent();
    }
}
