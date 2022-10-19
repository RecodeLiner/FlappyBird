using UnityEngine;

public class GameOverTrigger : Initable<GameOverModel>
{
    private void Awake()
    {
        Init(GameOverSetup.Model);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Bird>())
            Model.ChangeTimeScale();
    }
}
