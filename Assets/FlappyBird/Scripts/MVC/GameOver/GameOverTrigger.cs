using UnityEngine;

public class GameOverTrigger : Initable<GameOverModel>
{
    [SerializeField] private GameOverSetup resolver;

    private void Awake()
    {
        resolver.Resolve(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Bird>())
            Model.ChangeTimeScale();
    }
}
