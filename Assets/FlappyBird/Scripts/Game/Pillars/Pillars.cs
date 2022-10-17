using UnityEngine;

public class Pillars : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}