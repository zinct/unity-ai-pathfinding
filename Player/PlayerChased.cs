using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChased : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private Transform whoIsChasingYou = null;

    private void OnCollisionEnter(Collision other) {
        if(other.collider.gameObject.layer == whoIsChasingYou.gameObject.layer)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
    }
}
