using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class AIPatrol : MonoBehaviour, IMoveAI {
    
    [Header("References")]
    public NavMeshAgent agent;

    [Header("Status")]
    public bool isPatroling = false;

    [Header("Patrol Settings")]
    public bool isWaitingTime;
    public float waitingTime;

    [Header("Path")]
    public List<Transform> pathPatrols;

    private void Update() {
        if(agent.remainingDistance == 0) {
            if(isPatroling) {
                isPatroling = false;
                StartCoroutine(DoPatrol());
            }
        }
    }

    public IEnumerator DoPatrol() {
        if(isWaitingTime)
            yield return new WaitForSeconds(waitingTime);

        yield return null;
        Move(pathPatrols[UnityEngine.Random.Range(0, pathPatrols.Count)].position);
    }

    public void Move(Vector3 destination, float changeSpeed = 0) {
        if(!isPatroling)
            isPatroling = true;

        if(changeSpeed != 0)
            agent.speed = changeSpeed;
        else
            agent.speed = 4f;
        
        agent.SetDestination(destination);
    }
}