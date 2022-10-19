using UnityEngine;

public class ScoreTrigger : Initable<Score>
{
    [SerializeField] private ScoreSetup resolver;

    private void Awake()
    {
        resolver.Resolve(this);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Bird>())
            Model.IncreaseScore();
    }
}
