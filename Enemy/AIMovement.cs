using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class AIMovement : MonoBehaviour {
    
    public NavMeshAgent agent;

    public bool Move(Vector3 destination) {
        return agent.SetDestination(destination);
    }

}