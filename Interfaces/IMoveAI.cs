using UnityEngine;

public interface IMoveAI
{
    void Move(Vector3 destination, float changeSpeed = 0);
}