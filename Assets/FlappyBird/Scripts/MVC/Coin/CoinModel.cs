using System;

public class Coin
{
    public event Action<int> CoinsChanged; 

    private int _currentCoins = 0;

    public void AddCoin()
    {
        _currentCoins++;
        
        CoinsChanged?.Invoke(_currentCoins);
    }
}
