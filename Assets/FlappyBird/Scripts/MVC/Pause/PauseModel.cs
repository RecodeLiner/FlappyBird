using System; 
using UnityEngine;

public class PauseModel
{
    public event Action<bool> GamePaused;

    private bool _isPaused; 
    
    public void PauseButtonClicked()
    {
        if(!_isPaused)
        {
            Pause();
            return;
        }
      
        Resume(); 
    }

    private void Pause()
    {
        _isPaused = true;
        Time.timeScale = 0;
    }

    private void Resume()
    {
        _isPaused = false;
        Time.timeScale = 1;
    }
}
