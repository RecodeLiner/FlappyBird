using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CoinTextView : Initable<Coin>
{
    private TextMeshProUGUI _coinsText;

    private void Awake()
    {
        _coinsText = GetComponent<TextMeshProUGUI>();
        Init(CoinSetup.Model);
    }
    
    public override void OnInitedEnable()
    {
        Model.CoinsChanged += OnCoinsChanged; 
    }
    
    public override void OnInitedDisable() 
    {
        Model.CoinsChanged -= OnCoinsChanged; 
    }

    private void OnCoinsChanged(int coins)
    {
        _coinsText.text = coins.ToString(); 
    }
}
