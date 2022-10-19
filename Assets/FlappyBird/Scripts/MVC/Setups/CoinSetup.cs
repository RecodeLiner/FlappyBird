using UnityEngine;

public class CoinSetup : MonoBehaviour
{
    public static Coin Model;
    
    private void Awake()
    {
        Model = new Coin();
    }
}
