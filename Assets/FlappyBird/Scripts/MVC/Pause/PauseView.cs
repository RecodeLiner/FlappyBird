using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class PauseView : Initable<PauseModel>
{
    [SerializeField] private Sprite onPauseSprite;
    [SerializeField] private Sprite offPauseSprite;
    [SerializeField] private PauseSetup resolver;

    private Image _buttonImage; 
    
    private void Awake()
    {
        _buttonImage = GetComponent<Image>();
        resolver.Resolve(this);
    }

    public override void OnInitedEnable()
    {
        Model.GamePaused += OnGamePaused;
    }

    public override void OnInitedDisable()
    {
        Model.GamePaused -= OnGamePaused;
    }

    private void OnGamePaused(bool isPaused)
    {
        _buttonImage.sprite = isPaused ? onPauseSprite : offPauseSprite;
    }
}
