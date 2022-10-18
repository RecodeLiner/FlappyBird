using System; 

public class CoinEvent
{
    public event Action CoinPickUp;
    
    private static CoinEvent _instance;

    public static CoinEvent Instance
    {
        get
        {
            if (_instance == null)
                _instance = new CoinEvent();

            return _instance;
        }
        set
        {
            _instance = value; 
        }
    }
    
    public void InvokeCoinEvent()
    {
        CoinPickUp?.Invoke();
    }
}
