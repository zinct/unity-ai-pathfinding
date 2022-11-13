using UnityEngine;

public class UserInput : MonoBehaviour {

    public static Vector2 direction;
    public Joystick joystick; 

    private void Update() {
        // direction.x = Input.GetAxisRaw("Horizontal");
        // direction.y = Input.GetAxisRaw("Vertical");
        direction.x = joystick.Horizontal;
        direction.y = joystick.Vertical;
        direction = direction.normalized;
    }

}