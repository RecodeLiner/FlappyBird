using System; 
using UnityEngine;

public class GameOverModel
{
    public event Action GameOver; 
    
    public void ChangeTimeScale() 
    {
        Time.timeScale = 0;

        GameOver?.Invoke();
    } 
}
