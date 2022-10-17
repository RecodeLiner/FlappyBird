using System; 
using UnityEngine;

public class DefeatTrigger : MonoBehaviour
{
    public static event Action DefeatGame;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Bird>())
            DefeatGame?.Invoke();
    }
}
