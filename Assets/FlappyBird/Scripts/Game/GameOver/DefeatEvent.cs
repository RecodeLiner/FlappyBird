using System; 

public class DefeatEvent
{
    public event Action GameDefeated;
    
    private static DefeatEvent _instance;

    public static DefeatEvent Instance
    {
        get
        {
            if (_instance == null)
                _instance = new DefeatEvent();

            return _instance;
        }
        set
        {
            _instance = value; 
        }
    }
    
    public void InvokeDefeatEvent()
    {
        GameDefeated?.Invoke();
    }
}
