using System; 
using UnityEngine;

public class DefeatTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<Bird>())
            DefeatEvent.Instance.InvokeDefeatEvent();
    }
}
