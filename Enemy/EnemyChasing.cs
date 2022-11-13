using UnityEngine;

public class EnemyChasing : MonoBehaviour {

    [Header("References")]
    [SerializeField] private EnemySight sight;

    [Header("Settings")]
    [SerializeField] private float speedChasing = 0f;

    private void Awake() {
        sight = GetComponent<EnemySight>();
    }

    private void OnEnable() {
        sight.onSpotted += OnSpotted;
    }

    private void OnDisable() {
        sight.onSpotted -= OnSpotted;
    }

    private void OnDestroy() {
        sight.onSpotted -= OnSpotted;
    }

    private void OnSpotted(Transform target) {
        IMoveAI script = GetComponent<IMoveAI>();
        script.Move(target.position, speedChasing);
    }

}