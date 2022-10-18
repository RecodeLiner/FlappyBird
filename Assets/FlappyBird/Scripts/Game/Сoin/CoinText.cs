using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    private TextMeshProUGUI _coinText;
    
    private int _currentCoins = 0; 

    private void Awake()
    {
        _coinText = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        CoinEvent.Instance.CoinPickUp += OnCoinPickUp; 
    }

    private void OnDisable()
    {
        CoinEvent.Instance.CoinPickUp -= OnCoinPickUp; 
    }

    private void OnCoinPickUp()
    {
        _currentCoins++;
        _coinText.text = _currentCoins.ToString();
    }
}
