using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour, IMove {
    
    [Header("References")]
    [SerializeField] private Rigidbody rb = null;

    [Header("Settings")]
    [SerializeField] private float MoveSpeed = 0f;

    private Vector2 inputDirection = Vector2.zero;

    private void Update() {
        inputDirection = UserInput.direction; 
    }

    private void FixedUpdate() {
        Move(inputDirection);
    }

    public void Move(Vector2 direction) {
        rb.velocity = new Vector3(
            direction.x * MoveSpeed * Time.fixedDeltaTime,
            rb.velocity.y,
            direction.y * MoveSpeed * Time.fixedDeltaTime
        );
    }
}