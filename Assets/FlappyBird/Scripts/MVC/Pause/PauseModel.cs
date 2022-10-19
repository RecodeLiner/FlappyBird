using System; 
using UnityEngine;

public class PauseModel
{
    public event Action<bool> GamePaused;

    private bool _isPaused; 
    
    public void TryPauseGame()
    {
        _isPaused = _isPaused == false; 
        Time.timeScale = _isPaused ? 0 : 1;

        GamePaused?.Invoke(_isPaused);
    }
}
