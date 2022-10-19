using System;

public class Score
{
    public event Action<int> ScoreChanged; 

    private int _currentScore = 0;

    public void IncreaseScore()
    {
        _currentScore++;
        
        ScoreChanged?.Invoke(_currentScore);
    }
}
