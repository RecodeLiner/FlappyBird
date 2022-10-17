using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [SerializeField] private AnimationCurve jumpCurve;
    [SerializeField] private float jumpMultiplier;
    [SerializeField] private float jumpTime;
    
    private Rigidbody2D _rigidbody; 
    
    private readonly int _maxJumpProgres = 1;
    
    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartJump(); 
    }

    private void StartJump()
    {
        StartJumpTimer();
    }

    private void StartJumpTimer()
    {
        float jumpProgres = 0;
        float pasedTime = 0;

        while (jumpProgres < _maxJumpProgres)
        {
            pasedTime += Time.deltaTime;
            jumpProgres = pasedTime / jumpTime;

            Jump(jumpProgres);
        }
    }

    private void Jump(float jumpProgres)
    {
        var jumpOffset = Vector2.up * jumpCurve.Evaluate(jumpProgres);
        _rigidbody.velocity = jumpOffset * jumpMultiplier; 
    }
}