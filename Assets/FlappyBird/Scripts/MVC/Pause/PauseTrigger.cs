using UnityEngine;

public class PauseTrigger : Initable<PauseModel>
{
    [SerializeField] private PauseSetup resolver;

    private void Awake()
    {
        resolver.Resolve(this);
    }
    public void OnClick()
    {
        Model.TryPauseGame();
    }
}
