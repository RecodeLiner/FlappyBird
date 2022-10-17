using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    private Text _coinText;
    
    private int _currentCoins = 0; 

    private void Awake()
    {
        _coinText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        CoinTrigger.CoinPickUp += OnCoinPickUp; 
    }

    private void OnDisable()
    {
        CoinTrigger.CoinPickUp -= OnCoinPickUp; 
    }

    private void OnCoinPickUp()
    {
        _currentCoins++;
        _coinText.text = _currentCoins.ToString();
    }
}
