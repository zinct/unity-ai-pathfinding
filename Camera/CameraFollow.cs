using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothAmount;

    private void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.Backspace))
            GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
        Vector3 desiredPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothAmount * Time.fixedDeltaTime);
    }
}
