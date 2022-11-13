using UnityEngine;

public class EnemyAudio : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] private AudioSource audios = null;
    [SerializeField] private EnemySight sight = null;

    private bool isPlay = false;

    // private void OnEnable() {
    //     sight.onSpotted += OnSpotted;
    // }
    
    // private void OnDisable() {
    //     sight.onSpotted -= OnSpotted;
    // }

    // private void OnDestroy() {
    //     sight.onSpotted -= OnSpotted;
    // }

    // private void OnSpotted(Transform target) {
    //     if(!isPlay)
    //         print("main");
    //         isPlay = true;
    //         audios.Play();
    // }
}