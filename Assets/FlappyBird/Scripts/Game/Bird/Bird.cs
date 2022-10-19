using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [SerializeField] private AnimationCurve jumpCurve;
    [SerializeField] private float jumpMultiplier;
    [SerializeField] private float jumpTime;
    [SerializeField] private float rotateAngle; 
    
    private Rigidbody2D _rigidbody; 
    
    private readonly int _maxJumpProgress = 1;
    
    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Jump(); 
        
        Rotate();
    }

    private void Jump()
    {
        float progress = GetCurveProgress();
        Vector2 jumpOffset = Vector2.up * jumpCurve.Evaluate(progress);
        _rigidbody.velocity = jumpOffset * jumpMultiplier;
    }

    private float GetCurveProgress()
    {
        float jumpProgres = 0;
        float pasedTime = 0;
        
        pasedTime += Time.deltaTime;
        jumpProgres = pasedTime / jumpTime;

        if (jumpProgres >= _maxJumpProgress)
            jumpProgres = 0;

        return jumpProgres;
    }

    private void Rotate()
    {
        Vector3 newRotation = new Vector3(0, 0, _rigidbody.velocity.y * rotateAngle);
        transform.rotation = Quaternion.Euler(newRotation);
    }
}
