using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreTextView : Initable<Score>
{
    [SerializeField] private ScoreSetup resolver; 
    
    private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
        resolver.Resolve(this);
    }

    public override void OnInitedEnable()
    {
        Model.ScoreChanged += OnScoreChanged; 
    }
    
    public override void OnInitedDisable() 
    {
        Model.ScoreChanged -= OnScoreChanged; 
    }

    private void OnScoreChanged(int score)
    {
        _scoreText.text = score.ToString(); 
    }
}
